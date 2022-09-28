using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryGordillo2
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {

            File.Delete("./Clientes.txt");
            MessageBox.Show("Archivo Eliminado");

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {

            string cliente;
            int codigoId = 1;
            cliente = txtNombreCliente.Text;

            //controla los campos vacios 
            if (cliente != "")
            {
                if (File.Exists("./Clientes.txt"))
                {

                    char separador = Convert.ToChar(",");
                    //lectura del archivo 
                    StreamReader srClientes = new StreamReader("./Clientes.txt");
                    //distinto a final de archivo 
                    while (!srClientes.EndOfStream)
                    {
                        //asignacion automatica 
                        string[] vecClientes = srClientes.ReadLine().Split(separador);
                        int vecID = Convert.ToInt32(vecClientes[1]);
                        codigoId = vecID + 1;

                    }

                    srClientes.Close();

                }

                //evitar que se sobrescriba el archivo
                StreamWriter swCliente = File.AppendText("./Clientes.txt");
                swCliente.WriteLine(cliente + "," + codigoId);

                MessageBox.Show("Carga Realizada");

                txtNombreCliente.Text = "";

                swCliente.Close();
            }
            else
            {

                MessageBox.Show("Complete con los datos, por favor ");

            }
        }
    }
}
