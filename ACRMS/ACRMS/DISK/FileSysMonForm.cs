using System;
using System.Drawing;
using System.Windows.Forms;

namespace ACRMS.DISK
{
    public partial class FileSysMonForm : Form
    {
        public FileSysMonForm()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            int curLen = logTxt.TextLength;
            logTxt.AppendText(e.ChangeType + ": " + e.FullPath + "\r\n");
            logTxt.Select(curLen, (logTxt.TextLength - curLen));
            logTxt.SelectionColor = Color.Orange;
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void fileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            int curLen = logTxt.TextLength;
            logTxt.AppendText(e.ChangeType + ": " + e.FullPath + "\r\n");
            logTxt.Select(curLen, (logTxt.TextLength - curLen));
            logTxt.SelectionColor = Color.Green;
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void fileSystemWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            int curLen = logTxt.TextLength;
            logTxt.AppendText(e.ChangeType + ": " + e.FullPath + "\r\n");
            logTxt.Select(curLen, (logTxt.TextLength - curLen));
            logTxt.SelectionColor = Color.Red;
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void fileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            int curLen = logTxt.TextLength;
            logTxt.AppendText(e.ChangeType + ": " + e.FullPath + "\r\n");
            logTxt.Select(curLen, (logTxt.TextLength - curLen));
            logTxt.SelectionColor = Color.Blue;
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            dirTxt.Text = folderBrowserDialog.SelectedPath;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fileSystemWatcher.Path = dirTxt.Text;
                fileSystemWatcher.Filter = fileTypeFilterTxt.Text;
                fileSystemWatcher.IncludeSubdirectories = subDirChkBox.Checked;
                fileSystemWatcher.EnableRaisingEvents = true;

                logTxt.AppendText("Watching " + dirTxt.Text + " for changes.....\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Directory, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            fileSystemWatcher.EnableRaisingEvents = false;
            // fileSystemWatcher.Dispose();

            logTxt.AppendText("Ending File System Watch.....\r\n");
            logTxt.Focus();
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }
    }
}
