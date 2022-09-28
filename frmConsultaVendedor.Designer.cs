namespace pryGordillo2
{
    partial class frmConsultaVendedor
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
            this.grlVendedor = new System.Windows.Forms.DataGridView();
            this.dgvCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grlVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(502, 345);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(94, 38);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // grlVendedor
            // 
            this.grlVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCliente,
            this.dgvNombreCliente,
            this.dgvActivo,
            this.dgvComision});
            this.grlVendedor.Location = new System.Drawing.Point(18, 18);
            this.grlVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grlVendedor.Name = "grlVendedor";
            this.grlVendedor.RowHeadersWidth = 62;
            this.grlVendedor.Size = new System.Drawing.Size(578, 317);
            this.grlVendedor.TabIndex = 2;
            // 
            // dgvCliente
            // 
            this.dgvCliente.HeaderText = "Vendedor";
            this.dgvCliente.MinimumWidth = 8;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Width = 70;
            // 
            // dgvNombreCliente
            // 
            this.dgvNombreCliente.HeaderText = "Nombre Del Vendedor";
            this.dgvNombreCliente.MinimumWidth = 8;
            this.dgvNombreCliente.Name = "dgvNombreCliente";
            this.dgvNombreCliente.Width = 200;
            // 
            // dgvActivo
            // 
            this.dgvActivo.HeaderText = "Activo";
            this.dgvActivo.MinimumWidth = 8;
            this.dgvActivo.Name = "dgvActivo";
            this.dgvActivo.ReadOnly = true;
            this.dgvActivo.Width = 50;
            // 
            // dgvComision
            // 
            this.dgvComision.HeaderText = "Comision";
            this.dgvComision.MinimumWidth = 8;
            this.dgvComision.Name = "dgvComision";
            this.dgvComision.ReadOnly = true;
            this.dgvComision.Width = 70;
            // 
            // frmConsultaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(618, 400);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.grlVendedor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaVendedor";
            this.Text = "Consulta Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.grlVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridView grlVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvComision;
    }
}