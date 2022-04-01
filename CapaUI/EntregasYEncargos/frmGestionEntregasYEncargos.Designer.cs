namespace CapaUI.EntregasYEncargos
{
    partial class frmGestionEntregasYEncargos
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
            this.btnProductosPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkAutorizado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesActivos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaterialesActivos
            // 
            this.dgvMaterialesActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesActivos.Location = new System.Drawing.Point(9, 270);
            this.dgvMaterialesActivos.Name = "dgvMaterialesActivos";
            this.dgvMaterialesActivos.Size = new System.Drawing.Size(873, 213);
            this.dgvMaterialesActivos.TabIndex = 29;
            this.dgvMaterialesActivos.SelectionChanged += new System.EventHandler(this.dgvMaterialesActivos_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProductosPedido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.cboClientes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.chkAutorizado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(14, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 253);
            this.panel1.TabIndex = 28;
            // 
            // btnProductosPedido
            // 
            this.btnProductosPedido.Location = new System.Drawing.Point(378, 161);
            this.btnProductosPedido.Name = "btnProductosPedido";
            this.btnProductosPedido.Size = new System.Drawing.Size(171, 37);
            this.btnProductosPedido.TabIndex = 36;
            this.btnProductosPedido.Text = "Asignar Productos al Pedido";
            this.btnProductosPedido.UseVisualStyleBackColor = true;
            this.btnProductosPedido.Click += new System.EventHandler(this.btnProductosPedido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dirección de la Entrega";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(162, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(189, 74);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(162, 36);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(189, 21);
            this.cboClientes.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cliente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(421, 91);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(421, 27);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 36);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkAutorizado
            // 
            this.chkAutorizado.AutoSize = true;
            this.chkAutorizado.Location = new System.Drawing.Point(162, 216);
            this.chkAutorizado.Name = "chkAutorizado";
            this.chkAutorizado.Size = new System.Drawing.Size(76, 17);
            this.chkAutorizado.TabIndex = 6;
            this.chkAutorizado.Text = "Autorizado";
            this.chkAutorizado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Autorización de Entrega";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Location = new System.Drawing.Point(590, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 72);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Número de Pedido";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(17, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(132, 20);
            this.txtBuscar.TabIndex = 26;
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
            // frmGestionEntregasYEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 495);
            this.Controls.Add(this.dgvMaterialesActivos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmGestionEntregasYEncargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionEntregasYEncargos";
            this.Load += new System.EventHandler(this.frmGestionEntregasYEncargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesActivos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterialesActivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkAutorizado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnProductosPedido;
    }
}