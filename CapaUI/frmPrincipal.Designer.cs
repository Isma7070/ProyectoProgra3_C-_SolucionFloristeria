namespace CapaUI
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeRepartosADomicilioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCostosPreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenciónAlClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envíosADomicilioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.reportesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAInicioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // volverAInicioToolStripMenuItem
            // 
            this.volverAInicioToolStripMenuItem.Name = "volverAInicioToolStripMenuItem";
            this.volverAInicioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.volverAInicioToolStripMenuItem.Text = "Volver a inicio";
            this.volverAInicioToolStripMenuItem.Click += new System.EventHandler(this.volverAInicioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeProductosToolStripMenuItem,
            this.mantenimientoDeToolStripMenuItem,
            this.gestiónDeRepartosADomicilioToolStripMenuItem,
            this.gestiónDeProveedoresToolStripMenuItem,
            this.gestionDeCostosPreciosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.mantenimientosToolStripMenuItem.Text = "Administracion";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // mantenimientoDeProductosToolStripMenuItem
            // 
            this.mantenimientoDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialesToolStripMenuItem,
            this.productoFinalToolStripMenuItem});
            this.mantenimientoDeProductosToolStripMenuItem.Name = "mantenimientoDeProductosToolStripMenuItem";
            this.mantenimientoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.mantenimientoDeProductosToolStripMenuItem.Text = "Gestión de Productos";
            // 
            // materialesToolStripMenuItem
            // 
            this.materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            this.materialesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.materialesToolStripMenuItem.Text = "Materiales";
            this.materialesToolStripMenuItem.Click += new System.EventHandler(this.materialesToolStripMenuItem_Click);
            // 
            // productoFinalToolStripMenuItem
            // 
            this.productoFinalToolStripMenuItem.Name = "productoFinalToolStripMenuItem";
            this.productoFinalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.productoFinalToolStripMenuItem.Text = "Producto Final";
            this.productoFinalToolStripMenuItem.Click += new System.EventHandler(this.productoFinalToolStripMenuItem_Click);
            // 
            // mantenimientoDeToolStripMenuItem
            // 
            this.mantenimientoDeToolStripMenuItem.Name = "mantenimientoDeToolStripMenuItem";
            this.mantenimientoDeToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.mantenimientoDeToolStripMenuItem.Text = "Gestión de Clientes";
            this.mantenimientoDeToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeToolStripMenuItem_Click);
            // 
            // gestiónDeRepartosADomicilioToolStripMenuItem
            // 
            this.gestiónDeRepartosADomicilioToolStripMenuItem.Name = "gestiónDeRepartosADomicilioToolStripMenuItem";
            this.gestiónDeRepartosADomicilioToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.gestiónDeRepartosADomicilioToolStripMenuItem.Text = "Gestión de Encargos y Repartos a Domicilio";
            this.gestiónDeRepartosADomicilioToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeRepartosADomicilioToolStripMenuItem_Click);
            // 
            // gestiónDeProveedoresToolStripMenuItem
            // 
            this.gestiónDeProveedoresToolStripMenuItem.Name = "gestiónDeProveedoresToolStripMenuItem";
            this.gestiónDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.gestiónDeProveedoresToolStripMenuItem.Text = "Gestión de Proveedores";
            this.gestiónDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeProveedoresToolStripMenuItem_Click);
            // 
            // gestionDeCostosPreciosToolStripMenuItem
            // 
            this.gestionDeCostosPreciosToolStripMenuItem.Name = "gestionDeCostosPreciosToolStripMenuItem";
            this.gestionDeCostosPreciosToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.gestionDeCostosPreciosToolStripMenuItem.Text = "Gestion de Costos/Precios";
            this.gestionDeCostosPreciosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCostosPreciosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atenciónAlClienteToolStripMenuItem,
            this.envíosADomicilioToolStripMenuItem,
            this.encargosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.reportesToolStripMenuItem.Text = "Ventas";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // atenciónAlClienteToolStripMenuItem
            // 
            this.atenciónAlClienteToolStripMenuItem.Name = "atenciónAlClienteToolStripMenuItem";
            this.atenciónAlClienteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.atenciónAlClienteToolStripMenuItem.Text = "Atención al Cliente";
            // 
            // envíosADomicilioToolStripMenuItem
            // 
            this.envíosADomicilioToolStripMenuItem.Name = "envíosADomicilioToolStripMenuItem";
            this.envíosADomicilioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.envíosADomicilioToolStripMenuItem.Text = "Envíos a Domicilio";
            // 
            // encargosToolStripMenuItem
            // 
            this.encargosToolStripMenuItem.Name = "encargosToolStripMenuItem";
            this.encargosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.encargosToolStripMenuItem.Text = "Encargos";
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 465);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floristería UTN";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeRepartosADomicilioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCostosPreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atenciónAlClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envíosADomicilioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoFinalToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}