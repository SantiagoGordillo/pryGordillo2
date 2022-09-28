namespace pryGordillo2
{
    partial class frmVendedor
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
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblCobraComsion = new System.Windows.Forms.Label();
            this.nudComision = new System.Windows.Forms.NumericUpDown();
            this.nudActivo = new System.Windows.Forms.NumericUpDown();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.cmdBorrar);
            this.mrcDatos.Controls.Add(this.lblActivo);
            this.mrcDatos.Controls.Add(this.lblCobraComsion);
            this.mrcDatos.Controls.Add(this.nudComision);
            this.mrcDatos.Controls.Add(this.nudActivo);
            this.mrcDatos.Controls.Add(this.cmdCargar);
            this.mrcDatos.Controls.Add(this.txtNombreVendedor);
            this.mrcDatos.Controls.Add(this.lblNombreVendedor);
            this.mrcDatos.Location = new System.Drawing.Point(18, 12);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcDatos.Size = new System.Drawing.Size(416, 223);
            this.mrcDatos.TabIndex = 5;
            this.mrcDatos.TabStop = false;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(200, 178);
            this.cmdBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(99, 35);
            this.cmdBorrar.TabIndex = 9;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(21, 78);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(52, 20);
            this.lblActivo.TabIndex = 8;
            this.lblActivo.Text = "Activo";
            // 
            // lblCobraComsion
            // 
            this.lblCobraComsion.AutoSize = true;
            this.lblCobraComsion.Location = new System.Drawing.Point(21, 128);
            this.lblCobraComsion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCobraComsion.Name = "lblCobraComsion";
            this.lblCobraComsion.Size = new System.Drawing.Size(121, 20);
            this.lblCobraComsion.TabIndex = 7;
            this.lblCobraComsion.Text = "Cobra Comision";
            // 
            // nudComision
            // 
            this.nudComision.InterceptArrowKeys = false;
            this.nudComision.Location = new System.Drawing.Point(194, 117);
            this.nudComision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudComision.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudComision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudComision.Name = "nudComision";
            this.nudComision.Size = new System.Drawing.Size(88, 26);
            this.nudComision.TabIndex = 6;
            this.nudComision.ValueChanged += new System.EventHandler(this.nupComision_ValueChanged);
            // 
            // nudActivo
            // 
            this.nudActivo.InterceptArrowKeys = false;
            this.nudActivo.Location = new System.Drawing.Point(194, 72);
            this.nudActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudActivo.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudActivo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudActivo.Name = "nudActivo";
            this.nudActivo.Size = new System.Drawing.Size(88, 26);
            this.nudActivo.TabIndex = 5;
            this.nudActivo.ValueChanged += new System.EventHandler(this.nupActivo_ValueChanged);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(308, 178);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(99, 35);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreVendedor.Location = new System.Drawing.Point(194, 28);
            this.txtNombreVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(211, 26);
            this.txtNombreVendedor.TabIndex = 3;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(21, 29);
            this.lblNombreVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(164, 20);
            this.lblNombreVendedor.TabIndex = 1;
            this.lblNombreVendedor.Text = "Nombre del Vendedor";
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(453, 251);
            this.Controls.Add(this.mrcDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVendedor";
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudActivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblCobraComsion;
        private System.Windows.Forms.NumericUpDown nudComision;
        private System.Windows.Forms.NumericUpDown nudActivo;
        private System.Windows.Forms.Button cmdBorrar;
    }
}