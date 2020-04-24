using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ManualMapInjection.Injection;
using System.IO;
using System.Diagnostics;
using BluInjector.Properties;
using BluInjector;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

        [DllImport("kernel32.dll", SetLastError = true)] static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true)] static extern int CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", SetLastError = true)] static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);
        [DllImport("kernel32.dll", SetLastError = true)] static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("kernel32.dll", SetLastError = true)] static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);
        [DllImport("kernel32.dll", SetLastError = true)] static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", SetLastError = true)] static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress,IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        Color backgroundclr1, textclr1, bttnclr1;
        public Form1()
        { 
            InitializeComponent();
        }

        string dllpath = null;
        int tik = 0;
        bool closeOnInject, soundOnInject, delayInject;
        int injMethod = 0, delayTime = 0;

        public void Form1_Load(object sender, EventArgs e)
        {
            processName.Text = Settings.Default["Process"].ToString();
            dllName.Text = Settings.Default["DLLName"].ToString();
            dllpath = Settings.Default["DLLPath"].ToString();

            backgroundclr1 = (Color) Settings.Default["bkColor"];
            textclr1 = (Color) Settings.Default["txColor"];
            bttnclr1 = (Color) Settings.Default["btColor"];

            closeOnInject = (bool)Settings.Default["closeInj"];
            soundOnInject = (bool)Settings.Default["soundInj"];
            delayInject = (bool)Settings.Default["delayInj"];
            delayTime = (int)Settings.Default["delayTime"];

            if (bttnclr1.ToString() == "Color[empty]" || textclr1.ToString() == "Color[empty]" || bttnclr1.ToString() == "Color[empty]")
                ApplyColors1(sender, e, Color.SteelBlue, Color.Black, Color.White);
            else
                ApplyColors1(sender, e, backgroundclr1, textclr1, bttnclr1);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["Process"] = processName.Text;
            Settings.Default["DLLPath"] = dllpath;
            Settings.Default["DLLName"] = dllName.Text;
            Settings.Default.Save();

            var name = processName.Text;
            var target = Process.GetProcessesByName(name).FirstOrDefault();
            var path = dllpath;
            if (!File.Exists(path))
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("DLL Not Found");
                return;
            }
            var file = File.ReadAllBytes(path);
            if (CheckProcess(sender, e) == 2)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Invalid Process");
                return;
            }
            //delay inject
            if(delayInject)
            {
                Thread.Sleep(delayTime * 1000);
            }
            //injection
            if(injMethod == 0)
            {
                doInject(name, path);
            }
            else if (injMethod == 1)
            {
                var injector = new ManualMapInjector(target) { AsyncInjection = true };
                label2.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";
            }

            if(soundOnInject)
                System.Media.SystemSounds.Beep.Play();

            if (closeOnInject)
                this.Close();

            button1.Font = new Font(button1.Font, FontStyle.Bold);
            button1.Text = "Injected!";
            timer1.Enabled = true;
        }

        OpenFileDialog ofd = new OpenFileDialog();
        public void SearchBttn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "DLL|*.dll";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dllName.Text = ofd.SafeFileName;
                dllpath = ofd.FileName;
            }
        }

        public void SearchBttn2_Click(object sender, EventArgs e)
        {
            ProcessForm form3 = new ProcessForm();
            form3.DataSent += Form3_DataSent;
            form3.ShowDialog(this);
        }

        public void ProcessLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name of the process in which the DLL will be injected. Ex: csgo, hl2", "Info");
        }

        public void DllLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DLL in which will be injected into the process", "Info");
        }

        public void SettingsBttn_Click(object sender, EventArgs e)
        {
            SettingsForm form2 = new SettingsForm();
            form2.DataSent += Form2_DataSent;
            form2.ShowDialog(this);
        }

        public void Form2_DataSent(object sender, EventArgs e, Color clr1, Color clr2, Color clr3, bool close, bool sound, bool delay, int dtime, int method)
        {
            ApplyColors1(sender, e, clr1, clr2, clr3);
            closeOnInject = close;
            soundOnInject = sound;
            delayInject = delay;
            delayTime = dtime;
            injMethod = method;
        }

        public void Form3_DataSent(object sender, EventArgs e, String selectedProcess)
        {
            processName.Text = selectedProcess;
        }

        public int CheckProcess(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName(processName.Text);
            if (pname.Length > 0)
                return 1;//valid
            else
                return 2;//invalid
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            tik++;
            timerLabel.Text = tik.ToString();
            if (tik == 20)
            {
                button1.Font = new Font(button1.Font, FontStyle.Regular);
                button1.Text = "Inject";
                timer1.Enabled = false;
                tik = 0;
            }
        }

        public void ApplyColors1(object sender, EventArgs e, Color backgroundColor, Color textColor, Color bttnColor)
        {

            //backcolor | backgroundclr
            this.BackColor = Color.FromArgb(backgroundColor.R, backgroundColor.G, backgroundColor.B);

            //text | textclr
            dllLabel.ForeColor = textColor;
            processLabel.ForeColor = textColor;
            searchBttn.ForeColor = textColor;
            searchBttn2.ForeColor = textColor;
            button1.ForeColor = textColor;
            settingsBttn.ForeColor = textColor;

            //buttons | bttnclr
            searchBttn.BackColor = bttnColor;
            searchBttn2.BackColor = bttnColor;
            button1.BackColor = bttnColor;
            settingsBttn.BackColor = bttnColor;

            bk.Text = backgroundColor.ToString();
            tx.Text = textColor.ToString();
            bt.Text = bttnColor.ToString();

            Settings.Default["bkColor"] = Color.FromArgb(backgroundColor.R, backgroundColor.G, backgroundColor.B);
            Settings.Default["txColor"] = textColor;
            Settings.Default["btColor"] = bttnColor;
            Settings.Default.Save();
        }
        bool bInject(uint pToBeInjected, string sDllPath)
        {
            IntPtr hndProc = OpenProcess((0x2 | 0x8 | 0x10 | 0x20 | 0x400), 1, pToBeInjected);

            if (hndProc == INTPTR_ZERO)
            {
                return false;
            }

            IntPtr lpLLAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            if (lpLLAddress == INTPTR_ZERO)
            {
                return false;
            }

            IntPtr lpAddress = VirtualAllocEx(hndProc, (IntPtr)null, (IntPtr)sDllPath.Length, (0x1000 | 0x2000), 0X40);

            if (lpAddress == INTPTR_ZERO)
            {
                return false;
            }

            byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);

            if (WriteProcessMemory(hndProc, lpAddress, bytes, (uint)bytes.Length, 0) == 0)
            {
                return false;
            }

            if (CreateRemoteThread(hndProc, (IntPtr)null, INTPTR_ZERO, lpLLAddress, lpAddress, 0, (IntPtr)null) == INTPTR_ZERO)
            {
                return false;
            }

            CloseHandle(hndProc);

            return true;
        }
        public enum DllInjectionResult
        {
            DllNotFound,
            GameProcessNotFound,
            InjectionFailed,
            Success
        }
        public void doInject(string sProcName, string sDllPath)
        {
            uint _procId = 0;
            Process[] _procs = Process.GetProcesses();
            for (int i = 0; i < _procs.Length; i++)
            {
                if (_procs[i].ProcessName == sProcName)
                {
                    _procId = (uint)_procs[i].Id;
                    break;
                }
            }
        }
    }
}
