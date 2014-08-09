using System;
using System.Windows.Forms;

namespace TwitchUi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            SetupEnvironment();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DownloadWindow());
        }

        static void SetupEnvironment()
        {
            Application.ThreadException += (sender, args) => HandleException();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => HandleException();
        }

        static void HandleException()
        {
            MessageBox.Show("Woah! Twitch Downloader has crashed. Sorry :(");
            Environment.Exit(0);
        }
    }
}
