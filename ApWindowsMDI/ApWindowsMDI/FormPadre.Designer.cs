namespace ApWindowsMDI
{
    partial class FormPadre
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOtro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArchivo,
            this.MenuVentana,
            this.MenuOtro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuArchivo
            // 
            this.MenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoNuevo,
            this.ArchivoCerrar,
            this.toolStripSeparator1,
            this.ArchivoSalir});
            this.MenuArchivo.Name = "MenuArchivo";
            this.MenuArchivo.Size = new System.Drawing.Size(70, 20);
            this.MenuArchivo.Text = "ARCHIVO";
            // 
            // ArchivoNuevo
            // 
            this.ArchivoNuevo.Name = "ArchivoNuevo";
            this.ArchivoNuevo.Size = new System.Drawing.Size(152, 22);
            this.ArchivoNuevo.Text = "NUEVO";
            this.ArchivoNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
            // 
            // MenuVentana
            // 
            this.MenuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentanaCascada,
            this.VentanaHorizontal,
            this.VentanaVertical});
            this.MenuVentana.Name = "MenuVentana";
            this.MenuVentana.Size = new System.Drawing.Size(72, 20);
            this.MenuVentana.Text = "VENTANA";
            // 
            // ArchivoCerrar
            // 
            this.ArchivoCerrar.Name = "ArchivoCerrar";
            this.ArchivoCerrar.Size = new System.Drawing.Size(152, 22);
            this.ArchivoCerrar.Text = "CERRAR";
            this.ArchivoCerrar.Click += new System.EventHandler(this.ArchivoCerrar_Click);
            // 
            // ArchivoSalir
            // 
            this.ArchivoSalir.Name = "ArchivoSalir";
            this.ArchivoSalir.Size = new System.Drawing.Size(152, 22);
            this.ArchivoSalir.Text = "SALIR";
            this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
            // 
            // VentanaCascada
            // 
            this.VentanaCascada.Name = "VentanaCascada";
            this.VentanaCascada.Size = new System.Drawing.Size(152, 22);
            this.VentanaCascada.Text = "CASCADA";
            this.VentanaCascada.Click += new System.EventHandler(this.VentanaCascada_Click);
            // 
            // VentanaHorizontal
            // 
            this.VentanaHorizontal.Name = "VentanaHorizontal";
            this.VentanaHorizontal.Size = new System.Drawing.Size(152, 22);
            this.VentanaHorizontal.Text = "HORIZONTAL";
            this.VentanaHorizontal.Click += new System.EventHandler(this.VentanaHorizontal_Click);
            // 
            // VentanaVertical
            // 
            this.VentanaVertical.Name = "VentanaVertical";
            this.VentanaVertical.Size = new System.Drawing.Size(152, 22);
            this.VentanaVertical.Text = "VERTICAL";
            this.VentanaVertical.Click += new System.EventHandler(this.VentanaVertical_Click);
            // 
            // MenuOtro
            // 
            this.MenuOtro.Name = "MenuOtro";
            this.MenuOtro.Size = new System.Drawing.Size(86, 20);
            this.MenuOtro.Text = "OTRO FORM";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 418);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPadre";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem ArchivoNuevo;
        private System.Windows.Forms.ToolStripMenuItem ArchivoCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuVentana;
        private System.Windows.Forms.ToolStripMenuItem VentanaCascada;
        private System.Windows.Forms.ToolStripMenuItem VentanaHorizontal;
        private System.Windows.Forms.ToolStripMenuItem VentanaVertical;
        private System.Windows.Forms.ToolStripMenuItem MenuOtro;
    }
}

