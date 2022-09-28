namespace pryGordillo2
{
    partial class frmCliente
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
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.mrcDatosCliente = new System.Windows.Forms.GroupBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mrcDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(14, 34);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(143, 20);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Location = new System.Drawing.Point(165, 32);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(211, 26);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // mrcDatosCliente
            // 
            this.mrcDatosCliente.Controls.Add(this.cmdBorrar);
            this.mrcDatosCliente.Controls.Add(this.cmdCargar);
            this.mrcDatosCliente.Controls.Add(this.txtNombreCliente);
            this.mrcDatosCliente.Controls.Add(this.lblNombreCliente);
            this.mrcDatosCliente.Location = new System.Drawing.Point(13, 14);
            this.mrcDatosCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcDatosCliente.Name = "mrcDatosCliente";
            this.mrcDatosCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcDatosCliente.Size = new System.Drawing.Size(414, 155);
            this.mrcDatosCliente.TabIndex = 4;
            this.mrcDatosCliente.TabStop = false;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(18, 89);
            this.cmdBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(139, 40);
            this.cmdBorrar.TabIndex = 5;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(230, 89);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(139, 40);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(444, 188);
            this.Controls.Add(this.mrcDatosCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.mrcDatosCliente.ResumeLayout(false);
            this.mrcDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.GroupBox mrcDatosCliente;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdBorrar;
    }
}