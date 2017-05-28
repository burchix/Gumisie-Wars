using GummyBearsGame.GameService;
using GummyBearsGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GummyBearsGame.Forms
{
    public partial class LoginForm : Form
    {
        private Image[] windowImages = { Resources.gummiMagic, Resources.trollMagic, Resources.gummiWarrior, Resources.trollWarrior };
        private int windowImageIndex;

        private ServiceClient _gameService;
        private List<Map> _maps;

        public LoginForm(ServiceClient gameService)
        {
            InitializeComponent();
            _gameService = gameService;
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            changeImageTimer.Start();
            _maps = _gameService.GetMaps().ToList();
            mapComboBox.DataSource = _maps.Select(m => m.Name).ToList();
            mapComboBox.SelectedIndex = -1;
        }

        private void changeImageTimer_Tick(object sender, System.EventArgs e)
        {
            windowImageIndex++;
            if (windowImageIndex >= windowImages.Length) windowImageIndex = 0;
            iconPictureBox.Image = windowImages[windowImageIndex];
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            string sessionHandle = _gameService.DoLogin(loginTextBox.Text, passwordTextBox.Text);
            if (!string.IsNullOrEmpty(sessionHandle) && mapComboBox.SelectedIndex >= 0)
            {
                Game game = _gameService.StartGame(sessionHandle, _maps[mapComboBox.SelectedIndex].Id);
                new GameForm(_gameService, sessionHandle, game).ShowDialog();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania");
            }
        }

        private void mapComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (mapComboBox.SelectedIndex >= 0)
            {
                var map = _maps[mapComboBox.SelectedIndex];
                Graphics g = mapPreviewPanel.CreateGraphics();
                g.Clear(mapPreviewPanel.BackColor);

                float w = (float)Math.Floor(mapPreviewPanel.Width / (float)map.Width);
                float h = (float)Math.Floor(mapPreviewPanel.Height / (float)map.Height);

                int k = 0;
                for (int j = 0; j < map.Height; j++)
                    for (int i = 0; i < map.Width; i++)
                    {
                        Brush brush = map.Fields[k].Owner == GameService.FieldOwner.AI ? Brushes.Tomato :
                                      map.Fields[k].Owner == GameService.FieldOwner.Player ? Brushes.LimeGreen :
                                      map.Fields[k].Owner == GameService.FieldOwner.NoOne ? Brushes.Silver : new SolidBrush(mapPreviewPanel.BackColor);
                        g.FillRectangle(brush, w * i + 1, h * j + 1, w - 2, h - 2);

                        k++;
                    }
            }
        }
    }
}
