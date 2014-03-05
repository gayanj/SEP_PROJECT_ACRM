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
        private delegate void pInfo();
        private ArrayList processList;
        private ArrayList processMonitor;
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
            pInfo pInfo = getProcessInfo;
            IAsyncResult res2 = pInfo.BeginInvoke(null, null);
        }

        private void getProcessList()
        {
            pl = new ProcessLocal();
            processList = pl.RunningProcesses();

            textBox1.SafeInvoke(d => d.Clear());
            label2.SafeInvoke(d => d.Visible = true);
            label1.SafeInvoke(d => d.Visible = true);
            label1.SafeInvoke(d => d.Text = processList.Count.ToString());

            comboBox1.SafeInvoke(d => d.DataSource = processList);

            for (int i = 0; i < processList.Count; i++)
            {
                string processName = processList[i].ToString();
                textBox1.SafeInvoke(d => d.AppendText("Process Name : " + processName + "\n"));
            }
        }

        private void getProcessInfo()
        {
            if (!label1.Text.Equals("ProccessNo"))
            {
                textBox2.SafeInvoke(d => d.Clear());
                string processSelected = comboBox1.SafeInvoke(d => d.SelectedItem.ToString());

                processMonitor = pl.ProcessMonitor(processSelected);

                for (int i = 0; i < processMonitor.Count; i++)
                {
                    string property = processMonitor[i].ToString();
                    textBox2.SafeInvoke(d => d.AppendText(property + "\n"));
                }
            }
            else
            {
                MessageBox.Show("Press Get Processess Button First");
            }
        }
    }
}
