using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace GummyBearsMapEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = int.MaxValue;
            GameService.ServiceClient gameService = new GameService.ServiceClient(binding, new EndpointAddress("http://localhost:52291/Service.svc"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitForm(gameService));

            gameService.Close();
        }
    }
}
