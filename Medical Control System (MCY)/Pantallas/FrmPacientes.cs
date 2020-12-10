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
    public partial class FrmPacientes : Form
    {
        MySqlDataReader rdr = null;
        DataTable dt = new DataTable();

        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String cs = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            CargarDgvPacientes();
        }

        public void CargarDgvPacientes()
        {
            S_HistorialPaciente();
        }

        public void S_HistorialPaciente()
        {
            con = new MySqlConnection(cs);
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("S_Paciente", con);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.Fill(tabla);
            dgvPacientes.DataSource = tabla;
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
            txtnombrepaciente.Text = dgvPacientes.CurrentRow.Cells[1].Value.ToString();
            txtfechanac.Text = dgvPacientes.CurrentRow.Cells[2].Value.ToString();
            txtedad.Text = dgvPacientes.CurrentRow.Cells[3].Value.ToString();
            cmbSexo.Text = dgvPacientes.CurrentRow.Cells[4].Value.ToString();
            txttelefono.Text = dgvPacientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = dgvPacientes.CurrentRow.Cells[6].Value.ToString();
            txtdireccion.Text = dgvPacientes.CurrentRow.Cells[7].Value.ToString();
            txtalergias.Text = dgvPacientes.CurrentRow.Cells[8].Value.ToString();
            txtotrosproblemas.Text = dgvPacientes.CurrentRow.Cells[9].Value.ToString();
            txtEmail.Text = dgvPacientes.CurrentRow.Cells[10].Value.ToString();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE t_paciente SET nombre_Completo = @nombre_Completo, fecha_nac = @fecha_nac, edad = @edad, sexo = @sexo, telefono = @telefono, celular = @celular, direccion = @direccion, alergias = @alergias, otros_problemas = @otros_problemas, email = @email where idt_paciente=@idt_paciente";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@idt_paciente", lblid.Text);
            comando.Parameters.AddWithValue("@nombre_Completo", txtnombrepaciente.Text);
            comando.Parameters.AddWithValue("@fecha_nac", txtfechanac.Text);
            comando.Parameters.AddWithValue("@edad", txtedad.Text);
            comando.Parameters.AddWithValue("@sexo", cmbSexo.Text);
            comando.Parameters.AddWithValue("@telefono", txttelefono.Text);
            comando.Parameters.AddWithValue("@celular", txtcelular.Text);
            comando.Parameters.AddWithValue("@direccion", txtdireccion.Text);
            comando.Parameters.AddWithValue("@alergias", txtalergias.Text);
            comando.Parameters.AddWithValue("@otros_problemas", txtotrosproblemas.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);
            comando.ExecuteNonQuery();
            CargarDgvPacientes();
            MessageBox.Show("Paciente Actualizado Exitosamente. ");
            con.Close();
            clear();
        }

        public void clear()
        {
            lblid.Text = "";
            txtnombrepaciente.Text = "";
            txtfechanac.Text = "";
            txtedad.Text = "";
            cmbSexo.Text = "";
            txttelefono.Text = "";
            txtcelular.Text = "";
            txtdireccion.Text = "";
            txtalergias.Text = "";
            txtotrosproblemas.Text = "";
            txtEmail.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este Paciente?.", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM t_paciente Where idt_paciente = @idt_paciente";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@idt_paciente", lblid.Text);
                comando.ExecuteNonQuery();
                CargarDgvPacientes();
                MessageBox.Show("Paciente Eliminado Exitosamente. ");
                con.Close();
                clear();
            }
            else
            {
                MessageBox.Show("No Se Pudo Eliminar El Paciente Seleccionado. ");
            }
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs);
                con.Open();
                string query = "INSERT INTO t_paciente (nombre_Completo, fecha_nac, edad, sexo, telefono, celular, direccion, alergias, otros_problemas, email) values (@nombre_Completo, @fecha_nac, @edad, @sexo, @telefono, @celular, @direccion, @alergias, @otros_problemas, @email)";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@nombre_Completo", txtnombrepaciente.Text);
                comando.Parameters.AddWithValue("@fecha_nac", txtfechanac.Text);
                comando.Parameters.AddWithValue("@edad", txtedad.Text);
                comando.Parameters.AddWithValue("@sexo", cmbSexo.Text);
                comando.Parameters.AddWithValue("@telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@celular", txtcelular.Text);
                comando.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                comando.Parameters.AddWithValue("@alergias", txtalergias.Text);
                comando.Parameters.AddWithValue("@otros_problemas", txtotrosproblemas.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                
                comando.ExecuteNonQuery();
                CargarDgvPacientes();
                con.Close();
                MessageBox.Show("Paciente Agregado exitosamente. ");

                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, verifique los datos nuevamente. ");
            }
        }
    }
}
