using MySql.Data.MySqlClient;
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
    public partial class FrmDoctores : Form
    {
        MySqlDataReader rdr = null;
        DataTable dt = new DataTable();

        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String cs = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");

        public FrmDoctores()
        {
            InitializeComponent();
        }

        private void FrmDoctores_Load(object sender, EventArgs e)
        {
            CargarDgvCitas();
        }

        public void CargarDgvCitas()
        {
            S_Doctores();
        }

        public void S_Doctores()
        {
            con = new MySqlConnection(cs);
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("S_Doctores", con);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.Fill(tabla);
            dgvHistorial.DataSource = tabla;
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgvHistorial.CurrentRow.Cells[0].Value.ToString();
            txtnombredoctor.Text = dgvHistorial.CurrentRow.Cells[1].Value.ToString();
            txtdireccion.Text = dgvHistorial.CurrentRow.Cells[2].Value.ToString();
            txttelefono.Text = dgvHistorial.CurrentRow.Cells[3].Value.ToString();
            txtcelular.Text = dgvHistorial.CurrentRow.Cells[4].Value.ToString();
            cmbSexo.Text = dgvHistorial.CurrentRow.Cells[5].Value.ToString();
            txtfecha_nac.Text = dgvHistorial.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvHistorial.CurrentRow.Cells[7].Value.ToString();
            txtcategoria.Text = dgvHistorial.CurrentRow.Cells[8].Value.ToString();
           
        }

        private void btnAgregarDr_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs);
                con.Open();
                string query = "INSERT INTO t_doctores (nombre_Completo, Direccion, Telefono, Celular, sexo, fecha_nacimiento, Email, categoria) values (@nombre_Completo, @Direccion, @Telefono, @Celular, @sexo, @fecha_nacimiento, @Email, @categoria)";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@nombre_Completo", txtnombredoctor.Text);
                comando.Parameters.AddWithValue("@Direccion", txtdireccion.Text);
                comando.Parameters.AddWithValue("@Telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@Celular", txtcelular.Text);
                comando.Parameters.AddWithValue("@sexo", cmbSexo.Text);
                comando.Parameters.AddWithValue("@fecha_nacimiento", txtfecha_nac.Text);
                comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                comando.Parameters.AddWithValue("@categoria", txtcategoria.Text);
                comando.ExecuteNonQuery();
                CargarDgvCitas();
                con.Close();
                MessageBox.Show("Doctor(a) Agregado(a) exitosamente. ");

                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, verifique los datos nuevamente. ");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE t_doctores SET nombre_Completo = @nombre_Completo, Direccion = @Direccion, Telefono = @Telefono, Celular = @Celular, sexo = @sexo, fecha_nacimiento = @fecha_nacimiento, Email = @Email, categoria = @categoria where idt_doctores=@idt_doctores";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@idt_doctores", lblid.Text);
            comando.Parameters.AddWithValue("@nombre_Completo", txtnombredoctor.Text);
            comando.Parameters.AddWithValue("@Direccion", txtdireccion.Text);
            comando.Parameters.AddWithValue("@Telefono", txttelefono.Text);
            comando.Parameters.AddWithValue("@Celular", txtcelular.Text);
            comando.Parameters.AddWithValue("@sexo", cmbSexo.Text);
            comando.Parameters.AddWithValue("@fecha_nacimiento", txtfecha_nac.Text);
            comando.Parameters.AddWithValue("@Email", txtEmail.Text);
            comando.Parameters.AddWithValue("@categoria", txtcategoria.Text);
            comando.ExecuteNonQuery();
            CargarDgvCitas();
            MessageBox.Show("Doctor(a) Actualizado exitosamente. ");
            con.Close();
            clear();
        }

        public void clear()
        {
            lblid.Text = "";
            txtnombredoctor.Text = "";
            txtdireccion.Text = "";
            txtcelular.Text = "";
            cmbSexo.Text = "";
            txttelefono.Text = "";
            txtfecha_nac.Text = "";
            txtEmail.Text = "";
            cmbSexo.Text = "";
            txtcategoria.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este Doctor?.", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM t_doctores Where idt_doctores = @idt_doctores";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@idt_doctores", lblid.Text);
                comando.ExecuteNonQuery();
                CargarDgvCitas();
                MessageBox.Show("Doctor Eliminado exitosamente. ");
                con.Close();
                clear();
            }
            else
            {

            }
        }
    }
}
