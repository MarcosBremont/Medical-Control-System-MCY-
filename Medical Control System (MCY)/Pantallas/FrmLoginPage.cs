using Medical_Control_System__MCY_.Pantallas;
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

namespace Medical_Control_System__MCY_
{
    public partial class LoginPage : Form
    {
        //Dll para mover el formulario si no tiene bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Bases de datos
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataReader dr;

        String cs = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelloginarriba.Visible = true;
            panelregistroarriba.Visible = false;
            txtemailIniciarSesion.Visible = true;
            txtContraseñaIniciarSesion.Visible = true;
            BtnIniciarSesion2.Visible = true;
            panelRegistro.Visible = false;
            txtContraseñaIniciarSesion.PasswordChar = '●';


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
            panelregistroarriba.Visible = true;
            panelloginarriba.Visible = false;
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
            panelloginarriba.Visible = true;
            panelregistroarriba.Visible = false;
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
            Ingresar();
           
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(cs);
            con.Open();
            string query = "INSERT INTO t_usuario (nombreusuario, apellidousuario, emailusuario, contrasenausuario) values (@nombreusuario, @apellidousuario, @emailusuario, @contrasenausuario)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@nombreusuario", txtusuario.Text);
            comando.Parameters.AddWithValue("@apellidousuario", txtapellido.Text);
            comando.Parameters.AddWithValue("@emailusuario", txtcorreo.Text);
            comando.Parameters.AddWithValue("@contrasenausuario", txtcontrasena.Text);
            comando.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Usuario Agregado exitosamente");
            OcultarRegistro();
            MostrarInicioSesion();
        }

        public void Ingresar()
        {
            if (txtemailIniciarSesion.Text == "")
            {
                MessageBox.Show("Por favor introduzca su Email. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemailIniciarSesion.Focus();
                return;
            }
            if (txtcontrasena.Text == "")
            {
                MessageBox.Show("Por favor introduzca su contraseña. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseñaIniciarSesion.Focus();
                return;
            }


            try
            {
                MySqlConnection myConnection = default(MySqlConnection);
                myConnection = new MySqlConnection(cs);

                MySqlCommand myCommand = default(MySqlCommand);

                myCommand = new MySqlCommand("SELECT emailusuario,contrasenausuario FROM t_usuario WHERE emailusuario = @emailusuario AND contrasenausuario = @contrasenausuario", myConnection);
                MySqlParameter uName = new MySqlParameter("@emailusuario", MySqlDbType.VarChar);
                MySqlParameter uPassword = new MySqlParameter("@contrasenausuario", MySqlDbType.VarChar);

                uName.Value = txtemailIniciarSesion.Text;
                uPassword.Value = txtContraseñaIniciarSesion.Text;
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);
                myCommand.Connection.Open();
                MySqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    int i;

                    this.Hide();
                    FrmDashboard dashboard = new FrmDashboard();
                    dashboard.Show();
                    dashboard.lbluser.Text = txtemailIniciarSesion.Text;
                }
                else
                {

                    MessageBox.Show("¡El inicio de sesión falló, por favor verifique los datos correctamente!", "Inicio de sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtemailIniciarSesion.Clear();
                    txtContraseñaIniciarSesion.Clear();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void txtemailIniciarSesion_Enter(object sender, EventArgs e)
        {
            if (txtemailIniciarSesion.Text == "Email")
            {
                txtemailIniciarSesion.Text = "";
                txtemailIniciarSesion.ForeColor = Color.White;
            }
        }

        private void txtemailIniciarSesion_Leave(object sender, EventArgs e)
        {
            if (txtemailIniciarSesion.Text == "")
            {
                txtemailIniciarSesion.Text = "Email";
                txtemailIniciarSesion.ForeColor = Color.White;
            }
        }

        private void txtContraseñaIniciarSesion_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaIniciarSesion.Text == "")
            {
                txtContraseñaIniciarSesion.Text = "Contraseña";
                txtContraseñaIniciarSesion.ForeColor = Color.White;
            }
        }

        private void txtContraseñaIniciarSesion_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaIniciarSesion.Text == "Contraseña")
            {
                txtContraseñaIniciarSesion.Text = "";
                txtContraseñaIniciarSesion.ForeColor = Color.White;
            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Nombre")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.White;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Nombre";
                txtusuario.ForeColor = Color.White;
            }
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if (txtapellido.Text == "Apellido")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.White;
            }
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "Apellido";
                txtapellido.ForeColor = Color.White;
            }
        }

        private void txtcontrasena_Enter(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "Contraseña")
            {
                txtcontrasena.Text = "";
                txtcontrasena.ForeColor = Color.White;
            }
        }

        private void txtcontrasena_Leave(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "")
            {
                txtcontrasena.Text = "Contraseña";
                txtcontrasena.ForeColor = Color.White;
            }
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "Email")
            {
                txtcorreo.Text = "";
                txtcorreo.ForeColor = Color.White;
            }
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "")
            {
                txtcorreo.Text = "Email";
                txtcorreo.ForeColor = Color.White;
            }
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContraseñaIniciarSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Ingresar();
            }
        }
    }
}
