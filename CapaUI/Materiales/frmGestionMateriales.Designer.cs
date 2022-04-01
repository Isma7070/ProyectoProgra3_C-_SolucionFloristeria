namespace CapaUI.Materiales
{
    partial class frmGestionMateriales
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
            this.dgvMaterialesActivos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudMinimoStock = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProveedores = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMaterial = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerMaterialesInactivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesActivos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimoStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaterialesActivos
            // 
            this.dgvMaterialesActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesActivos.Location = new System.Drawing.Point(-3, 282);
            this.dgvMaterialesActivos.Name = "dgvMaterialesActivos";
            this.dgvMaterialesActivos.Size = new System.Drawing.Size(787, 205);
            this.dgvMaterialesActivos.TabIndex = 26;
            this.dgvMaterialesActivos.SelectionChanged += new System.EventHandler(this.dgvMaterialesActivos_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudMinimoStock);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboProveedores);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.nudStock);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtPrecioCosto);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIDMaterial);
            this.panel1.Controls.Add(this.chkActivo);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(2, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 240);
            this.panel1.TabIndex = 25;
            // 
            // nudMinimoStock
            // 
            this.nudMinimoStock.Location = new System.Drawing.Point(119, 133);
            this.nudMinimoStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinimoStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinimoStock.Name = "nudMinimoStock";
            this.nudMinimoStock.Size = new System.Drawing.Size(56, 20);
            this.nudMinimoStock.TabIndex = 31;
            this.nudMinimoStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Mínimo en Stock";
            // 
            // cboProveedores
            // 
            this.cboProveedores.FormattingEnabled = true;
            this.cboProveedores.Location = new System.Drawing.Point(119, 162);
            this.cboProveedores.Name = "cboProveedores";
            this.cboProveedores.Size = new System.Drawing.Size(139, 21);
            this.cboProveedores.TabIndex = 29;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(324, 80);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(119, 100);
            this.nudStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(56, 20);
            this.nudStock.TabIndex = 28;
            this.nudStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(324, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Location = new System.Drawing.Point(324, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 72);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "ID del Material";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(17, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(132, 20);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(210, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(119, 68);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(139, 20);
            this.txtPrecioCosto.TabIndex = 22;
            this.txtPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCosto_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio de Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID del Material";
            // 
            // txtIDMaterial
            // 
            this.txtIDMaterial.Location = new System.Drawing.Point(119, 8);
            this.txtIDMaterial.Name = "txtIDMaterial";
            this.txtIDMaterial.Size = new System.Drawing.Size(139, 20);
            this.txtIDMaterial.TabIndex = 2;
            this.txtIDMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDMaterial_KeyPress);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(119, 202);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(119, 37);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(139, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripción";
            // 
            // btnVerMaterialesInactivos
            // 
            this.btnVerMaterialesInactivos.Location = new System.Drawing.Point(650, 15);
            this.btnVerMaterialesInactivos.Name = "btnVerMaterialesInactivos";
            this.btnVerMaterialesInactivos.Size = new System.Drawing.Size(134, 36);
            this.btnVerMaterialesInactivos.TabIndex = 24;
            this.btnVerMaterialesInactivos.Text = "Ver Materiales Inactivos";
            this.btnVerMaterialesInactivos.UseVisualStyleBackColor = true;
            this.btnVerMaterialesInactivos.Click += new System.EventHandler(this.btnVerMaterialesInactivos_Click);
            // 
            // frmGestionMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 500);
            this.Controls.Add(this.dgvMaterialesActivos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerMaterialesInactivos);
            this.Name = "frmGestionMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionMateriales";
            this.Activated += new System.EventHandler(this.frmGestionMateriales_Activated);
            this.Load += new System.EventHandler(this.frmGestionMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesActivos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimoStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterialesActivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMaterial;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerMaterialesInactivos;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.ComboBox cboProveedores;
        private System.Windows.Forms.NumericUpDown nudMinimoStock;
        private System.Windows.Forms.Label label9;
    }
}