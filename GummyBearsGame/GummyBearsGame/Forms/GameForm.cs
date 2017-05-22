using GummyBearsGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GummyBearsGame.Forms
{
    public partial class GameForm : Form
    {
        private Map map;
        private Field activeField;

        public GameForm(string sessionHandle, GameService.Map mappp)
        {
            InitializeComponent();
            map = new Map()
            {
                Height = 7,
                Width = 7,
                Fields = new List<Field>()
                {
                    new Field() { IsVisible = true, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Warrior, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true,MoneyMultiple = 0 },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true,MoneyMultiple = 0 },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, GummiesMultiple = 1.2m, GummyType = GummyType.Basic, JuiceMultiple = 0.2m, IsActive = true,IsPlayer = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Warrior, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Basic, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, IsPlayer = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesMultiple = 1.2m, GummyType = GummyType.Warrior, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Basic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Warrior, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Basic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = false, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Basic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Warrior, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = false, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Basic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Warrior, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = false, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Basic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = false, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Warrior, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = false, GummiesCount = 2, GummiesMultiple = 1.2m, GummyType = GummyType.Magic, JuiceMultiple = 0.2m, IsActive = true, MoneyMultiple = 0 },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false },
                    new Field() { IsVisible = true, IsActive = false }
                }
            };
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            EnableOperations();
            RefreshGame();
        }

        private void RefreshGame()
        {
            goldLabel.Text = $"Złoto: {21}";
            juiceLabel.Text = $"Sok z gumijagód: {112}%";
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            DrawMap();
        }

        private void DrawMap()
        {
            Graphics g = gamePanel.CreateGraphics();
            g.Clear(gamePanel.BackColor);
            float w = (float)Math.Floor(gamePanel.Width / (float)map.Width);
            float h = (float)Math.Floor(gamePanel.Height / (float)map.Height);

            int k = 0;
            for (int j = 0; j < map.Height; j++)
                for (int i = 0; i < map.Width; i++)
                {
                    var field = map.Fields[k];

                    Brush brush = new SolidBrush(!field.IsActive ? Color.Silver : (field.IsPlayer ? Color.LimeGreen : Color.Tomato));
                    Pen blackPen = new Pen(Color.Black);
                    Pen activePen = new Pen(Color.Gold);
                    Brush blackBrush = new SolidBrush(Color.Black);
                    Font smallFont = new Font("Arial", 7);
                    Font font = new Font("Arial", 12);

                    g.FillRectangle(brush, w * i + 1, h * j + 1, w - 2, h - 2);
                    //g.DrawRectangle(blackPen, w * i + 1, h * j + 1, w - 2, h - 2);
                    if (field == activeField) g.DrawRectangle(blackPen, w * i, h * j, w - 1, h - 1);
                    if (field.IsActive)
                    {
                        if (field.IsPlayer || field.IsVisible)
                        {
                            Image image = null;
                            switch (field.GummyType)
                            {
                                case GummyType.Basic:
                                    image = field.IsPlayer ? Resources.gummiBasic : Resources.trollBasic;
                                    break;
                                case GummyType.Magic:
                                    image = field.IsPlayer ? Resources.gummiMagic : Resources.trollMagic;
                                    break;
                                case GummyType.Warrior:
                                    image = field.IsPlayer ? Resources.gummiWarrior : Resources.trollWarrior;
                                    break;
                            }

                            if (field.GummiesCount > 0)
                            {
                                g.DrawImage(image, new RectangleF(w * i + 5, h * j + 20, w - 60, h - 40));
                                g.DrawString($"x{field.GummiesCount}", font, blackBrush, w * i + w - 55, h * j + 20);
                            }
                        }

                        g.DrawString($"Gumisie: {field.GummiesMultiple}", smallFont, blackBrush, w * i + w - 60, h * j + h - 48);
                        g.DrawString($"Sok: {field.JuiceMultiple}", smallFont, blackBrush, w * i + w - 60, h * j + h - 36);
                        g.DrawString($"Złoto: {field.MoneyMultiple}", smallFont, blackBrush, w * i + w - 60, h * j + h - 24);
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
            int x = e.X * map.Width / gamePanel.Width;
            int y = e.Y * map.Height / gamePanel.Height;
            int index = y * map.Width + x;
            if (map.Fields[index].IsActive && map.Fields[index].IsPlayer)
            {
                activeField = map.Fields[index];
                EnableOperations();
                DrawMap();
            }
        }

        private void EnableOperations()
        {
            if (activeField == null || activeField.GummiesCount == 0)
            {
                moveButton.Enabled = attackButton.Enabled = improveButton.Enabled = sacrificeButton.Enabled = false;
            }
            else
            {
                moveButton.Enabled = improveButton.Enabled = sacrificeButton.Enabled = true;
                attackButton.Enabled = activeField.GummyType == GummyType.Magic;
            }
        }
    }
}
