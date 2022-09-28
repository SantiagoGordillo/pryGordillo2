namespace pryGordillo2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.cmdRegistrarVentas = new System.Windows.Forms.Button();
            this.cmdRegistrarVendedor = new System.Windows.Forms.Button();
            this.cmdRegistrarCliente = new System.Windows.Forms.Button();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.cmdVentasConsultas = new System.Windows.Forms.Button();
            this.cmdVendedorConsulta = new System.Windows.Forms.Button();
            this.cmdClienteConsulta = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabRegistrar);
            this.tabMenu.Controls.Add(this.tabConsultar);
            this.tabMenu.Location = new System.Drawing.Point(44, 5);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(220, 272);
            this.tabMenu.TabIndex = 0;
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.cmdRegistrarVentas);
            this.tabRegistrar.Controls.Add(this.cmdRegistrarVendedor);
            this.tabRegistrar.Controls.Add(this.cmdRegistrarCliente);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 29);
            this.tabRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRegistrar.Size = new System.Drawing.Size(212, 239);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrarVentas
            // 
            this.cmdRegistrarVentas.Location = new System.Drawing.Point(38, 160);
            this.cmdRegistrarVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdRegistrarVentas.Name = "cmdRegistrarVentas";
            this.cmdRegistrarVentas.Size = new System.Drawing.Size(129, 44);
            this.cmdRegistrarVentas.TabIndex = 2;
            this.cmdRegistrarVentas.Text = "Ventas";
            this.cmdRegistrarVentas.UseVisualStyleBackColor = true;
            this.cmdRegistrarVentas.Click += new System.EventHandler(this.cmdRegistrarVentas_Click);
            // 
            // cmdRegistrarVendedor
            // 
            this.cmdRegistrarVendedor.Location = new System.Drawing.Point(38, 92);
            this.cmdRegistrarVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdRegistrarVendedor.Name = "cmdRegistrarVendedor";
            this.cmdRegistrarVendedor.Size = new System.Drawing.Size(129, 44);
            this.cmdRegistrarVendedor.TabIndex = 1;
            this.cmdRegistrarVendedor.Text = "Vendedor";
            this.cmdRegistrarVendedor.UseVisualStyleBackColor = true;
            this.cmdRegistrarVendedor.Click += new System.EventHandler(this.cmdRegistrarVendedor_Click);
            // 
            // cmdRegistrarCliente
            // 
            this.cmdRegistrarCliente.Location = new System.Drawing.Point(38, 24);
            this.cmdRegistrarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdRegistrarCliente.Name = "cmdRegistrarCliente";
            this.cmdRegistrarCliente.Size = new System.Drawing.Size(129, 44);
            this.cmdRegistrarCliente.TabIndex = 0;
            this.cmdRegistrarCliente.Text = "Cliente";
            this.cmdRegistrarCliente.UseVisualStyleBackColor = true;
            this.cmdRegistrarCliente.Click += new System.EventHandler(this.cmdRegistrarCliente_Click);
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.cmdVentasConsultas);
            this.tabConsultar.Controls.Add(this.cmdVendedorConsulta);
            this.tabConsultar.Controls.Add(this.cmdClienteConsulta);
            this.tabConsultar.Location = new System.Drawing.Point(4, 29);
            this.tabConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConsultar.Size = new System.Drawing.Size(212, 239);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdVentasConsultas
            // 
            this.cmdVentasConsultas.Location = new System.Drawing.Point(38, 157);
            this.cmdVentasConsultas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdVentasConsultas.Name = "cmdVentasConsultas";
            this.cmdVentasConsultas.Size = new System.Drawing.Size(128, 45);
            this.cmdVentasConsultas.TabIndex = 5;
            this.cmdVentasConsultas.Text = "Ventas";
            this.cmdVentasConsultas.UseVisualStyleBackColor = true;
            this.cmdVentasConsultas.Click += new System.EventHandler(this.cmdVentasConsultas_Click);
            // 
            // cmdVendedorConsulta
            // 
            this.cmdVendedorConsulta.Location = new System.Drawing.Point(38, 87);
            this.cmdVendedorConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdVendedorConsulta.Name = "cmdVendedorConsulta";
            this.cmdVendedorConsulta.Size = new System.Drawing.Size(128, 45);
            this.cmdVendedorConsulta.TabIndex = 4;
            this.cmdVendedorConsulta.Text = "Vendedor";
            this.cmdVendedorConsulta.UseVisualStyleBackColor = true;
            this.cmdVendedorConsulta.Click += new System.EventHandler(this.cmdVendedorConsulta_Click);
            // 
            // cmdClienteConsulta
            // 
            this.cmdClienteConsulta.Location = new System.Drawing.Point(38, 22);
            this.cmdClienteConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClienteConsulta.Name = "cmdClienteConsulta";
            this.cmdClienteConsulta.Size = new System.Drawing.Size(128, 45);
            this.cmdClienteConsulta.TabIndex = 3;
            this.cmdClienteConsulta.Text = "Cliente";
            this.cmdClienteConsulta.UseVisualStyleBackColor = true;
            this.cmdClienteConsulta.Click += new System.EventHandler(this.cmdClienteConsulta_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(314, 298);
            this.Controls.Add(this.tabMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.tabMenu.ResumeLayout(false);
            this.tabRegistrar.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.Button cmdRegistrarVentas;
        private System.Windows.Forms.Button cmdRegistrarVendedor;
        private System.Windows.Forms.Button cmdRegistrarCliente;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.Button cmdVentasConsultas;
        private System.Windows.Forms.Button cmdVendedorConsulta;
        private System.Windows.Forms.Button cmdClienteConsulta;
    }
}

