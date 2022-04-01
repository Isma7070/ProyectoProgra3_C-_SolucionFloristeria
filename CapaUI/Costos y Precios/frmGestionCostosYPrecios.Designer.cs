namespace CapaUI.Costos_y_Precios
{
    partial class frmGestionCostosYPrecios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarPrecio = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostoManoObra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcularPrecioVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnGuardarPrecio);
            this.panel1.Controls.Add(this.txtCosto);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 409);
            this.panel1.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(91, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nombre";
            // 
            // btnGuardarPrecio
            // 
            this.btnGuardarPrecio.Location = new System.Drawing.Point(598, 116);
            this.btnGuardarPrecio.Name = "btnGuardarPrecio";
            this.btnGuardarPrecio.Size = new System.Drawing.Size(75, 41);
            this.btnGuardarPrecio.TabIndex = 12;
            this.btnGuardarPrecio.Text = "Guardar";
            this.btnGuardarPrecio.UseVisualStyleBackColor = true;
            this.btnGuardarPrecio.Click += new System.EventHandler(this.btnGuardarPrecio_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(91, 127);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(141, 20);
            this.txtCosto.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(91, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(141, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtGanancia);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCostoManoObra);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnCalcularPrecioVenta);
            this.panel2.Location = new System.Drawing.Point(257, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 220);
            this.panel2.TabIndex = 6;
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(151, 72);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(116, 20);
            this.txtGanancia.TabIndex = 10;
            this.txtGanancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGanancia_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(22, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 35);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ganancia";
            // 
            // txtCostoManoObra
            // 
            this.txtCostoManoObra.Location = new System.Drawing.Point(151, 34);
            this.txtCostoManoObra.Name = "txtCostoManoObra";
            this.txtCostoManoObra.Size = new System.Drawing.Size(116, 20);
            this.txtCostoManoObra.TabIndex = 8;
            this.txtCostoManoObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoManoObra_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Costo de mano de obra";
            // 
            // btnCalcularPrecioVenta
            // 
            this.btnCalcularPrecioVenta.Location = new System.Drawing.Point(151, 167);
            this.btnCalcularPrecioVenta.Name = "btnCalcularPrecioVenta";
            this.btnCalcularPrecioVenta.Size = new System.Drawing.Size(116, 35);
            this.btnCalcularPrecioVenta.TabIndex = 11;
            this.btnCalcularPrecioVenta.Text = "Calcular precio venta";
            this.btnCalcularPrecioVenta.UseVisualStyleBackColor = true;
            this.btnCalcularPrecioVenta.Click += new System.EventHandler(this.btnCalcularPrecioVenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(557, 75);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(116, 20);
            this.txtPrecioVenta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Còdigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio Venta sin I.V.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // frmGestionCostosYPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 433);
            this.Controls.Add(this.panel1);
            this.Name = "frmGestionCostosYPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costos y Precios";
            this.Load += new System.EventHandler(this.frmGestionCostosYPrecios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalcularPrecioVenta;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCostoManoObra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarPrecio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
    }
}