using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using ACRM.CPU;
using System.Collections;

namespace ACRM
{
    public partial class Form1 : Form
    {
        private delegate void pList();
        private delegate void pInfo(string processName);
        private ArrayList processList;
        private ArrayList processInfo;
        private ProcessLocal pl;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pList plist = getProcessList;
            IAsyncResult res1 = plist.BeginInvoke(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string processSelected = comboBox1.SelectedItem.ToString();
            pInfo pInfo = getProcessInfo;
            IAsyncResult res2 = pInfo.BeginInvoke(processSelected,null, null);
        }

        private void getProcessList()
        {
            pl = new ProcessLocal();
            processList = pl.RunningProcesses();

            //label1.Visible = true;
            label1.Text = processList.Count.ToString();

            comboBox1.DataSource = processList;
            for (int i = 0; i < processList.Count; i++)
            {
                string processName = processList[i].ToString();
                textBox1.AppendText("Process Name : " + processName);
            }
        }

        private void getProcessInfo(string processName)
        {
            processInfo = pl.ProcessProperties(processName);

            for (int i = 0; i < processList.Count; i++)
            {
                textBox2.AppendText(processInfo[i] + "\n");
            }
        }
    }
}
