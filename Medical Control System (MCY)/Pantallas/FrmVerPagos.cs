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

namespace Medical_Control_System__MCY_
{
    public partial class FrmVerPagos : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataReader dr;

        String cs = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");
        public FrmVerPagos()
        {
            InitializeComponent();
        }

        private void FrmVerCitas_Load(object sender, EventArgs e)
        {
            dgvInventario.AutoGenerateColumns = false;
            string prm_nombre_Completo = cmbPaciente.Text;
            S_PagosPacientes(prm_nombre_Completo);
            CargarComboboxPaciente();
            CargarTotalDinero();
        }

        public void CargarTotalDinero()
        {
            int Total = (int)dgvInventario.Rows[0].Cells[2].Value;
            txttotal.Text = Total.ToString();
        }

        public void S_PagosPacientes(string prm_nombre_Completo)
        {
            con = new MySqlConnection(cs);
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("S_PagosPacientes", con);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("prm_nombre_Completo", MySqlDbType.String).Value = prm_nombre_Completo;
            da.Fill(tabla);
            dgvInventario.DataSource = tabla;
            txtrestante.Text = tabla.Compute("Sum(abono)", "").ToString();

        }

        public void CargarComboboxPaciente()
        {

            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234"))
            {
                string query = "select idt_citapaciente, nombre_Completo from t_citapaciente group by nombre_Completo";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cmbPaciente.DisplayMember = "nombre_Completo";
            cmbPaciente.ValueMember = "idt_citapaciente";
            cmbPaciente.DataSource = dt;
        }


        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre_Completo = cmbPaciente.Text;
            S_PagosPacientes(nombre_Completo);
            CargarTotalDinero();
            //int num1 = (int)dgvInventario.Rows[0].Cells[3].Value;
            //txtrestante.Text = (num1).ToString();
        }
    }
}
