namespace Lab4_Archivos_de_texto_y_WinForms
{
    partial class frmEstudiante
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxNuevo = new System.Windows.Forms.GroupBox();
            this.btnResetNuevo = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.txtIdBuscar = new System.Windows.Forms.TextBox();
            this.btnResetBuscar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxModificar = new System.Windows.Forms.GroupBox();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.btnResetModificar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbxEliminar = new System.Windows.Forms.GroupBox();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.btnResetEliminar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.gbxNuevo.SuspendLayout();
            this.gbxBuscar.SuspendLayout();
            this.gbxModificar.SuspendLayout();
            this.gbxEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(115, 111);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(215, 20);
            this.txtTelefono.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 85);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(215, 20);
            this.txtDireccion.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 20);
            this.txtNombre.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha de nacimiento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Genero";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbxGenero.Location = new System.Drawing.Point(115, 166);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(121, 21);
            this.cbxGenero.Sorted = true;
            this.cbxGenero.TabIndex = 33;
            this.cbxGenero.SelectedIndexChanged += new System.EventHandler(this.cbxGenero_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // gbxNuevo
            // 
            this.gbxNuevo.Controls.Add(this.btnResetNuevo);
            this.gbxNuevo.Controls.Add(this.btnNuevo);
            this.gbxNuevo.Location = new System.Drawing.Point(353, 37);
            this.gbxNuevo.Name = "gbxNuevo";
            this.gbxNuevo.Size = new System.Drawing.Size(319, 52);
            this.gbxNuevo.TabIndex = 35;
            this.gbxNuevo.TabStop = false;
            this.gbxNuevo.Text = "Nuevo registro";
            this.gbxNuevo.Visible = false;
            this.gbxNuevo.Enter += new System.EventHandler(this.gbxNuevo_Enter);
            // 
            // btnResetNuevo
            // 
            this.btnResetNuevo.Location = new System.Drawing.Point(104, 20);
            this.btnResetNuevo.Name = "btnResetNuevo";
            this.btnResetNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnResetNuevo.TabIndex = 1;
            this.btnResetNuevo.Text = "Reset";
            this.btnResetNuevo.UseVisualStyleBackColor = true;
            this.btnResetNuevo.Click += new System.EventHandler(this.btnResetNuevo_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(21, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Ingresar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.txtIdBuscar);
            this.gbxBuscar.Controls.Add(this.btnResetBuscar);
            this.gbxBuscar.Controls.Add(this.btnBuscar);
            this.gbxBuscar.Location = new System.Drawing.Point(353, 101);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(319, 52);
            this.gbxBuscar.TabIndex = 36;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Buscar estudiantes por ID";
            this.gbxBuscar.Visible = false;
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.Location = new System.Drawing.Point(18, 21);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtIdBuscar.TabIndex = 2;
            // 
            // btnResetBuscar
            // 
            this.btnResetBuscar.Location = new System.Drawing.Point(212, 19);
            this.btnResetBuscar.Name = "btnResetBuscar";
            this.btnResetBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnResetBuscar.TabIndex = 4;
            this.btnResetBuscar.Text = "Reset";
            this.btnResetBuscar.UseVisualStyleBackColor = true;
            this.btnResetBuscar.Click += new System.EventHandler(this.btnResetBuscar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(129, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxModificar
            // 
            this.gbxModificar.Controls.Add(this.txtIdMod);
            this.gbxModificar.Controls.Add(this.btnResetModificar);
            this.gbxModificar.Controls.Add(this.btnModificar);
            this.gbxModificar.Location = new System.Drawing.Point(353, 159);
            this.gbxModificar.Name = "gbxModificar";
            this.gbxModificar.Size = new System.Drawing.Size(319, 52);
            this.gbxModificar.TabIndex = 37;
            this.gbxModificar.TabStop = false;
            this.gbxModificar.Text = "Modificar registro estudiantil";
            this.gbxModificar.Visible = false;
            // 
            // txtIdMod
            // 
            this.txtIdMod.Location = new System.Drawing.Point(18, 21);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.Size = new System.Drawing.Size(100, 20);
            this.txtIdMod.TabIndex = 2;
            // 
            // btnResetModificar
            // 
            this.btnResetModificar.Location = new System.Drawing.Point(212, 19);
            this.btnResetModificar.Name = "btnResetModificar";
            this.btnResetModificar.Size = new System.Drawing.Size(75, 23);
            this.btnResetModificar.TabIndex = 1;
            this.btnResetModificar.Text = "Reset";
            this.btnResetModificar.UseVisualStyleBackColor = true;
            this.btnResetModificar.Click += new System.EventHandler(this.btnResetModificar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(129, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // gbxEliminar
            // 
            this.gbxEliminar.Controls.Add(this.txtIdEliminar);
            this.gbxEliminar.Controls.Add(this.btnResetEliminar);
            this.gbxEliminar.Controls.Add(this.btnEliminar);
            this.gbxEliminar.Location = new System.Drawing.Point(353, 217);
            this.gbxEliminar.Name = "gbxEliminar";
            this.gbxEliminar.Size = new System.Drawing.Size(319, 52);
            this.gbxEliminar.TabIndex = 38;
            this.gbxEliminar.TabStop = false;
            this.gbxEliminar.Text = "Eiliminar registro";
            this.gbxEliminar.Visible = false;
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(18, 21);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdEliminar.TabIndex = 2;
            // 
            // btnResetEliminar
            // 
            this.btnResetEliminar.Location = new System.Drawing.Point(212, 19);
            this.btnResetEliminar.Name = "btnResetEliminar";
            this.btnResetEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnResetEliminar.TabIndex = 1;
            this.btnResetEliminar.Text = "Reset";
            this.btnResetEliminar.UseVisualStyleBackColor = true;
            this.btnResetEliminar.Click += new System.EventHandler(this.btnResetEliminar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(129, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(115, 137);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 39;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 277);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.gbxEliminar);
            this.Controls.Add(this.gbxModificar);
            this.Controls.Add(this.gbxBuscar);
            this.Controls.Add(this.gbxNuevo);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstudiante";
            this.Text = "Estudiante - Centro educativo";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxNuevo.ResumeLayout(false);
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            this.gbxModificar.ResumeLayout(false);
            this.gbxModificar.PerformLayout();
            this.gbxEliminar.ResumeLayout(false);
            this.gbxEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxNuevo;
        private System.Windows.Forms.Button btnResetNuevo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.TextBox txtIdBuscar;
        private System.Windows.Forms.Button btnResetBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxModificar;
        private System.Windows.Forms.TextBox txtIdMod;
        private System.Windows.Forms.Button btnResetModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbxEliminar;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Button btnResetEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
    }
}