using GummyBearsGame.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace GummyBearsGame.Forms
{
    public partial class LoginForm : Form
    {
        private Image[] windowImages = { Resources.gummiMagic, Resources.trollMagic, Resources.gummiWarrior, Resources.trollWarrior };
        private int windowImageIndex;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            changeImageTimer.Start();
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
