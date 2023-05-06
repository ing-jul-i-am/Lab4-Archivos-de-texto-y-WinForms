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
    public partial class frmCentroEducativoNuevo : Form
    {
        public frmCentroEducativoNuevo()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Busqueda del ultimo id ingresado
            StreamReader archivoLeido = File.OpenText("centro_educativo.txt");
            string cadena = archivoLeido.ReadLine();
            string[] registro = new string[4];
            int ultimoID = 0;

            while (cadena != null)
            {
                registro = cadena.Split('|');
                ultimoID = Convert.ToInt32(registro[0])+1;
                cadena = archivoLeido.ReadLine();
            }
            archivoLeido.Close();
            
            //Escritura del archivo
            StreamWriter archivo = File.AppendText("centro_educativo.txt");
            archivo.WriteLine(ultimoID + "|" + txtNombre.Text + "|" + txtDireccion.Text + "|" + txtTelefono.Text);
            archivo.Close();
            MessageBox.Show("Registro guardado exitosamente!");

            //Limpiamos las cajas de texto
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();

        }
    }
}
