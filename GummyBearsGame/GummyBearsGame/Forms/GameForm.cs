using GummyBearsGame.GameService;
using GummyBearsGame.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GummyBearsGame.Forms
{
    public partial class GameForm : Form
    {
        private ServiceClient _gameService;
        private string _sessionHandle;
        private Game _game;
        private Field _activeField;
        private int _activeIndex = -1;

        public GameForm(ServiceClient gameService, string sessionHandle, Game game)
        {
            InitializeComponent();
            _gameService = gameService;
            _game = game;
            _sessionHandle = sessionHandle;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            EnableOperations();
            UpdateGame();
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            DrawMap();
        }

        private void UpdateGame()
        {
            _activeField = null;
            _activeIndex = -1;
            DrawMap();
            EnableOperations();
            
            goldLabel.Text = $"Złoto: {_game.Map.Money}";
            juiceLabel.Text = $"Sok z gumijagód: {_game.Map.Juice}";

            if (_game.IsFinished)
            {
                MessageBox.Show($"Koniec gry! Wynik: {_game.Score}");
                Close();
            }
        }

        private void DrawMap()
        {
            var map = _game.Map;

            Graphics g = gamePanel.CreateGraphics();
            g.Clear(gamePanel.BackColor);
            float w = (float)Math.Floor(gamePanel.Width / (float)map.Width);
            float h = (float)Math.Floor(gamePanel.Height / (float)map.Height);

            int k = 0;
            for (int j = 0; j < map.Height; j++)
                for (int i = 0; i < map.Width; i++)
                {
                    var field = map.Fields[k];

                    Brush brush = new SolidBrush(field.Owner == FieldOwner.NoOne ? Color.Silver : (field.Owner == FieldOwner.Blocked ? Color.Gray :(field.Owner == FieldOwner.Player ? Color.LimeGreen : Color.Tomato)));
                    Pen blackPen = new Pen(Color.Black);
                    Pen activePen = new Pen(Color.Gold);
                    Brush blackBrush = new SolidBrush(Color.Black);
                    Font smallFont = new Font("Arial", 7);
                    Font font = new Font("Arial", 12);

                    g.FillRectangle(brush, w * i + 1, h * j + 1, w - 2, h - 2);
                    //g.DrawRectangle(blackPen, w * i + 1, h * j + 1, w - 2, h - 2);
                    if (field == _activeField) g.DrawRectangle(blackPen, w * i, h * j, w - 1, h - 1);
                    if (field.Owner != FieldOwner.Blocked)
                    {
                        if (field.Owner != FieldOwner.NoOne)
                        {
                            Image image = null;
                            switch (field.GummiesType)
                            {
                                case GummyType.Basic:
                                    image = field.Owner == FieldOwner.Player ? Resources.gummiBasic : Resources.trollBasic;
                                    break;
                                case GummyType.Magical:
                                    image = field.Owner == FieldOwner.Player ? Resources.gummiMagic : Resources.trollMagic;
                                    break;
                                case GummyType.Warrior:
                                    image = field.Owner == FieldOwner.Player ? Resources.gummiWarrior : Resources.trollWarrior;
                                    break;
                            }

                            if (field.GummiesNumber > 0)
                            {
                                g.DrawImage(image, new RectangleF(w * i + 5, h * j + 20, w - 60, h - 40));
                                g.DrawString($"x{field.GummiesNumber.ToString("N2")}", font, blackBrush, w * i + w - 55, h * j + 20);
                            }
                        }

                        g.DrawString($"Gumisie: {field.GummiesMultiplier}", smallFont, blackBrush, w * i + w - 60, h * j + h - 48);
                        g.DrawString($"Sok: {field.JuiceMultiplier}", smallFont, blackBrush, w * i + w - 60, h * j + h - 36);
                        g.DrawString($"Złoto: {field.GoldMultiplier}", smallFont, blackBrush, w * i + w - 60, h * j + h - 24);
                        g.DrawString($"Obrona: x{1.5}", smallFont, blackBrush, w * i + w - 60, h * j + h - 12);
                    }

                    k++;
                }
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            DrawMap();
        }

        private void gamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X * _game.Map.Width / gamePanel.Width;
            int y = e.Y * _game.Map.Height / gamePanel.Height;
            int index = y * _game.Map.Width + x;
            if (_game.Map.Fields[index].Owner == FieldOwner.Player)
            {
                _activeField = _game.Map.Fields[index];
                _activeIndex = index;
                EnableOperations();
                DrawMap();
            }
        }

        private void EnableOperations()
        {
            if (_activeField == null)
            {
                actionsPanel.Controls.OfType<Button>().ToList().ForEach(b => b.Enabled = false);
            }
            else
            {
                var possibilities = _activeField.PossibleActions;

                sacrificeButton.Enabled = possibilities.HasFlag(PossibleActions.Sacrifice);

                improveWarriorButton.Enabled = possibilities.HasFlag(PossibleActions.ImproveWarrior);
                improveMagicButton.Enabled = possibilities.HasFlag(PossibleActions.ImproveMagic);

                attackLeftButton.Enabled = possibilities.HasFlag(PossibleActions.AttackLeft);
                attackRightButton.Enabled = possibilities.HasFlag(PossibleActions.AttackRight);
                attackUpButton.Enabled = possibilities.HasFlag(PossibleActions.AttackUp);
                attackDownButton.Enabled = possibilities.HasFlag(PossibleActions.AttackDown);

                moveLeftButton.Enabled = possibilities.HasFlag(PossibleActions.Left);
                moveRightButton.Enabled = possibilities.HasFlag(PossibleActions.Right);
                moveUpButton.Enabled = possibilities.HasFlag(PossibleActions.Up);
                moveDownButton.Enabled = possibilities.HasFlag(PossibleActions.Down);

                attackWithJuiceLeftButton.Enabled = possibilities.HasFlag(PossibleActions.BoostLeft);
                attackWithJuiceRightButton.Enabled = possibilities.HasFlag(PossibleActions.BoostRight);
                attackWithJuiceUpButton.Enabled = possibilities.HasFlag(PossibleActions.BoostUp);
                attackWithJuiceDownButton.Enabled = possibilities.HasFlag(PossibleActions.BoostDown);
            }

            endTourButton.Enabled = true;
            surrendButton.Enabled = true;
        }

        #region User Actions

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Move, Field1 = _activeIndex, Field2 = _activeIndex - _game.Map.Width };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Move, Field1 = _activeIndex, Field2 = _activeIndex + _game.Map.Width };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Move, Field1 = _activeIndex, Field2 = _activeIndex + 1 };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Move, Field1 = _activeIndex, Field2 = _activeIndex - 1 };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void attackUpButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Attack, Field1 = _activeIndex, Field2 = _activeIndex - _game.Map.Width };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void attackDownButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Attack, Field1 = _activeIndex, Field2 = _activeIndex + _game.Map.Width };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void attackRightButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Attack, Field1 = _activeIndex, Field2 = _activeIndex + 1 };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void attackLeftButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Attack, Field1 = _activeIndex, Field2 = _activeIndex - 1 };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void attackWithJuiceUpButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.MoveWithJuice, Field1 = _activeIndex, Field2 = _activeIndex - _game.Map.Width };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void attackWithJuiceDownButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.MoveWithJuice, Field1 = _activeIndex, Field2 = _activeIndex + _game.Map.Width };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void attackWithJuiceRightButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.MoveWithJuice, Field1 = _activeIndex, Field2 = _activeIndex + 1 };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void attackWithJuiceLeftButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.MoveWithJuice, Field1 = _activeIndex, Field2 = _activeIndex - 1 };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void surrendButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Surrender };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void endTourButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Void };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void sacrificeButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Sacrifice };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void improveMagicButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Upgrade, Field1 = _activeIndex, State = true };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        private void improveWarriorButton_Click(object sender, EventArgs e)
        {
            GameAction action = new GameAction() { Action = ActionType.Upgrade, Field1 = _activeIndex, State = false };
            _game = _gameService.MakeMove(_sessionHandle, action);
            UpdateGame();
        }

        #endregion
    }
}
