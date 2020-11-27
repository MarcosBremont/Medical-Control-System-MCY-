using Medical_Control_System__MCY_.Pantallas;
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

namespace Medical_Control_System__MCY_
{
    public partial class LoginPage : Form
    {
        //Dll para mover el formulario si no tiene bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            txtemailIniciarSesion.Visible = false;
            txtContraseñaIniciarSesion.Visible = false;
            BtnIniciarSesion2.Visible = false;
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            MostrarInicioSesion();
            OcultarRegistro();
        }
        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
            OcultarInicioSesion();
        }

        public void MostrarRegistro()
        {
            panelRegistro.Visible = true;
            txtusuario.Visible = true;
            txtapellido.Visible = true;
            txtcorreo.Visible = true;
            txtcontrasena.Visible = true;
            BtnRegistrarse.Visible = true;
        }

        public void OcultarRegistro()
        {
            panelRegistro.Visible = false;
            txtusuario.Visible = false;
            txtapellido.Visible = false;
            txtcorreo.Visible = false;
            txtcontrasena.Visible = false;
        }

        public void MostrarInicioSesion()
        {
            panelLogin.Visible = true;
            txtemailIniciarSesion.Visible = true;
            txtContraseñaIniciarSesion.Visible = true;
            BtnIniciarSesion2.Visible = true;
        }

        public void OcultarInicioSesion()
        {
            panelLogin.Visible = false;
            txtemailIniciarSesion.Visible = false;
            txtContraseñaIniciarSesion.Visible = false;
            BtnIniciarSesion2.Visible = false;
        }

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            //Codigo para poder mover el formulario sin bordes
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //Codigo para poder mover el formulario sin bordes
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            //Codigo para poder mover el formulario sin bordes
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIniciarSesion2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            OcultarRegistro();
            MostrarInicioSesion();
        }
    }
}
