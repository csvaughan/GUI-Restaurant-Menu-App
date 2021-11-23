using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SpicyMeatball_CS115Final
{
    public partial class FrmSplashScreen : Form
    {
       
        public FrmSplashScreen()
        {
            InitializeComponent();
            progressBar1.Value = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            progressBar1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Close();
            }

        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
