using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TwitchUi
{
    public partial class DownloadWindow : Form
    {
        static string NodePath = Path.GetFullPath(Path.Combine(Application.StartupPath, "support", "node.exe"));
        static string ScriptPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "support", "twitch-archive", "bootstrap.js"));

        static Regex BadNumberRegex = new Regex(@"[^\d]", RegexOptions.ECMAScript);

        public DownloadWindow()
        {
            InitializeComponent();

            DestinationTextBox.Text = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Stream Downloads");
        }





        void BrowseButtonHandler(object sender, EventArgs e)
        {
            DestinationTextBox.Text = RequestOuptutFolder(DestinationTextBox.Text);
        }

        void TextBoxKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                var box = sender as TextBox;
                if (box == null)
                    return;

                box.SelectAll();
                e.Handled = true;
            }
        }

        void StartDownloadsHandler(object sender, EventArgs e)
        {
            var channelNames = GetLines(ChannelNamesTextBox.Text);
            var broadcastIds = GetLines(BroadcastIdsTextBox.Text);

            // check that broadcast ids are all integers
            if (broadcastIds.Any(BadNumberRegex.IsMatch))
            {
                MessageBox.Show("Broadcast IDs are all numbers, but you've specified some IDs with words!", "Twitch Downloader", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Process.Start(NodePath, string.Format(
                    "\"{0}\" {1} {2} -i -d \"{3}\"",
                    ScriptPath,
                    string.Join(" ", broadcastIds.Select(x => string.Format("-b \"{0}\"", x))),
                    string.Join(" ", channelNames.Select(x => string.Format("-u \"{0}\"", x))),
                    Path.GetFullPath(DestinationTextBox.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, couldn't start the downloads.");
            }
            
            Environment.Exit(0);
        }





        string RequestOuptutFolder(string startingDirectory)
        {
            var dialog = new FolderBrowserDialog()
            {
                Description = "Where should we put your videos?",
                ShowNewFolderButton = true,
                SelectedPath = startingDirectory
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
                return dialog.SelectedPath;
            return startingDirectory;
        }

        static string[] GetLines(string str)
        {
            if (str == null)
                return new string[0];
            return str.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
