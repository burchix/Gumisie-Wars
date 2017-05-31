using GummyBearsMapEditor.GameService;
using GummyBearsMapEditor.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GummyBearsMapEditor
{
    public partial class CreateForm : Form
    {
        private ServiceClient _gameService;

        private Map _map;
        private Field _activeField = null;
        private int _activeIndex = -1;

        public CreateForm(ServiceClient gameService, Map map)
        {
            InitializeComponent();
            _gameService = gameService;
            _map = map;
        }

        private void CreateForm_Load(object sender, System.EventArgs e)
        {
            ownerComboBox.DataSource = Enum.GetValues(typeof(FieldOwner));
            ownerComboBox.SelectedIndex = 0;

            gummyTypeComboBox.DataSource = Enum.GetValues(typeof(GummyType));
            gummyTypeComboBox.SelectedIndex = 0;
        }

        private void CreateForm_Paint(object sender, PaintEventArgs e)
        {
            DrawMap();
        }

        private void DrawMap()
        {
            Graphics g = gamePanel.CreateGraphics();
            g.Clear(gamePanel.BackColor);
            float w = (float)Math.Floor(gamePanel.Width / (float)_map.Width);
            float h = (float)Math.Floor(gamePanel.Height / (float)_map.Height);

            int k = 0;
            for (int j = 0; j < _map.Height; j++)
                for (int i = 0; i < _map.Width; i++)
                {
                    var field = _map.Fields[k];

                    Brush brush = new SolidBrush(field.Owner == FieldOwner.NoOne ? Color.Silver : (field.Owner == FieldOwner.Blocked ? Color.Gray : (field.Owner == FieldOwner.Player ? Color.LimeGreen : Color.Tomato)));
                    Pen blackPen = new Pen(Color.Black);
                    Pen activePen = new Pen(Color.Gold);
                    Brush blackBrush = new SolidBrush(Color.Black);
                    Font smallFont = new Font("Arial", 7);
                    Font font = new Font("Arial", 12);

                    g.FillRectangle(brush, w * i + 1, h * j + 1, w - 2, h - 2);
                    //g.DrawRectangle(blackPen, w * i + 1, h * j + 1, w - 2, h - 2);
                    if (field == _activeField) g.DrawRectangle(blackPen, w * i, h * j, w - 1, h - 1);

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
                                g.DrawString($"x{field.GummiesNumber:#0}", font, blackBrush, w * i + w - 70, h * j + 20);
                            }
                        }

                        g.DrawString($"Gumisie: {field.GummiesMultiplier:#0}", smallFont, blackBrush, w * i + w - 70, h * j + h - 48);
                        g.DrawString($"Sok: {field.JuiceMultiplier:#0.00}", smallFont, blackBrush, w * i + w - 70, h * j + h - 36);
                        g.DrawString($"Złoto: {field.GoldMultiplier:#0.00}", smallFont, blackBrush, w * i + w - 70, h * j + h - 24);
                        g.DrawString($"Obrona: x{field.DefenceMultiplier:#0.00}", smallFont, blackBrush, w * i + w - 70, h * j + h - 12);
                    }

                    k++;
                }
        }

        private void CreateForm_Resize(object sender, EventArgs e)
        {
            DrawMap();
        }
        
        private void gamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X * _map.Width / gamePanel.Width;
            int y = e.Y * _map.Height / gamePanel.Height;
            int index = y * _map.Width + x;
            _activeField = _map.Fields[index];
            _activeIndex = index;
            UpdateData();
            DrawMap();
        }

        private void UpdateData()
        {
            ownerComboBox.SelectedIndex = (int)_map.Fields[_activeIndex].Owner;
            if (_map.Fields[_activeIndex].Owner != FieldOwner.Blocked)
            {
                goldUpDown.Value = _map.Fields[_activeIndex].GoldMultiplier;
                defenceUpDown.Value = _map.Fields[_activeIndex].DefenceMultiplier;
                juiceUpDown.Value = _map.Fields[_activeIndex].JuiceMultiplier;
                gummyMultUpDown.Value = _map.Fields[_activeIndex].GummiesMultiplier;
                gummyNrUpDown.Value = _map.Fields[_activeIndex].GummiesNumber;

                if (_map.Fields[_activeIndex].GummiesNumber == 0)
                    gummyTypeComboBox.SelectedIndex = 0;
                else
                    gummyTypeComboBox.SelectedIndex = (int)_map.Fields[_activeIndex].GummiesType;
            }
        }

        private void ownerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownerComboBox.SelectedIndex == (int)FieldOwner.Blocked)
            {
                defenceUpDown.Enabled = false;
                goldUpDown.Enabled = false;
                juiceUpDown.Enabled = false;
                gummyMultUpDown.Enabled = false;
                gummyNrUpDown.Enabled = false;
                gummyTypeComboBox.Enabled = false;
            }
            else if(ownerComboBox.SelectedIndex == (int)FieldOwner.NoOne)
            {
                defenceUpDown.Enabled = true;
                goldUpDown.Enabled = true;
                juiceUpDown.Enabled = true;
                gummyMultUpDown.Enabled = true;
                gummyNrUpDown.Enabled = false;
                gummyTypeComboBox.Enabled = false;
            }
            else
            {
                defenceUpDown.Enabled = true;
                goldUpDown.Enabled = true;
                juiceUpDown.Enabled = true;
                gummyMultUpDown.Enabled = true;
                gummyNrUpDown.Enabled = true;
                gummyNrUpDown_ValueChanged(sender, e);
            }

            if (_activeIndex >= 0)
            {
                _map.Fields[_activeIndex].Owner = (FieldOwner)ownerComboBox.SelectedIndex;
            }
            DrawMap();
        }

        private void defenceUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_activeIndex >= 0)
            {
                _map.Fields[_activeIndex].DefenceMultiplier = defenceUpDown.Value;
            }
            DrawMap();
        }

        private void goldUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_activeIndex >= 0)
            {
                _map.Fields[_activeIndex].GoldMultiplier = goldUpDown.Value;
            }
            DrawMap();
        }

        private void juiceUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_activeIndex >= 0)
            {
                _map.Fields[_activeIndex].JuiceMultiplier = juiceUpDown.Value;
            }
            DrawMap();
        }

        private void gummyMultUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_activeIndex >= 0)
            {
                _map.Fields[_activeIndex].GummiesMultiplier = (int)gummyMultUpDown.Value;
            }
            DrawMap();
        }

        private void gummyNrUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (gummyNrUpDown.Value > 0) gummyTypeComboBox.Enabled = true;
            else gummyTypeComboBox.Enabled = false;

            if(_activeIndex >= 0)
            {
                _map.Fields[_activeIndex].GummiesNumber = (int)gummyNrUpDown.Value;
                if (_map.Fields[_activeIndex].GummiesNumber == 0)
                    _map.Fields[_activeIndex].GummiesType = GummyType.Basic;
            }
            DrawMap();
        }

        private void gummyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_activeIndex >= 0)
            {
                _map.Fields[_activeIndex].GummiesType = (GummyType)gummyTypeComboBox.SelectedIndex;
            }
            DrawMap();
        }

        private void createMapButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Czy zapisać mapę o nazwie:{_map.Name}?", "Done?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var saved = _gameService.SaveMap(_map);
                MessageBox.Show($"Zapisano mapę o nazwie: {saved.Name}{Environment.NewLine} Data utworzenia: {saved.CreateDate}");
                Close();
            }
        }
    }
}
