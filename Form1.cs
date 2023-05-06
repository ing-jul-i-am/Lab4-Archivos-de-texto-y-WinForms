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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentroEducativoNuevo a = new frmCentroEducativoNuevo();
            a.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentroEducativoBuscar a = new frmCentroEducativoBuscar();
            a.Show();
        }

        private void modificarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentroEducativoModDel a = new frmCentroEducativoModDel();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter centroEducativo = File.AppendText("centro_educativo.txt");
            centroEducativo.Close();
        }
    }
}
