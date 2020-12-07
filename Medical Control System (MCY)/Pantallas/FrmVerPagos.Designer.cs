namespace Medical_Control_System__MCY_
{
    partial class FrmVerPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.txtrestante = new System.Windows.Forms.TextBox();
            this.nombre_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToOrderColumns = true;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(167)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventario.ColumnHeadersHeight = 40;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_paciente,
            this.apellido_paciente,
            this.celular,
            this.totaldinero,
            this.abono});
            this.dgvInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInventario.Location = new System.Drawing.Point(55, 41);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 10;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInventario.RowTemplate.Height = 30;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(693, 381);
            this.dgvInventario.TabIndex = 80;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(55, 13);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(131, 21);
            this.cmbPaciente.TabIndex = 81;
            this.cmbPaciente.Text = "Seleccione el paciente";
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // txtrestante
            // 
            this.txtrestante.Location = new System.Drawing.Point(629, 428);
            this.txtrestante.Name = "txtrestante";
            this.txtrestante.Size = new System.Drawing.Size(100, 20);
            this.txtrestante.TabIndex = 82;
            // 
            // nombre_paciente
            // 
            this.nombre_paciente.DataPropertyName = "nombre_paciente";
            this.nombre_paciente.HeaderText = "nombre_paciente";
            this.nombre_paciente.Name = "nombre_paciente";
            this.nombre_paciente.ReadOnly = true;
            // 
            // apellido_paciente
            // 
            this.apellido_paciente.DataPropertyName = "apellido_paciente";
            this.apellido_paciente.HeaderText = "apellido_paciente";
            this.apellido_paciente.Name = "apellido_paciente";
            this.apellido_paciente.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // totaldinero
            // 
            this.totaldinero.DataPropertyName = "totaldinero";
            this.totaldinero.HeaderText = "totaldinero";
            this.totaldinero.Name = "totaldinero";
            this.totaldinero.ReadOnly = true;
            // 
            // abono
            // 
            this.abono.DataPropertyName = "abono";
            this.abono.HeaderText = "abono";
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            // 
            // FrmVerPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtrestante);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.dgvInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerPagos";
            this.Text = "FrmVerPagos";
            this.Load += new System.EventHandler(this.FrmVerCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.TextBox txtrestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
    }
}