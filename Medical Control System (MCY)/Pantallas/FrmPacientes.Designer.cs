namespace Medical_Control_System__MCY_.Pantallas
{
    partial class FrmPacientes
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.LblIDD = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarDr = new System.Windows.Forms.Button();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.lblFecha_Nac = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblnombrepaciente = new System.Windows.Forms.Label();
            this.LblPacientes = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.idt_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otros_problemas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(527, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 146;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.cmbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPaciente.ForeColor = System.Drawing.Color.White;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(334, 365);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(162, 21);
            this.cmbPaciente.TabIndex = 145;
            this.cmbPaciente.Text = "Seleccione el Paciente";
            // 
            // LblIDD
            // 
            this.LblIDD.AutoSize = true;
            this.LblIDD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LblIDD.ForeColor = System.Drawing.Color.White;
            this.LblIDD.Location = new System.Drawing.Point(165, 20);
            this.LblIDD.Name = "LblIDD";
            this.LblIDD.Size = new System.Drawing.Size(26, 19);
            this.LblIDD.TabIndex = 144;
            this.LblIDD.Text = "ID:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(192, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 19);
            this.lblid.TabIndex = 143;
            this.lblid.Text = "...";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(863, 526);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(186, 45);
            this.BtnEliminar.TabIndex = 142;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(206, 526);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(166, 45);
            this.BtnActualizar.TabIndex = 141;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDr
            // 
            this.btnAgregarDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAgregarDr.FlatAppearance.BorderSize = 0;
            this.btnAgregarDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDr.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAgregarDr.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDr.Location = new System.Drawing.Point(474, 526);
            this.btnAgregarDr.Name = "btnAgregarDr";
            this.btnAgregarDr.Size = new System.Drawing.Size(262, 45);
            this.btnAgregarDr.TabIndex = 140;
            this.btnAgregarDr.Text = "Agregar Historial";
            this.btnAgregarDr.UseVisualStyleBackColor = false;
            // 
            // txtcomentario
            // 
            this.txtcomentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtcomentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtcomentario.ForeColor = System.Drawing.Color.Silver;
            this.txtcomentario.Location = new System.Drawing.Point(334, 433);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(652, 71);
            this.txtcomentario.TabIndex = 139;
            // 
            // lblFecha_Nac
            // 
            this.lblFecha_Nac.AutoSize = true;
            this.lblFecha_Nac.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFecha_Nac.ForeColor = System.Drawing.Color.White;
            this.lblFecha_Nac.Location = new System.Drawing.Point(330, 411);
            this.lblFecha_Nac.Name = "lblFecha_Nac";
            this.lblFecha_Nac.Size = new System.Drawing.Size(91, 19);
            this.lblFecha_Nac.TabIndex = 138;
            this.lblFecha_Nac.Text = "Comentario";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(523, 334);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(102, 19);
            this.lbldireccion.TabIndex = 137;
            this.lbldireccion.Text = "Fecha Actual";
            // 
            // lblnombrepaciente
            // 
            this.lblnombrepaciente.AutoSize = true;
            this.lblnombrepaciente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnombrepaciente.ForeColor = System.Drawing.Color.White;
            this.lblnombrepaciente.Location = new System.Drawing.Point(330, 334);
            this.lblnombrepaciente.Name = "lblnombrepaciente";
            this.lblnombrepaciente.Size = new System.Drawing.Size(130, 19);
            this.lblnombrepaciente.TabIndex = 136;
            this.lblnombrepaciente.Text = "Nombre Paciente";
            // 
            // LblPacientes
            // 
            this.LblPacientes.AutoSize = true;
            this.LblPacientes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPacientes.ForeColor = System.Drawing.Color.White;
            this.LblPacientes.Location = new System.Drawing.Point(523, 16);
            this.LblPacientes.Name = "LblPacientes";
            this.LblPacientes.Size = new System.Drawing.Size(146, 19);
            this.LblPacientes.TabIndex = 135;
            this.LblPacientes.Text = "Historial Pacientes";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToOrderColumns = true;
            this.dgvPacientes.AllowUserToResizeColumns = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.ColumnHeadersHeight = 40;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idt_paciente,
            this.nombre_Completo,
            this.fecha_nac,
            this.edad,
            this.sexo,
            this.telefono,
            this.celular,
            this.direccion,
            this.alergias,
            this.otros_problemas,
            this.email});
            this.dgvPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPacientes.Location = new System.Drawing.Point(165, 45);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPacientes.RowTemplate.Height = 30;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(891, 277);
            this.dgvPacientes.TabIndex = 134;
            // 
            // idt_paciente
            // 
            this.idt_paciente.DataPropertyName = "idt_paciente";
            this.idt_paciente.HeaderText = "N. Paciente";
            this.idt_paciente.Name = "idt_paciente";
            this.idt_paciente.ReadOnly = true;
            // 
            // nombre_Completo
            // 
            this.nombre_Completo.DataPropertyName = "nombre_Completo";
            this.nombre_Completo.HeaderText = "Nombre Completo";
            this.nombre_Completo.Name = "nombre_Completo";
            this.nombre_Completo.ReadOnly = true;
            // 
            // fecha_nac
            // 
            this.fecha_nac.DataPropertyName = "fecha_nac";
            this.fecha_nac.HeaderText = "Fecha Nac.";
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // alergias
            // 
            this.alergias.DataPropertyName = "alergias";
            this.alergias.HeaderText = "alergias";
            this.alergias.Name = "alergias";
            this.alergias.ReadOnly = true;
            // 
            // otros_problemas
            // 
            this.otros_problemas.DataPropertyName = "otros_problemas";
            this.otros_problemas.HeaderText = "otros_problemas";
            this.otros_problemas.Name = "otros_problemas";
            this.otros_problemas.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1220, 586);
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
            this.Controls.Add(this.LblPacientes);
            this.Controls.Add(this.dgvPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPacientes";
            this.Text = "FrmPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label LblIDD;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button btnAgregarDr;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label lblFecha_Nac;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblnombrepaciente;
        private System.Windows.Forms.Label LblPacientes;
        public System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idt_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn otros_problemas;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}