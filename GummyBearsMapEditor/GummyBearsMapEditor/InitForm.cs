using GummyBearsMapEditor.GameService;
using GummyBearsMapEditor.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GummyBearsMapEditor
{
    public partial class InitForm : Form
    {
        private ServiceClient _gameService;

        private Image[] windowImages = { Resources.gummiMagic, Resources.trollMagic, Resources.gummiWarrior, Resources.trollWarrior };
        private int windowImageIndex;

        public InitForm(ServiceClient gameService)
        {
            InitializeComponent();
            _gameService = gameService;
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            changeImageTimer.Start();
        }

        private void changeImageTimer_Tick(object sender, EventArgs e)
        {
            windowImageIndex++;
            if (windowImageIndex >= windowImages.Length) windowImageIndex = 0;
            iconPictureBox.Image = windowImages[windowImageIndex];
        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {
            int width = (int)widthUpDown.Value,
                height = (int)heightUpDown.Value,
                money = (int)moneyUpDown.Value,
                moneyAI = (int)moneyAIUpDown.Value;
            decimal juice = juiceUpDown.Value,
                juiceAI = juiceAIUpDown.Value;

            if(!string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                var map = new Map()
                {
                    Name = nameTextBox.Text,
                    Width = width,
                    Height = height,
                    Fields = Enumerable.Range(1, width * height).Select(f => new Field() {
                        Owner = FieldOwner.NoOne,
                        DefenceMultiplier = 1,
                        GoldMultiplier = 1,
                        JuiceMultiplier = 1,
                        GummiesMultiplier = 1,
                        GummiesNumber = 0,
                        GummiesType = GummyType.Basic
                    }).ToArray(),
                    Money = money,
                    MoneyAI = moneyAI,
                    Juice = juice,
                    JuiceAI = juiceAI
                };
                new CreateForm(_gameService, map).ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane");
            }
            
        }
    }
}
