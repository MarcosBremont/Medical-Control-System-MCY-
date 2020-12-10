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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CheckedC();
        }
        

        public void CheckedC()
        {
            if (CbModoDia.Checked)
            {
                this.BackColor = Color.White; // this should be pink-ish
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.BackColor = Color.White;

            }
            else
            {
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.BackColor = Color.Red;
                this.BackColor = Color.FromArgb(37, 51, 61); // this should be pink-ish

            }
        }

        private void CbModoDia_CheckedChanged(object sender, EventArgs e)
        {
            CheckedC();
        }
    }
}
