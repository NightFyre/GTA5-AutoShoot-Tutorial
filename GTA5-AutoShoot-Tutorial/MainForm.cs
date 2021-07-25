using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Runtime.InteropServices;
using System.Threading;

namespace GTA5_AutoShoot_SOURCE
{
    public partial class MainForm : Form
    {
        // Initialize Components
        Mem m = new Mem();
        private const string PROCESSNAME = "GTA5.exe";
        bool gta5Running;

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int a, int b, int c, int d, int ifyouenjoythisvideoconsidersubscribing);

        int leftDown = 0x02;
        int leftUp = 0x04;
        int flag = 0;

        //AutoShoot Method
        void Shoot(int delay)
        {
            mouse_event(leftDown, 0, 0, 0, 0);
            Thread.Sleep(1);
            mouse_event(leftUp, 0, 0, 0, 0);
            Thread.Sleep(delay);
        }

        void Triggerbot()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.RButton) < 0)
                {
                    flag = m.ReadInt("GTA5.exe+1FB2380");
                    if (flag >= 1 && AutoShoot_CheckBox.Checked)
                    {
                        Shoot(10);
                        Shoot(1);
                    }
                }
                Thread.Sleep(1);
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName(PROCESSNAME);
            if (PID > 0)
            {
                m.OpenProcess(PID);
                Thread TB = new Thread(Triggerbot) { IsBackground = true };
                TB.Start();
            }
            Author_Label.ForeColor = Color.FromArgb(169, 0, 0);
            Author_Label.BackColor = Color.FromArgb(32, 32, 35);
            Author_Label.Text = "Made by NightFyreTV";
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName(PROCESSNAME);
            if (PID > 0)
            {
                m.OpenProcess(PID);

                //Proc Label Status
                ProcStatus_Label.ForeColor = Color.FromArgb(0, 169, 0);
                ProcStatus_Label.BackColor = Color.FromArgb(32, 32, 35);
                ProcStatus_Label.Text = "GTAV CONNECTED";

                // This nifty bool is pretty helpful :)
                gta5Running = true;
                return;
            }
            ProcStatus_Label.Text = "GTAV NOT DETECTED";
            ProcStatus_Label.ForeColor = Color.FromArgb(169, 0, 0);
            ProcStatus_Label.BackColor = Color.FromArgb(32, 32, 35);
            gta5Running = false;
        }
    }
}
