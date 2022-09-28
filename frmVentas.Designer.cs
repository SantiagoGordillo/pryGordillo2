namespace pryGordillo2
{
    partial class frmVentas
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
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lstVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lstCliente = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstFactura = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtMonto);
            this.mrcDatos.Controls.Add(this.cmdBorrar);
            this.mrcDatos.Controls.Add(this.lstVendedor);
            this.mrcDatos.Controls.Add(this.lblVendedor);
            this.mrcDatos.Controls.Add(this.lblMonto);
            this.mrcDatos.Controls.Add(this.lstCliente);
            this.mrcDatos.Controls.Add(this.dtpFecha);
            this.mrcDatos.Controls.Add(this.lstFactura);
            this.mrcDatos.Controls.Add(this.lblFecha);
            this.mrcDatos.Controls.Add(this.lblCliente);
            this.mrcDatos.Controls.Add(this.cmdCargar);
            this.mrcDatos.Controls.Add(this.lblFactura);
            this.mrcDatos.Location = new System.Drawing.Point(9, 5);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcDatos.Size = new System.Drawing.Size(524, 309);
            this.mrcDatos.TabIndex = 6;
            this.mrcDatos.TabStop = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(190, 226);
            this.txtMonto.Mask = "99999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(122, 26);
            this.txtMonto.TabIndex = 20;
            this.txtMonto.ValidatingType = typeof(int);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(256, 263);
            this.cmdBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(124, 32);
            this.cmdBorrar.TabIndex = 18;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // lstVendedor
            // 
            this.lstVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.Location = new System.Drawing.Point(190, 172);
            this.lstVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(122, 28);
            this.lstVendedor.TabIndex = 17;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(21, 182);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(79, 20);
            this.lblVendedor.TabIndex = 14;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(21, 229);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(54, 20);
            this.lblMonto.TabIndex = 13;
            this.lblMonto.Text = "Monto";
            // 
            // lstCliente
            // 
            this.lstCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(190, 123);
            this.lstCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(122, 28);
            this.lstCliente.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(190, 75);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(314, 26);
            this.dtpFecha.TabIndex = 11;
            // 
            // lstFactura
            // 
            this.lstFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstFactura.FormattingEnabled = true;
            this.lstFactura.Items.AddRange(new object[] {
            "Factura A",
            "Factura B",
            "Factura C",
            "Factura M",
            "Factura E",
            "Factura T",
            ""});
            this.lstFactura.Location = new System.Drawing.Point(190, 26);
            this.lstFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(122, 28);
            this.lstFactura.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(21, 86);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(21, 134);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(390, 263);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(124, 32);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(21, 38);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(64, 20);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(543, 315);
            this.Controls.Add(this.mrcDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.ComboBox lstFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox lstVendedor;
        public System.Windows.Forms.ComboBox lstCliente;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.MaskedTextBox txtMonto;
    }
}