namespace Medical_Control_System__MCY_.Pantallas
{
    partial class FrmAgregarCitas
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
            this.lblnombrepaciente = new System.Windows.Forms.Label();
            this.txtnombrepaciente = new System.Windows.Forms.TextBox();
            this.txtapellidopaciente = new System.Windows.Forms.TextBox();
            this.lblapellidopaciente = new System.Windows.Forms.Label();
            this.txtfechanacimiento = new System.Windows.Forms.TextBox();
            this.lblfechanacimiento = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.lblalergias = new System.Windows.Forms.Label();
            this.txtOtrosProblemas = new System.Windows.Forms.TextBox();
            this.lblotrosproblemas = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnAgregarCita = new System.Windows.Forms.Button();
            this.dtpfechacita = new System.Windows.Forms.DateTimePicker();
            this.lblfechacita = new System.Windows.Forms.Label();
            this.lblhoracita = new System.Windows.Forms.Label();
            this.dtphoracita = new System.Windows.Forms.DateTimePicker();
            this.lblagregarcita = new System.Windows.Forms.Label();
            this.dgvcitas = new System.Windows.Forms.DataGridView();
            this.idt_citapaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otros_problemas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPagos = new System.Windows.Forms.Button();
            this.txttotaldinero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnumero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombrepaciente
            // 
            this.lblnombrepaciente.AutoSize = true;
            this.lblnombrepaciente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnombrepaciente.ForeColor = System.Drawing.Color.White;
            this.lblnombrepaciente.Location = new System.Drawing.Point(12, 213);
            this.lblnombrepaciente.Name = "lblnombrepaciente";
            this.lblnombrepaciente.Size = new System.Drawing.Size(130, 19);
            this.lblnombrepaciente.TabIndex = 10;
            this.lblnombrepaciente.Text = "Nombre Paciente";
            // 
            // txtnombrepaciente
            // 
            this.txtnombrepaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtnombrepaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtnombrepaciente.ForeColor = System.Drawing.Color.Silver;
            this.txtnombrepaciente.Location = new System.Drawing.Point(12, 241);
            this.txtnombrepaciente.Multiline = true;
            this.txtnombrepaciente.Name = "txtnombrepaciente";
            this.txtnombrepaciente.Size = new System.Drawing.Size(165, 30);
            this.txtnombrepaciente.TabIndex = 13;
            // 
            // txtapellidopaciente
            // 
            this.txtapellidopaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtapellidopaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtapellidopaciente.ForeColor = System.Drawing.Color.Silver;
            this.txtapellidopaciente.Location = new System.Drawing.Point(214, 241);
            this.txtapellidopaciente.Multiline = true;
            this.txtapellidopaciente.Name = "txtapellidopaciente";
            this.txtapellidopaciente.Size = new System.Drawing.Size(165, 30);
            this.txtapellidopaciente.TabIndex = 15;
            // 
            // lblapellidopaciente
            // 
            this.lblapellidopaciente.AutoSize = true;
            this.lblapellidopaciente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblapellidopaciente.ForeColor = System.Drawing.Color.White;
            this.lblapellidopaciente.Location = new System.Drawing.Point(214, 213);
            this.lblapellidopaciente.Name = "lblapellidopaciente";
            this.lblapellidopaciente.Size = new System.Drawing.Size(131, 19);
            this.lblapellidopaciente.TabIndex = 14;
            this.lblapellidopaciente.Text = "Apellido Paciente";
            // 
            // txtfechanacimiento
            // 
            this.txtfechanacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtfechanacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtfechanacimiento.ForeColor = System.Drawing.Color.Silver;
            this.txtfechanacimiento.Location = new System.Drawing.Point(12, 308);
            this.txtfechanacimiento.Multiline = true;
            this.txtfechanacimiento.Name = "txtfechanacimiento";
            this.txtfechanacimiento.Size = new System.Drawing.Size(165, 30);
            this.txtfechanacimiento.TabIndex = 17;
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblfechanacimiento.ForeColor = System.Drawing.Color.White;
            this.lblfechanacimiento.Location = new System.Drawing.Point(12, 280);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(137, 19);
            this.lblfechanacimiento.TabIndex = 16;
            this.lblfechanacimiento.Text = "Fecha Nacimiento";
            // 
            // txtedad
            // 
            this.txtedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtedad.ForeColor = System.Drawing.Color.Silver;
            this.txtedad.Location = new System.Drawing.Point(214, 308);
            this.txtedad.Multiline = true;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(65, 30);
            this.txtedad.TabIndex = 19;
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbledad.ForeColor = System.Drawing.Color.White;
            this.lbledad.Location = new System.Drawing.Point(214, 280);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(47, 19);
            this.lbledad.TabIndex = 18;
            this.lbledad.Text = "Edad";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblsexo.ForeColor = System.Drawing.Color.White;
            this.lblsexo.Location = new System.Drawing.Point(738, 213);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(41, 19);
            this.lblsexo.TabIndex = 20;
            this.lblsexo.Text = "Sexo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefono.Location = new System.Drawing.Point(403, 314);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 30);
            this.txtTelefono.TabIndex = 23;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbltelefono.ForeColor = System.Drawing.Color.White;
            this.lbltelefono.Location = new System.Drawing.Point(403, 284);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(66, 19);
            this.lbltelefono.TabIndex = 22;
            this.lbltelefono.Text = "Telefono";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCelular.ForeColor = System.Drawing.Color.Silver;
            this.txtCelular.Location = new System.Drawing.Point(735, 299);
            this.txtCelular.Multiline = true;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(165, 30);
            this.txtCelular.TabIndex = 25;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblcelular.ForeColor = System.Drawing.Color.White;
            this.lblcelular.Location = new System.Drawing.Point(735, 275);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(58, 19);
            this.lblcelular.TabIndex = 24;
            this.lblcelular.Text = "Celular";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Silver;
            this.txtDireccion.Location = new System.Drawing.Point(400, 243);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(332, 30);
            this.txtDireccion.TabIndex = 27;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(400, 213);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(74, 19);
            this.lbldireccion.TabIndex = 26;
            this.lbldireccion.Text = "Direccion";
            // 
            // txtAlergias
            // 
            this.txtAlergias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAlergias.ForeColor = System.Drawing.Color.Silver;
            this.txtAlergias.Location = new System.Drawing.Point(950, 241);
            this.txtAlergias.Multiline = true;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(165, 30);
            this.txtAlergias.TabIndex = 29;
            // 
            // lblalergias
            // 
            this.lblalergias.AutoSize = true;
            this.lblalergias.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblalergias.ForeColor = System.Drawing.Color.White;
            this.lblalergias.Location = new System.Drawing.Point(950, 213);
            this.lblalergias.Name = "lblalergias";
            this.lblalergias.Size = new System.Drawing.Size(61, 19);
            this.lblalergias.TabIndex = 28;
            this.lblalergias.Text = "Alergias";
            // 
            // txtOtrosProblemas
            // 
            this.txtOtrosProblemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtOtrosProblemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtOtrosProblemas.ForeColor = System.Drawing.Color.Silver;
            this.txtOtrosProblemas.Location = new System.Drawing.Point(950, 308);
            this.txtOtrosProblemas.Multiline = true;
            this.txtOtrosProblemas.Name = "txtOtrosProblemas";
            this.txtOtrosProblemas.Size = new System.Drawing.Size(165, 30);
            this.txtOtrosProblemas.TabIndex = 31;
            // 
            // lblotrosproblemas
            // 
            this.lblotrosproblemas.AutoSize = true;
            this.lblotrosproblemas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblotrosproblemas.ForeColor = System.Drawing.Color.White;
            this.lblotrosproblemas.Location = new System.Drawing.Point(950, 280);
            this.lblotrosproblemas.Name = "lblotrosproblemas";
            this.lblotrosproblemas.Size = new System.Drawing.Size(119, 19);
            this.lblotrosproblemas.TabIndex = 30;
            this.lblotrosproblemas.Text = "Otros Problemas";
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
            this.cmbSexo.Location = new System.Drawing.Point(738, 245);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(162, 21);
            this.cmbSexo.TabIndex = 33;
            this.cmbSexo.Text = "Seleccione su sexo.";
            // 
            // btnAgregarCita
            // 
            this.btnAgregarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAgregarCita.FlatAppearance.BorderSize = 0;
            this.btnAgregarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCita.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAgregarCita.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCita.Location = new System.Drawing.Point(419, 443);
            this.btnAgregarCita.Name = "btnAgregarCita";
            this.btnAgregarCita.Size = new System.Drawing.Size(262, 45);
            this.btnAgregarCita.TabIndex = 34;
            this.btnAgregarCita.Text = "Agregar Cita";
            this.btnAgregarCita.UseVisualStyleBackColor = false;
            this.btnAgregarCita.Click += new System.EventHandler(this.btnAgregarCita_Click);
            // 
            // dtpfechacita
            // 
            this.dtpfechacita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechacita.Location = new System.Drawing.Point(12, 375);
            this.dtpfechacita.Name = "dtpfechacita";
            this.dtpfechacita.Size = new System.Drawing.Size(83, 20);
            this.dtpfechacita.TabIndex = 35;
            // 
            // lblfechacita
            // 
            this.lblfechacita.AutoSize = true;
            this.lblfechacita.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblfechacita.ForeColor = System.Drawing.Color.White;
            this.lblfechacita.Location = new System.Drawing.Point(12, 347);
            this.lblfechacita.Name = "lblfechacita";
            this.lblfechacita.Size = new System.Drawing.Size(86, 19);
            this.lblfechacita.TabIndex = 36;
            this.lblfechacita.Text = "Fecha Cita";
            // 
            // lblhoracita
            // 
            this.lblhoracita.AutoSize = true;
            this.lblhoracita.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblhoracita.ForeColor = System.Drawing.Color.White;
            this.lblhoracita.Location = new System.Drawing.Point(214, 347);
            this.lblhoracita.Name = "lblhoracita";
            this.lblhoracita.Size = new System.Drawing.Size(75, 19);
            this.lblhoracita.TabIndex = 38;
            this.lblhoracita.Text = "Hora Cita";
            // 
            // dtphoracita
            // 
            this.dtphoracita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtphoracita.Location = new System.Drawing.Point(214, 375);
            this.dtphoracita.Name = "dtphoracita";
            this.dtphoracita.Size = new System.Drawing.Size(83, 20);
            this.dtphoracita.TabIndex = 37;
            // 
            // lblagregarcita
            // 
            this.lblagregarcita.AutoSize = true;
            this.lblagregarcita.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.lblagregarcita.ForeColor = System.Drawing.Color.White;
            this.lblagregarcita.Location = new System.Drawing.Point(493, 4);
            this.lblagregarcita.Name = "lblagregarcita";
            this.lblagregarcita.Size = new System.Drawing.Size(75, 31);
            this.lblagregarcita.TabIndex = 32;
            this.lblagregarcita.Text = "Citas";
            // 
            // dgvcitas
            // 
            this.dgvcitas.AllowUserToAddRows = false;
            this.dgvcitas.AllowUserToDeleteRows = false;
            this.dgvcitas.AllowUserToOrderColumns = true;
            this.dgvcitas.AllowUserToResizeColumns = false;
            this.dgvcitas.AllowUserToResizeRows = false;
            this.dgvcitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvcitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcitas.ColumnHeadersHeight = 40;
            this.dgvcitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idt_citapaciente,
            this.nombre_paciente,
            this.apellido_paciente,
            this.telefono,
            this.celular,
            this.fecha_cita,
            this.hora_cita,
            this.fecha_nacimiento,
            this.edad,
            this.sexo,
            this.direccion,
            this.alergias,
            this.otros_problemas,
            this.totaldinero,
            this.abono,
            this.estado});
            this.dgvcitas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcitas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcitas.EnableHeadersVisualStyles = false;
            this.dgvcitas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvcitas.Location = new System.Drawing.Point(12, 52);
            this.dgvcitas.MultiSelect = false;
            this.dgvcitas.Name = "dgvcitas";
            this.dgvcitas.ReadOnly = true;
            this.dgvcitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcitas.RowHeadersVisible = false;
            this.dgvcitas.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvcitas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcitas.RowTemplate.Height = 30;
            this.dgvcitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcitas.Size = new System.Drawing.Size(1109, 146);
            this.dgvcitas.TabIndex = 80;
            this.dgvcitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcitas_CellClick);
            this.dgvcitas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvcitas_CellFormatting);
            // 
            // idt_citapaciente
            // 
            this.idt_citapaciente.DataPropertyName = "idt_citapaciente";
            this.idt_citapaciente.HeaderText = "N. Paciente";
            this.idt_citapaciente.Name = "idt_citapaciente";
            this.idt_citapaciente.ReadOnly = true;
            // 
            // nombre_paciente
            // 
            this.nombre_paciente.DataPropertyName = "nombre_paciente";
            this.nombre_paciente.HeaderText = "Nombre P.";
            this.nombre_paciente.Name = "nombre_paciente";
            this.nombre_paciente.ReadOnly = true;
            // 
            // apellido_paciente
            // 
            this.apellido_paciente.DataPropertyName = "apellido_paciente";
            this.apellido_paciente.HeaderText = "Apellido P.";
            this.apellido_paciente.Name = "apellido_paciente";
            this.apellido_paciente.ReadOnly = true;
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
            // fecha_cita
            // 
            this.fecha_cita.DataPropertyName = "fecha_cita";
            this.fecha_cita.HeaderText = "Fecha Cita";
            this.fecha_cita.Name = "fecha_cita";
            this.fecha_cita.ReadOnly = true;
            // 
            // hora_cita
            // 
            this.hora_cita.DataPropertyName = "hora_cita";
            this.hora_cita.HeaderText = "Hora Cita";
            this.hora_cita.Name = "hora_cita";
            this.hora_cita.ReadOnly = true;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimiento.HeaderText = "Fecha N.";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
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
            // totaldinero
            // 
            this.totaldinero.DataPropertyName = "totaldinero";
            this.totaldinero.HeaderText = "Total Dinero";
            this.totaldinero.Name = "totaldinero";
            this.totaldinero.ReadOnly = true;
            // 
            // abono
            // 
            this.abono.DataPropertyName = "abono";
            this.abono.HeaderText = "Abono";
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(754, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 81;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(935, 14);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker2.TabIndex = 82;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnBuscarFecha.FlatAppearance.BorderSize = 0;
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnBuscarFecha.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFecha.Location = new System.Drawing.Point(1024, 11);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(75, 28);
            this.btnBuscarFecha.TabIndex = 83;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(657, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "Fecha Inical";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(843, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 85;
            this.label2.Text = "Fecha Final";
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.Location = new System.Drawing.Point(735, 443);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(156, 45);
            this.btnPagos.TabIndex = 86;
            this.btnPagos.Text = "Completada";
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // txttotaldinero
            // 
            this.txttotaldinero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txttotaldinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttotaldinero.ForeColor = System.Drawing.Color.Silver;
            this.txttotaldinero.Location = new System.Drawing.Point(735, 379);
            this.txttotaldinero.Multiline = true;
            this.txttotaldinero.Name = "txttotaldinero";
            this.txttotaldinero.Size = new System.Drawing.Size(165, 30);
            this.txttotaldinero.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(731, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 88;
            this.label3.Text = "Total Trabajo $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(950, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 90;
            this.label4.Text = "Abono";
            // 
            // txtabono
            // 
            this.txtabono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtabono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtabono.ForeColor = System.Drawing.Color.Silver;
            this.txtabono.Location = new System.Drawing.Point(950, 375);
            this.txtabono.Multiline = true;
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(165, 30);
            this.txtabono.TabIndex = 89;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(21, 443);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(156, 45);
            this.btnActualizar.TabIndex = 91;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(34, 23);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 19);
            this.lblid.TabIndex = 92;
            this.lblid.Text = "...";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(214, 443);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(156, 45);
            this.btnEliminar.TabIndex = 93;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 19);
            this.label5.TabIndex = 94;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(404, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 95;
            this.label6.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstado.ForeColor = System.Drawing.Color.White;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Completada",
            "Pendiente"});
            this.cmbEstado.Location = new System.Drawing.Point(403, 385);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(162, 21);
            this.cmbEstado.TabIndex = 96;
            this.cmbEstado.Text = "Seleccione el estado.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Control_System__MCY_.Properties.Resources.notificacion;
            this.pictureBox1.Location = new System.Drawing.Point(1024, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblnumero.Location = new System.Drawing.Point(1075, 425);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(13, 13);
            this.lblnumero.TabIndex = 98;
            this.lblnumero.Text = "..";
            // 
            // AgregarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1130, 505);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtabono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotaldinero);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvcitas);
            this.Controls.Add(this.lblagregarcita);
            this.Controls.Add(this.lblhoracita);
            this.Controls.Add(this.dtphoracita);
            this.Controls.Add(this.lblfechacita);
            this.Controls.Add(this.dtpfechacita);
            this.Controls.Add(this.btnAgregarCita);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtOtrosProblemas);
            this.Controls.Add(this.lblotrosproblemas);
            this.Controls.Add(this.txtAlergias);
            this.Controls.Add(this.lblalergias);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.txtfechanacimiento);
            this.Controls.Add(this.lblfechanacimiento);
            this.Controls.Add(this.txtapellidopaciente);
            this.Controls.Add(this.lblapellidopaciente);
            this.Controls.Add(this.txtnombrepaciente);
            this.Controls.Add(this.lblnombrepaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCitas";
            this.Text = "AgregarCitas";
            this.Load += new System.EventHandler(this.AgregarCitas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgregarCitas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblnombrepaciente;
        private System.Windows.Forms.TextBox txtnombrepaciente;
        private System.Windows.Forms.TextBox txtapellidopaciente;
        private System.Windows.Forms.Label lblapellidopaciente;
        private System.Windows.Forms.TextBox txtfechanacimiento;
        private System.Windows.Forms.Label lblfechanacimiento;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.Label lblalergias;
        private System.Windows.Forms.TextBox txtOtrosProblemas;
        private System.Windows.Forms.Label lblotrosproblemas;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnAgregarCita;
        private System.Windows.Forms.Label lblfechacita;
        private System.Windows.Forms.Label lblhoracita;
        private System.Windows.Forms.DateTimePicker dtphoracita;
        private System.Windows.Forms.Label lblagregarcita;
        public System.Windows.Forms.DataGridView dgvcitas;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.TextBox txttotaldinero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtabono;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idt_citapaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn otros_problemas;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnumero;
        public System.Windows.Forms.DateTimePicker dtpfechacita;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}