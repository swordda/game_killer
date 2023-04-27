using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Services
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void Stop()
        {
            string x = DateTime.Now.ToShortTimeString().ToString();
            if (x.Length < 5)
            {
                x = "0" + x;
            }
            char[] a = x.ToCharArray();
            string c = a[0].ToString() + a[1].ToString() + a[3].ToString() + a[4].ToString();
            int num = Convert.ToInt32(c);
            if (num < 0600 && num > 0030)
            {
                Process[] pros = Process.GetProcesses();
                int i = 0;
                foreach (var item in pros)
                {

                    string str = pros[i].ToString();
                    if (str == "System.Diagnostics.Process (League of Legends)")
                    {
                        item.Kill();
                    }
                    else if (str== "System.Diagnostics.Process (Overwatch)")
                    {
                        item.Kill();
                    }
                    i++;

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
        }
    }
}
