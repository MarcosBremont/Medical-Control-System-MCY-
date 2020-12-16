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
    public partial class FrmDashboard : Form
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
        public FrmDashboard()
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

            OpenChildForm(new FrmAgregarCitas());

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
            FrmAgregarCitas agr = new FrmAgregarCitas();
            agr.CargarDgvCitas();
            CargarCantidadCita();
            SelectCitasCompletadas();
            SelectCitasPendientes();
        }

       
        public void SelectCitasCompletadas()
        {
            con = new MySqlConnection(cs);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM t_citapaciente where estado = 'Completada' ", con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = comando;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            lblcitascompletadas.Text = tabla.Rows.Count.ToString();
        }

        public void SelectCitasPendientes()
        {
            con = new MySqlConnection(cs);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM t_citapaciente where estado = 'Pendiente' ", con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = comando;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            lblcitaspendientes.Text = tabla.Rows.Count.ToString();
        }



        public void CargarCantidadCita()
        {
            FrmAgregarCitas agr = new FrmAgregarCitas();
            agr.CargarDgvCitas();
            lblcitasparahoy.Text = agr.dgvcitas.RowCount.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblreloj.Text = (DateTime.Now.ToString("hh:mm:ss tt"));
            lblfecha.Text = DateTime.Now.ToString("dddd d MMMM yyyy");

        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pbFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/people/Marcos-Bremont/100014045828077");
        }

        private void pbGmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox?compose=CllgCJvnrLGFNgVcgGkzMHPXZZZFZJrBPPmNdkrlnFvbQsdgqXqdPDkFXPpcxDqBgCZZnpgQSjB");
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLoginPage Log = new FrmLoginPage();
            Log.Show();
           
        }

        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmVerPagos());
        }

        private void btnDeserts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHistorialCitasCompletas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();

        }

        private void pbAjustes_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frmConfiguracion = new FrmConfiguracion();
            frmConfiguracion.Show();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDoctores());
        }

      

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHistorialPacientes());
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPacientes());
        }
    }
}
