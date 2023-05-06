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
    public partial class frmCentroEducativoModDel : Form
    {
        public frmCentroEducativoModDel()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Abrimos el archivo de texto para leerlo.
            StreamReader archivo = File.OpenText("centro_educativo.txt");
            string cadena = archivo.ReadLine();
            string[] registro = new string[4];
            bool encontrado = false;

            while (cadena != null)
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
                MessageBox.Show("Registro no encontrado.");
                txtID.Focus();
            }
            archivo.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtID.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Se comprueba si los campos contienen datos a guardar o estan vacios
            if (txtNombre.Text=="" && txtDireccion.Text == "" && txtTelefono.Text == "")
            {
                //Los campos estan vacios y se presiono modificar.
                MessageBox.Show("Si deseas eliminar el registro, presiona 'Eliminar'.", "Campos vacios");
            } else
            {
                //Los campos no estan vacios por lo que hay que modificar el registro.

                //Abrimos el archivo de texto para leerlo y encontrar el registro.
                StreamReader archivo = File.OpenText("centro_educativo.txt");
                string cadena = archivo.ReadLine();
                string[] registro = new string[4];
                bool encontrado = false;
                //variable que va a guardar el archivo modificado 
                string temporal = ""; 

                while (cadena != null && encontrado==false)
                {
                    registro = cadena.Split('|');
                    if (registro[0] == txtID.Text)
                    {
                        //Copiamos lo nuevo en el temporal
                        temporal += registro[0] + "|" + txtNombre.Text + "|" + txtDireccion.Text + "|" + txtTelefono.Text + "\n";
                        temporal += archivo.ReadToEnd(); 
                        encontrado = true;
                    } else
                    {
                        temporal += cadena + "\n";
                    }
                    cadena = archivo.ReadLine();
                }

                archivo.Close();

                if (encontrado == false)
                {
                    MessageBox.Show("Registro no encontrado.");
                    txtID.Focus();
                    
                } else
                {
                    File.Delete("centro_educativo.txt");
                    StreamWriter nuevo = File.AppendText("centro_educativo.txt");
                    nuevo.Write(temporal);
                    nuevo.Close();
                    MessageBox.Show("Registro actualizado exitosamente!");
                }
                
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Abrimos el archivo de texto para leerlo.
            StreamReader archivo = File.OpenText("centro_educativo.txt");
            string cadena = archivo.ReadLine();
            string[] registro = new string[4];
            bool encontrado = false, arrepentido=false;
            int ultimoID = 0;
            string temporal = "";

            while (cadena != null && encontrado == false)
            {
                registro = cadena.Split('|');
                if (registro[0] == txtID.Text)
                {
                    encontrado = true;
                    DialogResult confirmacion = MessageBox.Show(cadena.Replace("|", " "), "Desea eliminar el registro?", MessageBoxButtons.YesNo);
                    if (confirmacion == DialogResult.Yes)
                    {
                        //El registro no se copia en la cadena pero se guarda el ultimoID
                        ultimoID = Convert.ToInt32(registro[0]);
                        cadena = archivo.ReadLine();
                        while(cadena != null)
                        {
                            registro = cadena.Split('|');
                            temporal += ultimoID + "|" + registro[1] + "|" + registro[2] + "|" + registro[3] + "\n";
                            ultimoID++;
                            cadena = archivo.ReadLine();
                        }
                    } else
                    {
                        //No lo quiere guardar
                        arrepentido = true;
                        break;
                    }
                    
                }
                if (encontrado == false)
                {
                    temporal += cadena + "\n";
                    cadena = archivo.ReadLine();
                }
            }
            archivo.Close();

            if (encontrado == false)
            {
                MessageBox.Show("Registro no encontrado.");
                txtID.Focus();
            } else
            {
                //Se verifica si el cliente se arrepintio de borrar el registro
                //a ultimo momento
                if (arrepentido == false)
                {
                    File.Delete("centro_educativo.txt");
                    StreamWriter nuevo = File.AppendText("centro_educativo.txt");
                    nuevo.Write(temporal);
                    nuevo.Close();
                }
                
            }
            
        }
    }
}
