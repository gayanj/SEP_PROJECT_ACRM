using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACRM.HDisk
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

            //logTxt.Focus();
            logTxt.Select(curLen, (logTxt.TextLength - curLen));
            logTxt.SelectionColor = Color.Orange;

            //logTxt.Focus();
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void fileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            int curLen = logTxt.TextLength;

            logTxt.AppendText(e.ChangeType + ": " + e.FullPath + "\r\n");

            //logTxt.Focus();
            logTxt.Select(curLen, (logTxt.TextLength - curLen));
            logTxt.SelectionColor = Color.Green;

           // logTxt.Focus();
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void fileSystemWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            int curLen = logTxt.TextLength;

            logTxt.AppendText(e.ChangeType + ": " + e.FullPath + "\r\n");

            //logTxt.Focus();
            logTxt.Select(curLen, (logTxt.TextLength - curLen));
            logTxt.SelectionColor = Color.Red;

            //logTxt.Focus();
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void fileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            //logTxt.Text += e.ChangeType + ":" + e.FullPath + "\r\n";
            int curLen = logTxt.TextLength;

            logTxt.AppendText(e.ChangeType + ": " + e.FullPath + "\r\n");

            //logTxt.Focus();
            logTxt.Select(curLen, (logTxt.TextLength - curLen));
            logTxt.SelectionColor = Color.Blue;

            //logTxt.Focus();
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fileSystemWatcher.Path = dirTxt.Text;
                fileSystemWatcher.Filter = fileTypeFilterTxt.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Fields Cannot Be Empty");
                return;
            }
            fileSystemWatcher.IncludeSubdirectories = subDirChkBox.Checked;
            fileSystemWatcher.EnableRaisingEvents = true;

            logTxt.AppendText("Watching " + dirTxt.Text + " for changes.....\r\n");
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            fileSystemWatcher.EnableRaisingEvents = false;
            //fileSystemWatcher.Dispose();

            logTxt.AppendText("Ending File System Watch.....\r\n");
            logTxt.Focus();
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void browseFolderBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            dirTxt.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
