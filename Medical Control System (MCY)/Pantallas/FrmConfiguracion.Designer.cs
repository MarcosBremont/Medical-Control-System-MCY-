namespace Medical_Control_System__MCY_.Pantallas
{
    partial class FrmConfiguracion
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
            this.CbModoDia = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CbModoDia
            // 
            this.CbModoDia.AutoSize = true;
            this.CbModoDia.Checked = true;
            this.CbModoDia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbModoDia.Location = new System.Drawing.Point(18, 15);
            this.CbModoDia.Name = "CbModoDia";
            this.CbModoDia.Size = new System.Drawing.Size(74, 17);
            this.CbModoDia.TabIndex = 1;
            this.CbModoDia.Text = "Modo Día";
            this.CbModoDia.UseVisualStyleBackColor = true;
            this.CbModoDia.CheckedChanged += new System.EventHandler(this.CbModoDia_CheckedChanged);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 78);
            this.Controls.Add(this.CbModoDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbModoDia;
    }
}