using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using BluInjector.Properties;

namespace BluInjector
{
    public delegate void DataSentHandler3(object sender, EventArgs e, String selectedProcess);
    public partial class ProcessForm : Form
    {
        Color backgroundclr = (Color)Settings.Default["bkColor"];
        Color textclr = (Color)Settings.Default["txColor"];
        Color bttnclr = (Color)Settings.Default["btColor"];

        String selectedProcess = "";
        int listType = 2;

        public event DataSentHandler3 DataSent;
        public ProcessForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (backgroundclr.ToString() == "Color[empty]" || textclr.ToString() == "Color[empty]" || bttnclr.ToString() == "Color[empty]")
            {
                backgroundclr = Color.SteelBlue;
                textclr = Color.Black;
                bttnclr = Color.White;
                Apply3(sender, e);
            }
            else
                Apply3(sender, e);

            loadProcessList(listType);
        }
        private void Apply3(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(backgroundclr.R, backgroundclr.G, backgroundclr.B);

            processBttn.BackColor = bttnclr;
            windowBttn.BackColor = bttnclr;
            selectBttn.BackColor = bttnclr;

            processBttn.ForeColor = textclr;
            windowBttn.ForeColor = textclr;
            selectBttn.ForeColor = textclr;
        }
        private void loadProcessList(int viewType)
        {
            listView.Items.Clear();
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                ListViewItem item = new ListViewItem();
                if(viewType == 1)
                    if(process.ProcessName != "conhost" && process.ProcessName != "svchost" && process.ProcessName != "RuntimeBroker")
                        listView.Items.Add(process.ProcessName);
                if (viewType == 2)
                    if (!String.IsNullOrEmpty(process.MainWindowTitle))
                        listView.Items.Add(process.ProcessName);
            }
        }

        private void ProcessBttn_Click(object sender, EventArgs e)
        {
            listType = 1;
            loadProcessList(listType);
        }

        private void WindowBttn_Click(object sender, EventArgs e)
        {
            listType = 2;
            loadProcessList(listType);
        }

        private void SelectBttn_Click(object sender, EventArgs e)
        {
            this.DataSent(sender, e, selectedProcess);
            this.Close();
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProcess = listView.GetItemText(listView.SelectedItem);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            int selected = listView.SelectedIndex;
            loadProcessList(listType);
            listView.SelectedIndex = selected;
        }
    }
}
