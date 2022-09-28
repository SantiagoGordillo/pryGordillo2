namespace pryGordillo2
{
    partial class frmConsultaCliente
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
            this.grlCliente = new System.Windows.Forms.DataGridView();
            this.dgvCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grlCliente
            // 
            this.grlCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grlCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCliente,
            this.dgvNombreCliente});
            this.grlCliente.Enabled = false;
            this.grlCliente.Location = new System.Drawing.Point(18, 18);
            this.grlCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grlCliente.Name = "grlCliente";
            this.grlCliente.RowHeadersWidth = 62;
            this.grlCliente.Size = new System.Drawing.Size(620, 317);
            this.grlCliente.TabIndex = 0;
            // 
            // dgvCliente
            // 
            this.dgvCliente.HeaderText = "Cliente";
            this.dgvCliente.MinimumWidth = 8;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Width = 50;
            // 
            // dgvNombreCliente
            // 
            this.dgvNombreCliente.HeaderText = "Nombre Del Cliente";
            this.dgvNombreCliente.MinimumWidth = 8;
            this.dgvNombreCliente.Name = "dgvNombreCliente";
            this.dgvNombreCliente.Width = 200;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(543, 345);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(94, 38);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(654, 398);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.grlCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaCliente";
            this.Text = "Consulta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.grlCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlCliente;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreCliente;
    }
}