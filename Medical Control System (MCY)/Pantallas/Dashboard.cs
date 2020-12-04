using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Control_System__MCY_.Pantallas
{
    public partial class Dashboard : Form
    {
        //Dll para mover el formulario si no tiene bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        MySqlDataReader rdr = null;
        DataTable dt = new DataTable();

        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String cs = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");


        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Dashboard()
        {
            InitializeComponent();
            CargarCantidadCita();
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            //Codigo para poder mover el formulario sin bordes
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {

            OpenChildForm(new AgregarCitas());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
            Application.Exit();
            Opacity = 1;
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
            this.WindowState = FormWindowState.Minimized;
            Opacity = 1;
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCitas_MouseEnter(object sender, EventArgs e)
        {
            btnCitas.BackColor = System.Drawing.ColorTranslator.FromHtml("#0C3A2D"); // or Color.Red or whatever you want
        }

        private void btnCitas_MouseLeave(object sender, EventArgs e)
        {
            btnCitas.BackColor = System.Drawing.ColorTranslator.FromHtml("#24B089"); // or Color.Red or whatever you want
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Codigo para poder mover el formulario sin bordes
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            //Codigo para poder mover el formulario sin bordes
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            AgregarCitas agr = new AgregarCitas();
            agr.CargarDgvCitas();
            CargarCantidadCita();

        }

        public void CargarCantidadCita()
        {
            AgregarCitas agr = new AgregarCitas();
            btnCitasParaHoy.Text = agr.dgvcitas.RowCount.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblreloj.Text = (DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }
}
