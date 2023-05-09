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
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se trae el group box al frente, se hace visible y se esconde el resto.
            gbxNuevo.Visible = true;
            gbxNuevo.Location = new Point(11, 208);

            gbxBuscar.Visible = false;
            gbxModificar.Visible = false;
            gbxEliminar.Visible = false;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se trae el group box al frente, se hace visible y se esconde el resto.
            gbxBuscar.Visible = true;
            gbxBuscar.Location = new Point(11, 208);

            gbxNuevo.Visible = false;
            gbxModificar.Visible = false;
            gbxEliminar.Visible = false;
        }

        private void gbxNuevo_Enter(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se trae el group box al frente, se hace visible y se esconde el resto.
            gbxModificar.Visible = true;
            gbxModificar.Location = new Point(11, 208);

            gbxNuevo.Visible = false;
            gbxBuscar.Visible = false;
            gbxEliminar.Visible = false;

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se trae el group box al frente, se hace visible y se esconde el resto.
            gbxEliminar.Visible = true;
            gbxEliminar.Location = new Point(11, 208);

            gbxNuevo.Visible = false;
            gbxBuscar.Visible = false;
            gbxModificar.Visible = false;
        }

        private void Clear()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            dtpNacimiento.Value = DateTime.Now;
            cbxGenero.SelectedItem = null;
        }

        private void btnResetNuevo_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnResetBuscar_Click(object sender, EventArgs e)
        {
            Clear();
            txtIdBuscar.Clear();
        }

        private void btnResetModificar_Click(object sender, EventArgs e)
        {
            Clear();
            txtIdMod.Clear();
        }

        private void btnResetEliminar_Click(object sender, EventArgs e)
        {
            Clear();
            txtIdEliminar.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Se abre el documento de texto para su lectura
            StreamReader archivoLectura = File.OpenText("estudiante.txt");

            //Buscar el ultimo ID ingresado
            int ultimoId = UltimoIdIngresado(archivoLectura);
            archivoLectura.Close();

            //Se abre el documento de texto para su edicion.
            StreamWriter archivo = File.AppendText("estudiante.txt");

            //Ingressamos el ultimo registro
            ultimoId++;
            archivo.WriteLine(ultimoId.ToString() + "|" + txtNombre.Text + "|" 
                + txtDireccion.Text + "|" + txtTelefono.Text + "|" 
                + dtpNacimiento.Value.ToShortDateString() + "|" + cbxGenero.Text);

            archivo.Close();
            MessageBox.Show("El registro se ha guardado exitosamente!");
            
        }

        //Metodo para encontrar el ultimo ID/
        private int UltimoIdIngresado(StreamReader archivo)
        {
            string cadena = archivo.ReadLine();
            string[] registro = new string[6];
            bool encontrado = false;
            int ultimoID=0;

            registro = cadena.Split('|');
            while (cadena != null && encontrado == false)
            {
                try
                {
                    registro = cadena.Split('|');
                }
                catch
                {
                    registro = null;
                }
                if (registro[0]==null || registro[0] == "")
                {
                    encontrado = true;
                } else
                {
                    ultimoID = Convert.ToInt32(registro[0]);
                    cadena = archivo.ReadLine();
                }
            }

            archivo.Close();
            return ultimoID;
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            //Se abre o crea el documento de texto con el que se trabajara.
            StreamWriter archivo = File.AppendText("estudiante.txt");
            archivo.Close();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpNacimiento.Value.ToShortDateString());
        }*/
    }
}
