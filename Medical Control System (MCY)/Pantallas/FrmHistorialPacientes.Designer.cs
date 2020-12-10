namespace Medical_Control_System__MCY_.Pantallas
{
    partial class FrmHistorialPacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblIDD = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarDr = new System.Windows.Forms.Button();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.lblFecha_Nac = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblnombrepaciente = new System.Windows.Forms.Label();
            this.lblHistorialPacientes = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.id_historialmedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // LblIDD
            // 
            this.LblIDD.AutoSize = true;
            this.LblIDD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LblIDD.ForeColor = System.Drawing.Color.White;
            this.LblIDD.Location = new System.Drawing.Point(122, 19);
            this.LblIDD.Name = "LblIDD";
            this.LblIDD.Size = new System.Drawing.Size(26, 19);
            this.LblIDD.TabIndex = 131;
            this.LblIDD.Text = "ID:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(149, 19);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 19);
            this.lblid.TabIndex = 130;
            this.lblid.Text = "...";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(820, 525);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(186, 45);
            this.BtnEliminar.TabIndex = 129;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(163, 525);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(166, 45);
            this.BtnActualizar.TabIndex = 128;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnAgregarDr
            // 
            this.btnAgregarDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAgregarDr.FlatAppearance.BorderSize = 0;
            this.btnAgregarDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDr.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAgregarDr.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDr.Location = new System.Drawing.Point(431, 525);
            this.btnAgregarDr.Name = "btnAgregarDr";
            this.btnAgregarDr.Size = new System.Drawing.Size(262, 45);
            this.btnAgregarDr.TabIndex = 127;
            this.btnAgregarDr.Text = "Agregar Historial";
            this.btnAgregarDr.UseVisualStyleBackColor = false;
            this.btnAgregarDr.Click += new System.EventHandler(this.btnAgregarDr_Click);
            // 
            // txtcomentario
            // 
            this.txtcomentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtcomentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtcomentario.ForeColor = System.Drawing.Color.Silver;
            this.txtcomentario.Location = new System.Drawing.Point(291, 432);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(652, 71);
            this.txtcomentario.TabIndex = 122;
            // 
            // lblFecha_Nac
            // 
            this.lblFecha_Nac.AutoSize = true;
            this.lblFecha_Nac.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFecha_Nac.ForeColor = System.Drawing.Color.White;
            this.lblFecha_Nac.Location = new System.Drawing.Point(287, 410);
            this.lblFecha_Nac.Name = "lblFecha_Nac";
            this.lblFecha_Nac.Size = new System.Drawing.Size(91, 19);
            this.lblFecha_Nac.TabIndex = 121;
            this.lblFecha_Nac.Text = "Comentario";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(480, 333);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(102, 19);
            this.lbldireccion.TabIndex = 114;
            this.lbldireccion.Text = "Fecha Actual";
            // 
            // lblnombrepaciente
            // 
            this.lblnombrepaciente.AutoSize = true;
            this.lblnombrepaciente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnombrepaciente.ForeColor = System.Drawing.Color.White;
            this.lblnombrepaciente.Location = new System.Drawing.Point(287, 333);
            this.lblnombrepaciente.Name = "lblnombrepaciente";
            this.lblnombrepaciente.Size = new System.Drawing.Size(130, 19);
            this.lblnombrepaciente.TabIndex = 112;
            this.lblnombrepaciente.Text = "Nombre Paciente";
            // 
            // lblHistorialPacientes
            // 
            this.lblHistorialPacientes.AutoSize = true;
            this.lblHistorialPacientes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialPacientes.ForeColor = System.Drawing.Color.White;
            this.lblHistorialPacientes.Location = new System.Drawing.Point(480, 15);
            this.lblHistorialPacientes.Name = "lblHistorialPacientes";
            this.lblHistorialPacientes.Size = new System.Drawing.Size(146, 19);
            this.lblHistorialPacientes.TabIndex = 111;
            this.lblHistorialPacientes.Text = "Historial Pacientes";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToOrderColumns = true;
            this.dgvHistorial.AllowUserToResizeColumns = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.ColumnHeadersHeight = 40;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_historialmedico,
            this.nombre_completo,
            this.fecha_actual,
            this.comentario});
            this.dgvHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHistorial.Location = new System.Drawing.Point(122, 44);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHistorial.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorial.RowTemplate.Height = 30;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(891, 277);
            this.dgvHistorial.TabIndex = 110;
            this.dgvHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellClick);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.cmbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPaciente.ForeColor = System.Drawing.Color.White;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(291, 364);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(162, 21);
            this.cmbPaciente.TabIndex = 132;
            this.cmbPaciente.Text = "Seleccione el Paciente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 361);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 133;
            // 
            // id_historialmedico
            // 
            this.id_historialmedico.DataPropertyName = "id_historialmedico";
            this.id_historialmedico.HeaderText = "N. Historial";
            this.id_historialmedico.Name = "id_historialmedico";
            this.id_historialmedico.ReadOnly = true;
            // 
            // nombre_completo
            // 
            this.nombre_completo.DataPropertyName = "nombre_completo";
            this.nombre_completo.HeaderText = "Nombre Paciente";
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.ReadOnly = true;
            // 
            // fecha_actual
            // 
            this.fecha_actual.DataPropertyName = "fecha_actual";
            this.fecha_actual.HeaderText = "Fecha Actual";
            this.fecha_actual.Name = "fecha_actual";
            this.fecha_actual.ReadOnly = true;
            // 
            // comentario
            // 
            this.comentario.DataPropertyName = "comentario";
            this.comentario.HeaderText = "Comentario";
            this.comentario.Name = "comentario";
            this.comentario.ReadOnly = true;
            // 
            // FrmHistorialPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1168, 587);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.LblIDD);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.btnAgregarDr);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.lblFecha_Nac);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblnombrepaciente);
            this.Controls.Add(this.lblHistorialPacientes);
            this.Controls.Add(this.dgvHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistorialPacientes";
            this.Text = "FrmHistorialPacientes";
            this.Load += new System.EventHandler(this.FrmHistorialPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIDD;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button btnAgregarDr;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label lblFecha_Nac;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblnombrepaciente;
        private System.Windows.Forms.Label lblHistorialPacientes;
        public System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_historialmedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
    }
}