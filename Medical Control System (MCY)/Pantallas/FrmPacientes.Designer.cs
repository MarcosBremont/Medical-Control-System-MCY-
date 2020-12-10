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
            this.LblIDD = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
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
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.LblEdad = new System.Windows.Forms.Label();
            this.txtfechanac = new System.Windows.Forms.TextBox();
            this.lblfechanac = new System.Windows.Forms.Label();
            this.txtnombrepaciente = new System.Windows.Forms.TextBox();
            this.lblnombrePaciente = new System.Windows.Forms.Label();
            this.txtotrosproblemas = new System.Windows.Forms.TextBox();
            this.lblotrosproblemas = new System.Windows.Forms.Label();
            this.txtalergias = new System.Windows.Forms.TextBox();
            this.lblalergias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LblIDD
            // 
            this.LblIDD.AutoSize = true;
            this.LblIDD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LblIDD.ForeColor = System.Drawing.Color.White;
            this.LblIDD.Location = new System.Drawing.Point(139, 20);
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
            this.lblid.Location = new System.Drawing.Point(166, 20);
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
            this.BtnEliminar.Location = new System.Drawing.Point(837, 526);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(186, 45);
            this.BtnEliminar.TabIndex = 142;
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
            this.BtnActualizar.Location = new System.Drawing.Point(180, 526);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(166, 45);
            this.BtnActualizar.TabIndex = 141;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAgregarPaciente.FlatAppearance.BorderSize = 0;
            this.btnAgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAgregarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(448, 526);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(262, 45);
            this.btnAgregarPaciente.TabIndex = 140;
            this.btnAgregarPaciente.Text = "Agregar Paciente";
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // LblPacientes
            // 
            this.LblPacientes.AutoSize = true;
            this.LblPacientes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPacientes.ForeColor = System.Drawing.Color.White;
            this.LblPacientes.Location = new System.Drawing.Point(497, 16);
            this.LblPacientes.Name = "LblPacientes";
            this.LblPacientes.Size = new System.Drawing.Size(80, 19);
            this.LblPacientes.TabIndex = 135;
            this.LblPacientes.Text = "Pacientes";
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
            this.dgvPacientes.Location = new System.Drawing.Point(139, 45);
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
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
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
            this.nombre_Completo.HeaderText = "Nombre Paciente";
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
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // alergias
            // 
            this.alergias.DataPropertyName = "alergias";
            this.alergias.HeaderText = "Alergias";
            this.alergias.Name = "alergias";
            this.alergias.ReadOnly = true;
            // 
            // otros_problemas
            // 
            this.otros_problemas.DataPropertyName = "otros_problemas";
            this.otros_problemas.HeaderText = "Otros Problemas";
            this.otros_problemas.Name = "otros_problemas";
            this.otros_problemas.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSexo.ForeColor = System.Drawing.Color.White;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(139, 442);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(162, 21);
            this.cmbSexo.TabIndex = 160;
            this.cmbSexo.Text = "Seleccione su sexo.";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtdireccion.ForeColor = System.Drawing.Color.Silver;
            this.txtdireccion.Location = new System.Drawing.Point(671, 433);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(165, 30);
            this.txtdireccion.TabIndex = 159;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(667, 411);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(74, 19);
            this.lbldireccion.TabIndex = 158;
            this.lbldireccion.Text = "Direccion";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(491, 433);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 30);
            this.txtEmail.TabIndex = 157;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(487, 411);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 19);
            this.lblemail.TabIndex = 156;
            this.lblemail.Text = "Email";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttelefono.ForeColor = System.Drawing.Color.Silver;
            this.txttelefono.Location = new System.Drawing.Point(320, 433);
            this.txttelefono.Multiline = true;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(165, 30);
            this.txttelefono.TabIndex = 155;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(316, 411);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(66, 19);
            this.lblTelefono.TabIndex = 154;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblsexo.ForeColor = System.Drawing.Color.White;
            this.lblsexo.Location = new System.Drawing.Point(139, 411);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(41, 19);
            this.lblsexo.TabIndex = 153;
            this.lblsexo.Text = "Sexo";
            // 
            // txtcelular
            // 
            this.txtcelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtcelular.ForeColor = System.Drawing.Color.Silver;
            this.txtcelular.Location = new System.Drawing.Point(671, 374);
            this.txtcelular.Multiline = true;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(165, 30);
            this.txtcelular.TabIndex = 152;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblcelular.ForeColor = System.Drawing.Color.White;
            this.lblcelular.Location = new System.Drawing.Point(667, 352);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(58, 19);
            this.lblcelular.TabIndex = 151;
            this.lblcelular.Text = "Celular";
            // 
            // txtedad
            // 
            this.txtedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtedad.ForeColor = System.Drawing.Color.Silver;
            this.txtedad.Location = new System.Drawing.Point(491, 374);
            this.txtedad.Multiline = true;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(165, 30);
            this.txtedad.TabIndex = 150;
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LblEdad.ForeColor = System.Drawing.Color.White;
            this.LblEdad.Location = new System.Drawing.Point(487, 352);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(47, 19);
            this.LblEdad.TabIndex = 149;
            this.LblEdad.Text = "Edad";
            // 
            // txtfechanac
            // 
            this.txtfechanac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtfechanac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtfechanac.ForeColor = System.Drawing.Color.Silver;
            this.txtfechanac.Location = new System.Drawing.Point(320, 374);
            this.txtfechanac.Multiline = true;
            this.txtfechanac.Name = "txtfechanac";
            this.txtfechanac.Size = new System.Drawing.Size(165, 30);
            this.txtfechanac.TabIndex = 148;
            // 
            // lblfechanac
            // 
            this.lblfechanac.AutoSize = true;
            this.lblfechanac.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblfechanac.ForeColor = System.Drawing.Color.White;
            this.lblfechanac.Location = new System.Drawing.Point(316, 352);
            this.lblfechanac.Name = "lblfechanac";
            this.lblfechanac.Size = new System.Drawing.Size(137, 19);
            this.lblfechanac.TabIndex = 147;
            this.lblfechanac.Text = "Fecha Nacimiento";
            // 
            // txtnombrepaciente
            // 
            this.txtnombrepaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtnombrepaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtnombrepaciente.ForeColor = System.Drawing.Color.Silver;
            this.txtnombrepaciente.Location = new System.Drawing.Point(139, 374);
            this.txtnombrepaciente.Multiline = true;
            this.txtnombrepaciente.Name = "txtnombrepaciente";
            this.txtnombrepaciente.Size = new System.Drawing.Size(165, 30);
            this.txtnombrepaciente.TabIndex = 146;
            // 
            // lblnombrePaciente
            // 
            this.lblnombrePaciente.AutoSize = true;
            this.lblnombrePaciente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnombrePaciente.ForeColor = System.Drawing.Color.White;
            this.lblnombrePaciente.Location = new System.Drawing.Point(139, 352);
            this.lblnombrePaciente.Name = "lblnombrePaciente";
            this.lblnombrePaciente.Size = new System.Drawing.Size(130, 19);
            this.lblnombrePaciente.TabIndex = 145;
            this.lblnombrePaciente.Text = "Nombre Paciente";
            // 
            // txtotrosproblemas
            // 
            this.txtotrosproblemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtotrosproblemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtotrosproblemas.ForeColor = System.Drawing.Color.Silver;
            this.txtotrosproblemas.Location = new System.Drawing.Point(860, 433);
            this.txtotrosproblemas.Multiline = true;
            this.txtotrosproblemas.Name = "txtotrosproblemas";
            this.txtotrosproblemas.Size = new System.Drawing.Size(165, 30);
            this.txtotrosproblemas.TabIndex = 164;
            // 
            // lblotrosproblemas
            // 
            this.lblotrosproblemas.AutoSize = true;
            this.lblotrosproblemas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblotrosproblemas.ForeColor = System.Drawing.Color.White;
            this.lblotrosproblemas.Location = new System.Drawing.Point(856, 411);
            this.lblotrosproblemas.Name = "lblotrosproblemas";
            this.lblotrosproblemas.Size = new System.Drawing.Size(119, 19);
            this.lblotrosproblemas.TabIndex = 163;
            this.lblotrosproblemas.Text = "Otros Problemas";
            // 
            // txtalergias
            // 
            this.txtalergias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtalergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtalergias.ForeColor = System.Drawing.Color.Silver;
            this.txtalergias.Location = new System.Drawing.Point(860, 374);
            this.txtalergias.Multiline = true;
            this.txtalergias.Name = "txtalergias";
            this.txtalergias.Size = new System.Drawing.Size(165, 30);
            this.txtalergias.TabIndex = 162;
            // 
            // lblalergias
            // 
            this.lblalergias.AutoSize = true;
            this.lblalergias.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblalergias.ForeColor = System.Drawing.Color.White;
            this.lblalergias.Location = new System.Drawing.Point(856, 352);
            this.lblalergias.Name = "lblalergias";
            this.lblalergias.Size = new System.Drawing.Size(61, 19);
            this.lblalergias.TabIndex = 161;
            this.lblalergias.Text = "Alergias";
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1220, 586);
            this.Controls.Add(this.txtotrosproblemas);
            this.Controls.Add(this.lblotrosproblemas);
            this.Controls.Add(this.txtalergias);
            this.Controls.Add(this.lblalergias);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.txtfechanac);
            this.Controls.Add(this.lblfechanac);
            this.Controls.Add(this.txtnombrepaciente);
            this.Controls.Add(this.lblnombrePaciente);
            this.Controls.Add(this.LblIDD);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.btnAgregarPaciente);
            this.Controls.Add(this.LblPacientes);
            this.Controls.Add(this.dgvPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPacientes";
            this.Text = "FrmPacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblIDD;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Label LblPacientes;
        public System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.TextBox txtfechanac;
        private System.Windows.Forms.Label lblfechanac;
        private System.Windows.Forms.TextBox txtnombrepaciente;
        private System.Windows.Forms.Label lblnombrePaciente;
        private System.Windows.Forms.TextBox txtotrosproblemas;
        private System.Windows.Forms.Label lblotrosproblemas;
        private System.Windows.Forms.TextBox txtalergias;
        private System.Windows.Forms.Label lblalergias;
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