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
    public partial class FrmHistorialPacientes : Form
    {

        MySqlDataReader rdr = null;
        DataTable dt = new DataTable();

        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String cs = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");
        public FrmHistorialPacientes()
        {
            InitializeComponent();
        }

        private void FrmHistorialPacientes_Load(object sender, EventArgs e)
        {
            CargarDgvCitas();
            CargarComboboxCliente();
        }

        public void CargarComboboxCliente()
        {

            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234"))
            {
                string query = "select nombre_Completo from t_paciente";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cmbPaciente.DisplayMember = "nombre_Completo";
            cmbPaciente.ValueMember = "idt_paciente";
            cmbPaciente.DataSource = dt;
        }
        public void CargarDgvCitas()
        {
            S_HistorialPaciente();
        }

        public void S_HistorialPaciente()
        {
            con = new MySqlConnection(cs);
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("S_HistorialPaciente", con);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.Fill(tabla);
            dgvHistorial.DataSource = tabla;
        }

        private void btnAgregarDr_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs);
                con.Open();
                string query = "INSERT INTO t_historial_paciente (nombre_completo, fecha_actual, comentario) values (@nombre_completo, @fecha_actual, @comentario)";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@nombre_completo", cmbPaciente.Text);
                comando.Parameters.AddWithValue("@fecha_actual", dateTimePicker1.Text);
                comando.Parameters.AddWithValue("@comentario", txtcomentario.Text);

                comando.ExecuteNonQuery();
                CargarDgvCitas();
                con.Close();
                MessageBox.Show("Historial Agregado exitosamente. ");

                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, verifique los datos nuevamente. ");
            }
        }

        public void clear()
        {
            lblid.Text = "";
            cmbPaciente.Text = "";
            txtcomentario.Text = "";
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgvHistorial.CurrentRow.Cells[0].Value.ToString();
            cmbPaciente.Text = dgvHistorial.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dgvHistorial.CurrentRow.Cells[2].Value.ToString();
            txtcomentario.Text = dgvHistorial.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este historial?.", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM t_historial_paciente Where id_historialmedico = @id_historialmedico";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@id_historialmedico", lblid.Text);
                comando.ExecuteNonQuery();
                CargarDgvCitas();
                MessageBox.Show("Historial Eliminado Exitosamente. ");
                con.Close();
                clear();
            }
            else
            {
                MessageBox.Show("No Se Pudo Eliminar El Historial Seleccionado. ");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE t_historial_paciente SET nombre_completo = @nombre_completo, fecha_actual = @fecha_actual, comentario = @comentario where id_historialmedico=@id_historialmedico";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@id_historialmedico", lblid.Text);
            comando.Parameters.AddWithValue("@nombre_completo", cmbPaciente.Text);
            comando.Parameters.AddWithValue("@fecha_actual", dateTimePicker1.Text);
            comando.Parameters.AddWithValue("@comentario", txtcomentario.Text);
            comando.ExecuteNonQuery();
            CargarDgvCitas();
            MessageBox.Show("Historial Actualizado Exitosamente. ");
            con.Close();
            clear();
        }
    }
}
