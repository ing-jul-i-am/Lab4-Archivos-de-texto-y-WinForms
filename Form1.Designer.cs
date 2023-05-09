namespace Lab4_Archivos_de_texto_y_WinForms
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.centroEducativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroEducativoToolStripMenuItem,
            this.estudianteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // centroEducativoToolStripMenuItem
            // 
            this.centroEducativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.modificarOEliminarToolStripMenuItem});
            this.centroEducativoToolStripMenuItem.Name = "centroEducativoToolStripMenuItem";
            this.centroEducativoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.centroEducativoToolStripMenuItem.Text = "Centro Educativo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // modificarOEliminarToolStripMenuItem
            // 
            this.modificarOEliminarToolStripMenuItem.Name = "modificarOEliminarToolStripMenuItem";
            this.modificarOEliminarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modificarOEliminarToolStripMenuItem.Text = "Modificar o Eliminar";
            this.modificarOEliminarToolStripMenuItem.Click += new System.EventHandler(this.modificarOEliminarToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.estudianteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 162);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Centro Educativo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem centroEducativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
    }
}

