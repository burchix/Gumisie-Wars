using GummyBearsGame.Forms;
using System;
using System.Windows.Forms;

namespace GummyBearsGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GameService.ServiceClient gameService = new GameService.ServiceClient();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(gameService));

            gameService.Close();
        }
    }
}
