using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGordillo2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        private void cmdRegistrarVendedor_Click(object sender, EventArgs e)
        {
            frmVendedor frmVendedor = new frmVendedor();
            frmVendedor.ShowDialog();
        }

        private void cmdRegistrarVentas_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.ShowDialog();
        }

        private void cmdClienteConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmConsultaCliente = new frmConsultaCliente();
            frmConsultaCliente.ShowDialog();
        }

        private void cmdVendedorConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaVendedor frmConsultaVendedor = new frmConsultaVendedor();
            frmConsultaVendedor.ShowDialog();
        }

        private void cmdVentasConsultas_Click(object sender, EventArgs e)
        {
            frmConsultaVentas frmConsultaVentas = new frmConsultaVentas();
            frmConsultaVentas.ShowDialog();
        }


    }
}
