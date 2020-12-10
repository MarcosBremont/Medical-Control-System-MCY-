namespace Medical_Control_System__MCY_.Pantallas
{
    partial class FrmDoctores
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lbldoctores = new System.Windows.Forms.Label();
            this.lblnombredr = new System.Windows.Forms.Label();
            this.txtnombredoctor = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtfecha_nac = new System.Windows.Forms.TextBox();
            this.lblFecha_Nac = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAgregarDr = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.LblIDD = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.idt_doctores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
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
            this.idt_doctores,
            this.nombre_Completo,
            this.Direccion,
            this.Telefono,
            this.Celular,
            this.sexo,
            this.fecha_nacimiento,
            this.Email,
            this.categoria});
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
            this.dgvHistorial.Location = new System.Drawing.Point(128, 45);
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
            this.dgvHistorial.TabIndex = 83;
            this.dgvHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellClick);
            // 
            // lbldoctores
            // 
            this.lbldoctores.AutoSize = true;
            this.lbldoctores.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctores.ForeColor = System.Drawing.Color.White;
            this.lbldoctores.Location = new System.Drawing.Point(526, 12);
            this.lbldoctores.Name = "lbldoctores";
            this.lbldoctores.Size = new System.Drawing.Size(75, 19);
            this.lbldoctores.TabIndex = 84;
            this.lbldoctores.Text = "Doctores";
            // 
            // lblnombredr
            // 
            this.lblnombredr.AutoSize = true;
            this.lblnombredr.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnombredr.ForeColor = System.Drawing.Color.White;
            this.lblnombredr.Location = new System.Drawing.Point(218, 334);
            this.lblnombredr.Name = "lblnombredr";
            this.lblnombredr.Size = new System.Drawing.Size(102, 19);
            this.lblnombredr.TabIndex = 85;
            this.lblnombredr.Text = "Nombre Dr(a)";
            // 
            // txtnombredoctor
            // 
            this.txtnombredoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtnombredoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtnombredoctor.ForeColor = System.Drawing.Color.Silver;
            this.txtnombredoctor.Location = new System.Drawing.Point(218, 356);
            this.txtnombredoctor.Multiline = true;
            this.txtnombredoctor.Name = "txtnombredoctor";
            this.txtnombredoctor.Size = new System.Drawing.Size(165, 30);
            this.txtnombredoctor.TabIndex = 86;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtdireccion.ForeColor = System.Drawing.Color.Silver;
            this.txtdireccion.Location = new System.Drawing.Point(399, 356);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(165, 30);
            this.txtdireccion.TabIndex = 88;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(395, 334);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(74, 19);
            this.lbldireccion.TabIndex = 87;
            this.lbldireccion.Text = "Direccion";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttelefono.ForeColor = System.Drawing.Color.Silver;
            this.txttelefono.Location = new System.Drawing.Point(570, 356);
            this.txttelefono.Multiline = true;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(165, 30);
            this.txttelefono.TabIndex = 90;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbltelefono.ForeColor = System.Drawing.Color.White;
            this.lbltelefono.Location = new System.Drawing.Point(566, 334);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(66, 19);
            this.lbltelefono.TabIndex = 89;
            this.lbltelefono.Text = "Telefono";
            // 
            // txtcelular
            // 
            this.txtcelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtcelular.ForeColor = System.Drawing.Color.Silver;
            this.txtcelular.Location = new System.Drawing.Point(750, 356);
            this.txtcelular.Multiline = true;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(165, 30);
            this.txtcelular.TabIndex = 92;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblcelular.ForeColor = System.Drawing.Color.White;
            this.lblcelular.Location = new System.Drawing.Point(746, 334);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(58, 19);
            this.lblcelular.TabIndex = 91;
            this.lblcelular.Text = "Celular";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblsexo.ForeColor = System.Drawing.Color.White;
            this.lblsexo.Location = new System.Drawing.Point(218, 393);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(41, 19);
            this.lblsexo.TabIndex = 93;
            this.lblsexo.Text = "Sexo";
            // 
            // txtfecha_nac
            // 
            this.txtfecha_nac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtfecha_nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtfecha_nac.ForeColor = System.Drawing.Color.Silver;
            this.txtfecha_nac.Location = new System.Drawing.Point(399, 415);
            this.txtfecha_nac.Multiline = true;
            this.txtfecha_nac.Name = "txtfecha_nac";
            this.txtfecha_nac.Size = new System.Drawing.Size(165, 30);
            this.txtfecha_nac.TabIndex = 96;
            // 
            // lblFecha_Nac
            // 
            this.lblFecha_Nac.AutoSize = true;
            this.lblFecha_Nac.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFecha_Nac.ForeColor = System.Drawing.Color.White;
            this.lblFecha_Nac.Location = new System.Drawing.Point(395, 393);
            this.lblFecha_Nac.Name = "lblFecha_Nac";
            this.lblFecha_Nac.Size = new System.Drawing.Size(90, 19);
            this.lblFecha_Nac.TabIndex = 95;
            this.lblFecha_Nac.Text = "Fecha Nac.";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(570, 415);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 30);
            this.txtEmail.TabIndex = 98;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(566, 393);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 19);
            this.lblemail.TabIndex = 97;
            this.lblemail.Text = "Email";
            // 
            // txtcategoria
            // 
            this.txtcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.txtcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtcategoria.ForeColor = System.Drawing.Color.Silver;
            this.txtcategoria.Location = new System.Drawing.Point(750, 415);
            this.txtcategoria.Multiline = true;
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(165, 30);
            this.txtcategoria.TabIndex = 100;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(746, 393);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(79, 19);
            this.lblCategoria.TabIndex = 99;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnAgregarDr
            // 
            this.btnAgregarDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAgregarDr.FlatAppearance.BorderSize = 0;
            this.btnAgregarDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDr.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAgregarDr.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDr.Location = new System.Drawing.Point(437, 548);
            this.btnAgregarDr.Name = "btnAgregarDr";
            this.btnAgregarDr.Size = new System.Drawing.Size(262, 45);
            this.btnAgregarDr.TabIndex = 103;
            this.btnAgregarDr.Text = "Agregar Doctor";
            this.btnAgregarDr.UseVisualStyleBackColor = false;
            this.btnAgregarDr.Click += new System.EventHandler(this.btnAgregarDr_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(169, 548);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(166, 45);
            this.BtnActualizar.TabIndex = 104;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(826, 548);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(186, 45);
            this.BtnEliminar.TabIndex = 105;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(155, 23);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 19);
            this.lblid.TabIndex = 108;
            this.lblid.Text = "...";
            // 
            // LblIDD
            // 
            this.LblIDD.AutoSize = true;
            this.LblIDD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LblIDD.ForeColor = System.Drawing.Color.White;
            this.LblIDD.Location = new System.Drawing.Point(128, 23);
            this.LblIDD.Name = "LblIDD";
            this.LblIDD.Size = new System.Drawing.Size(26, 19);
            this.LblIDD.TabIndex = 108;
            this.LblIDD.Text = "ID:";
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
            this.cmbSexo.Location = new System.Drawing.Point(218, 424);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(162, 21);
            this.cmbSexo.TabIndex = 109;
            this.cmbSexo.Text = "Seleccione su sexo.";
            // 
            // idt_doctores
            // 
            this.idt_doctores.DataPropertyName = "idt_doctores";
            this.idt_doctores.HeaderText = "N. Doctor";
            this.idt_doctores.Name = "idt_doctores";
            this.idt_doctores.ReadOnly = true;
            // 
            // nombre_Completo
            // 
            this.nombre_Completo.DataPropertyName = "nombre_Completo";
            this.nombre_Completo.HeaderText = "Nombre Dr(a).";
            this.nombre_Completo.Name = "nombre_Completo";
            this.nombre_Completo.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimiento.HeaderText = "Fecha Nac.";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // FrmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1206, 602);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.LblIDD);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.btnAgregarDr);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtfecha_nac);
            this.Controls.Add(this.lblFecha_Nac);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.txtnombredoctor);
            this.Controls.Add(this.lblnombredr);
            this.Controls.Add(this.lbldoctores);
            this.Controls.Add(this.dgvHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoctores";
            this.Text = "FrmDoctores";
            this.Load += new System.EventHandler(this.FrmDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lbldoctores;
        private System.Windows.Forms.Label lblnombredr;
        private System.Windows.Forms.TextBox txtnombredoctor;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtfecha_nac;
        private System.Windows.Forms.Label lblFecha_Nac;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAgregarDr;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label LblIDD;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idt_doctores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}