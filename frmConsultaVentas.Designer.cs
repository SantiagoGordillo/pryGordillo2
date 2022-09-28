namespace pryGordillo2
{
    partial class frmConsultaVentas
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
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.grlVentas = new System.Windows.Forms.DataGridView();
            this.dgvCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grlVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(947, 345);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(94, 38);
            this.cmdConsultar.TabIndex = 5;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // grlVentas
            // 
            this.grlVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCliente,
            this.dgvNombreCliente,
            this.dgvActivo,
            this.dgvComision,
            this.dgvVendedor,
            this.dgvMonto});
            this.grlVentas.Location = new System.Drawing.Point(29, 18);
            this.grlVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grlVentas.Name = "grlVentas";
            this.grlVentas.RowHeadersWidth = 62;
            this.grlVentas.Size = new System.Drawing.Size(1012, 317);
            this.grlVentas.TabIndex = 4;
            // 
            // dgvCliente
            // 
            this.dgvCliente.HeaderText = "Tipo de Factura";
            this.dgvCliente.MinimumWidth = 8;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Width = 70;
            // 
            // dgvNombreCliente
            // 
            this.dgvNombreCliente.HeaderText = "Numero De Factura";
            this.dgvNombreCliente.MinimumWidth = 8;
            this.dgvNombreCliente.Name = "dgvNombreCliente";
            this.dgvNombreCliente.Width = 150;
            // 
            // dgvActivo
            // 
            this.dgvActivo.HeaderText = "Fecha";
            this.dgvActivo.MinimumWidth = 8;
            this.dgvActivo.Name = "dgvActivo";
            this.dgvActivo.ReadOnly = true;
            this.dgvActivo.Width = 200;
            // 
            // dgvComision
            // 
            this.dgvComision.HeaderText = "Cliente";
            this.dgvComision.MinimumWidth = 8;
            this.dgvComision.Name = "dgvComision";
            this.dgvComision.ReadOnly = true;
            this.dgvComision.Width = 50;
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.HeaderText = "Vendedor";
            this.dgvVendedor.MinimumWidth = 8;
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.Width = 150;
            // 
            // dgvMonto
            // 
            this.dgvMonto.HeaderText = "Monto";
            this.dgvMonto.MinimumWidth = 8;
            this.dgvMonto.Name = "dgvMonto";
            this.dgvMonto.Width = 150;
            // 
            // frmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1066, 389);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.grlVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaVentas";
            this.Text = "Consulta Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.grlVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridView grlVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMonto;
    }
}