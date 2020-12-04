using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Control_System__MCY_.Pantallas
{
    public partial class SplashScreen : Form
    {
        
        public SplashScreen()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.pictureBox2.BackColor = Color.Transparent;
            //pictureBox2.BackColor = Color.Transparent;

        }
        //Use timer class

        Timer tmr;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 3000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            //hide this form
            this.Hide();

        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.pictureBox2.BackColor = Color.Transparent;
            lblloading.Visible = true;
            await Task.Delay(300);
            lblloading.Visible = false;
            await Task.Delay(300);
            lblloading.Visible = true;
            await Task.Delay(300);
            lblloading.Visible = false;
            await Task.Delay(300);
            lblloading.Visible = true;
            await Task.Delay(300);
            lblloading.Visible = false;
            await Task.Delay(300);
            lblloading.Visible = true;
            await Task.Delay(300);
            lblloading.Visible = false;
            await Task.Delay(300);
            lblloading.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(5);
        }

      
    }
}
