﻿using GummyBearsGame.Properties;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GummyBearsGame.Forms
{
    public partial class LoginForm : Form
    {
        private Image[] windowImages = { Resources.gummiMagic, Resources.trollMagic, Resources.gummiWarrior, Resources.trollWarrior };
        private int windowImageIndex;

        private GameService.ServiceClient _gameService;
        private GameService.Map[] _maps;

        public LoginForm(GameService.ServiceClient gameService)
        {
            InitializeComponent();
            _gameService = gameService;
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            changeImageTimer.Start();
            _maps = _gameService.GetMaps();
            mapComboBox.DataSource = _maps.Select(m => m.Name);
        }

        private void changeImageTimer_Tick(object sender, System.EventArgs e)
        {
            windowImageIndex++;
            if (windowImageIndex >= windowImages.Length) windowImageIndex = 0;
            iconPictureBox.Image = windowImages[windowImageIndex];
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            new GameForm().ShowDialog();
        }
    }
}
