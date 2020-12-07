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
    public partial class FrmHistorialCitasCompletas : Form
    {
        MySqlDataReader rdr = null;
        DataTable dt = new DataTable();

        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String cs = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");

        public FrmHistorialCitasCompletas()
        {
            InitializeComponent();
        }

        private void FrmHistorialCitasCompletas_Load(object sender, EventArgs e)
        {
            dgvHistorial.AutoGenerateColumns = false;
            DateTime fecha1 = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            string estado = cmbEstado.Text;
            S_FechaHistorial(fecha1, fecha2, estado);
            CargarDgvCitas();
           
        }

        public void S_FechaHistorial(DateTime prm_fechainicial, DateTime prm_fechafinal, string prm_estado)
        {
            con = new MySqlConnection(cs);
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("S_FechaHistorial", con);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("prm_fechainicial", MySqlDbType.DateTime).Value = prm_fechainicial;
            da.SelectCommand.Parameters.Add("prm_fechafinal", MySqlDbType.DateTime).Value = prm_fechafinal;
            da.SelectCommand.Parameters.Add("prm_estado", MySqlDbType.String).Value = prm_estado;
            da.Fill(tabla);
            dgvHistorial.DataSource = tabla;
        }

        public void CargarDgvCitas()
        {
            DateTime fecha1 = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            string estado = cmbEstado.Text;
            S_FechaHistorial(fecha1, fecha2, estado);
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            CargarDgvCitas();

        }
    }
}
