using Lab4_Archivos_de_texto_y_WinForms.Classes;
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

        //Metodo para limpiar las cajas de texto y selectores.
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

        //Metodo del boton buscar por ID
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Se llama a la funcion buscar
            csEstudiante estudiante = Buscar(Convert.ToInt32(txtIdBuscar.Text));

            if(estudiante != null)
            {
                txtNombre.Text = estudiante.nombre;
                txtDireccion.Text = estudiante.direccion;
                txtTelefono.Text = estudiante.telefono;
                dtpNacimiento.Value = Convert.ToDateTime(estudiante.nacimiento);
                cbxGenero.Text = estudiante.genero;
            } else
            {
                MessageBox.Show("No se encontro el estudiante.");
            }
            txtIdBuscar.Focus();
        }

        //Metodo para buscar por ID en general
        //Devuelve un objeto de la clase estudiante.
        private csEstudiante Buscar(int ID)
        {
            //Se abre archivo para su lectura
            StreamReader archivo = File.OpenText("estudiante.txt");

            //variables a utilizar para la busqueda
            string cadena = archivo.ReadLine();
            string[] registro = new string[4];
            bool encontrado = false;
            csEstudiante estudiante = new csEstudiante();

            while(cadena != null && encontrado == false)
            {
                registro = cadena.Split('|');
                if (registro[0] == Convert.ToString(ID))
                {
                    encontrado = true;
                    estudiante.id = Convert.ToInt32(registro[0]);
                    estudiante.nombre = registro[1];
                    estudiante.direccion = registro[2];
                    estudiante.telefono = registro[3];
                    estudiante.nacimiento = registro[4];
                    estudiante.genero = registro[5];
                } else
                {
                    cadena = archivo.ReadLine();
                }
            }

            archivo.Close();
            if (encontrado == true)
            {
                return estudiante;
            } else
            {
                return null;
            }
            

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

        //Metodo para ingresar registros
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Se abre el documento de texto para su lectura
            StreamReader archivoLectura = File.OpenText("estudiante.txt");

            //Buscar el ultimo ID ingresado
            int ultimoId = UltimoIdIngresado(archivoLectura);
            archivoLectura.Close();

            //Se abre el documento de texto para su edicion.
            StreamWriter archivo = File.AppendText("estudiante.txt");

            //Ingresamos el ultimo registro
            ultimoId++;
            archivo.WriteLine(ultimoId.ToString() + "|" + txtNombre.Text + "|" 
                + txtDireccion.Text + "|" + txtTelefono.Text + "|" 
                + dtpNacimiento.Value.ToShortDateString() + "|" + cbxGenero.Text);

            archivo.Close();
            MessageBox.Show("El registro se ha guardado exitosamente! ID = " + ultimoId);
            
        }

        //Metodo para encontrar el ultimo ID/
        private int UltimoIdIngresado(StreamReader archivo)
        {
            string cadena = archivo.ReadLine();
            string[] registro = new string[6];
            bool encontrado = false;
            int ultimoID=0;

            if(cadena != null)
            {
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
                    if (registro[0] == null || registro[0] == "")
                    {
                        encontrado = true;
                    }
                    else
                    {
                        ultimoID = Convert.ToInt32(registro[0]);
                        cadena = archivo.ReadLine();
                    }
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

        private void cbxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
