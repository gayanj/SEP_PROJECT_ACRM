using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRMS.DISK
{
    public partial class DirSizeExplorer : Form
    {
        bool stop;

        public DirSizeExplorer()
        {
            InitializeComponent();
        }

        private void DirSizeExplorer_Load(object sender, EventArgs e)
        {
            this.getDrives();
            if (cBoxDriveList.Items.Count != 0)
            {
                cBoxDriveList.Text = cBoxDriveList.Items[0].ToString();
            }

        }

        private void getDrives()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady) //Check to see there is something in the drive
                {
                    cBoxDriveList.Items.Add(drive.RootDirectory);
                }
            }
        }
        private void scanFiles(string rootDirectory)
        {
            this.Text = "Scanning Files...";
            try
            {
                if (stop) return;
                foreach (string dir in Directory.GetDirectories(rootDirectory))
                {
                    if (stop) return;
                    Application.DoEvents();
                    if (dir.ToLower().IndexOf("$recycle.bin") == -1)
                        scanFiles(dir); //recursive call
                }

                foreach (string file in Directory.GetFiles(rootDirectory))
                {
                    if (stop) return;
                    Application.DoEvents();
                    addNode(file, null); //null because we might not have the first node yet
                }
            }
            catch (Exception)
            {
            }
        }
        //Recursive function to add a full path into a treeview
        private void addNode(string text, TreeNode parent)
        {
            if (text.EndsWith("\\")) text.TrimEnd(new char[] { '\\' });

            if (parent == null)
            {
                //Add/Find the first node
                if (text.IndexOf("\\") != -1)
                {
                    int parentIndex;
                    string nodeString;
                    if (text.IndexOf(":") != -1) //C:\ want to preserve the backslash
                    {
                        //Check to see if it exists first                        
                        nodeString = text.Substring(0, text.IndexOf("\\") + 1);
                        parentIndex = treeView.Nodes.IndexOfKey(nodeString);

                        //Node does not exist so create it
                        if (parentIndex == -1)
                        {
                            //Important to set the key to the text so it is easier to look up the node later
                            treeView.Nodes.Add(nodeString, nodeString);
                            parentIndex = treeView.Nodes.Count - 1;
                        }

                    }
                    else
                    {
                        nodeString = text.Substring(0, text.IndexOf("\\"));
                        parentIndex = treeView.Nodes.IndexOfKey(nodeString);

                        if (parentIndex == -1)
                        {
                            treeView.Nodes.Add(nodeString, nodeString);
                            parentIndex = treeView.Nodes.Count - 1;
                        }
                    }

                    parent = treeView.Nodes[parentIndex];
                    text = text.Substring(text.IndexOf("\\") + 1);
                }
                else
                {
                    //Simply add it if it does not exist
                    if (treeView.Nodes.IndexOfKey(text) == -1)
                        treeView.Nodes.Add(text, text);
                }
            }

            if (text.IndexOf("\\") != -1)
            {
                string nodeString = text.Substring(0, text.IndexOf("\\"));
                int parentIndex = parent.Nodes.IndexOfKey(nodeString);

                if (parentIndex == -1)
                {
                    parent.Nodes.Add(nodeString, nodeString);
                    parentIndex = parent.Nodes.Count - 1;
                }

                addNode(text.Substring(text.IndexOf("\\") + 1), parent.Nodes[parentIndex]);
            }
            else
            {
                //No children nodes necessary, just add it
                if (parent.Nodes.IndexOfKey(text) == -1)
                    parent.Nodes.Add(text, text);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cBoxDriveList.Text != string.Empty)
            {
                stop = false;

                btnStop.Enabled = true;
                btnStart.Enabled = false;

                scanFiles(cBoxDriveList.Text);
                this.Text = "Done";

                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView.PathSeparator = "\\";
            string fullPath = e.Node.FullPath;

            //Check for the double backlash and remove it
            if (fullPath.IndexOf(@"\\") != -1)
            {
                fullPath = fullPath.Substring(0, fullPath.IndexOf(@"\\")) + "\\" + fullPath.Substring(fullPath.IndexOf(@"\\") + 2);
            }

            System.Diagnostics.Process.Start(fullPath);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
        }

        private void DirSizeExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop = true;
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            if (cBoxDriveList.Text != string.Empty)
            {
                stop = false;

                btnStop.Enabled = true;
                btnStart.Enabled = false;

                scanFiles(cBoxDriveList.Text);
                this.Text = "Done";

                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
        }

        private void cBoxDriveList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
