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
    public partial class AgregarCitas : Form
    {
        public AgregarCitas()
        {
            InitializeComponent();
        }

        MySqlDataReader rdr = null;
        DataTable dt = new DataTable();

        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String cs = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");
        private void AgregarCitas_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void clear()
        {
            txtnombrepaciente.Text = "";
            txtapellidopaciente.Text = "";
            txtedad.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtfechanacimiento.Text = "";
            txtOtrosProblemas.Text = "";
            txtTelefono.Text = "";
            cmbSexo.Text = "";

        }
        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(cs);
            con.Open();
            string query = "INSERT INTO t_citapaciente (nombre_paciente, apellido_paciente, fecha_nacimiento, edad, sexo, telefono, celular, direccion, alergias, otros_problemas, fecha_cita, hora_cita) values (@nombre_paciente, @apellido_paciente, @fecha_nacimiento, @edad, @sexo, @telefono, @celular, @direccion, @alergias, @otros_problemas, @fecha_cita, @hora_cita)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@nombre_paciente", txtnombrepaciente.Text);
            comando.Parameters.AddWithValue("@apellido_paciente", txtapellidopaciente.Text);
            comando.Parameters.AddWithValue("@fecha_nacimiento", txtfechanacimiento.Text);
            comando.Parameters.AddWithValue("@edad", txtedad.Text);
            comando.Parameters.AddWithValue("@sexo", cmbSexo.Text);
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
            comando.Parameters.AddWithValue("@celular", txtCelular.Text);
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@alergias", txtAlergias.Text);
            comando.Parameters.AddWithValue("@otros_problemas", txtOtrosProblemas.Text);
            comando.Parameters.AddWithValue("@fecha_cita", dtpfechacita.Value);
            comando.Parameters.AddWithValue("@hora_cita", dtphoracita.Value);
            comando.ExecuteNonQuery();
            CargarDgvCitas();
            con.Close();
            MessageBox.Show("Cita Agregada exitosamente");

            clear();
        }
        public void CargarDgvCitas()
        {
            con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand("Select * from t_citapaciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvcitas.DataSource = tabla;

        }

        private void AgregarCitas_Load(object sender, EventArgs e)
        {
            dgvcitas.AutoGenerateColumns = false;
            CargarDgvCitas();
            DateTime fecha1 = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            S_fecha(fecha1, fecha2);
        }

        private void dgvcitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombrepaciente.Text = dgvcitas.CurrentRow.Cells[0].Value.ToString();
            txtapellidopaciente.Text = dgvcitas.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Text = dgvcitas.CurrentRow.Cells[2].Value.ToString();
            txtCelular.Text = dgvcitas.CurrentRow.Cells[3].Value.ToString();
            dtpfechacita.Text = dgvcitas.CurrentRow.Cells[4].Value.ToString();
            dtphoracita.Text = dgvcitas.CurrentRow.Cells[5].Value.ToString();
            txtfechanacimiento.Text = dgvcitas.CurrentRow.Cells[6].Value.ToString();
            txtedad.Text = dgvcitas.CurrentRow.Cells[7].Value.ToString();
            cmbSexo.Text = dgvcitas.CurrentRow.Cells[8].Value.ToString();
            txtDireccion.Text = dgvcitas.CurrentRow.Cells[9].Value.ToString();
            txtAlergias.Text = dgvcitas.CurrentRow.Cells[10].Value.ToString();
            txtOtrosProblemas.Text = dgvcitas.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            S_fecha(fecha1, fecha2);
        }

        public void S_fecha(DateTime prm_fechainicial, DateTime prm_fechafinal)
        {
            con = new MySqlConnection(cs);
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("S_Fecha", con);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("prm_fechainicial", MySqlDbType.DateTime).Value = prm_fechainicial;
            da.SelectCommand.Parameters.Add("prm_fechafinal", MySqlDbType.DateTime).Value = prm_fechafinal;
            da.Fill(tabla);
            dgvcitas.DataSource = tabla;
        }


    }
}
