using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Archivos_de_texto_y_WinForms
{
    public partial class frmCentroEducativoBuscar : Form
    {
        public frmCentroEducativoBuscar()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Abrimos el archivo de texto para leerlo.
            StreamReader archivo = File.OpenText("centro_educativo.txt");
            string cadena = archivo.ReadLine();
            string[] registro = new string[4];
            bool encontrado = false;

            while(cadena != null && encontrado==false)
            {
                registro = cadena.Split('|');
                if (registro[0] == txtID.Text)
                {
                    txtNombre.Text = registro[1];
                    txtDireccion.Text = registro[2];
                    txtTelefono.Text = registro[3];
                    encontrado = true;
                }
                cadena = archivo.ReadLine();
            }
            if (encontrado == false)
            {
                MessageBox.Show("ID no encontrado");
            }

            txtID.Focus();
            archivo.Close();

        }
    }
}
