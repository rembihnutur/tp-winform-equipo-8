namespace TP2.Forms
{
    partial class FormAgregar
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
            lblTituloAgregar = new Label();
            lblAgregarCodigoProducto = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblAgregarNombreProducto = new Label();
            textBox3 = new TextBox();
            lblAgregarDescripcion = new Label();
            cbAgregarMarca = new ComboBox();
            cbAgregarCategoria = new ComboBox();
            lblAgregarMarca = new Label();
            lblAgregarCategoria = new Label();
            numAgregarPrecio = new NumericUpDown();
            lblAgregarPrecio = new Label();
            btnAgregarAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)numAgregarPrecio).BeginInit();
            SuspendLayout();
            // 
            // lblTituloAgregar
            // 
            lblTituloAgregar.AutoSize = true;
            lblTituloAgregar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloAgregar.Location = new Point(12, 9);
            lblTituloAgregar.Name = "lblTituloAgregar";
            lblTituloAgregar.Size = new Size(170, 28);
            lblTituloAgregar.TabIndex = 0;
            lblTituloAgregar.Text = "Agregar producto";
            // 
            // lblAgregarCodigoProducto
            // 
            lblAgregarCodigoProducto.AutoSize = true;
            lblAgregarCodigoProducto.Location = new Point(12, 62);
            lblAgregarCodigoProducto.Name = "lblAgregarCodigoProducto";
            lblAgregarCodigoProducto.Size = new Size(114, 15);
            lblAgregarCodigoProducto.TabIndex = 1;
            lblAgregarCodigoProducto.Text = "Codigo de producto";
            lblAgregarCodigoProducto.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // lblAgregarNombreProducto
            // 
            lblAgregarNombreProducto.AutoSize = true;
            lblAgregarNombreProducto.Location = new Point(12, 91);
            lblAgregarNombreProducto.Name = "lblAgregarNombreProducto";
            lblAgregarNombreProducto.Size = new Size(51, 15);
            lblAgregarNombreProducto.TabIndex = 3;
            lblAgregarNombreProducto.Text = "Nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // lblAgregarDescripcion
            // 
            lblAgregarDescripcion.AutoSize = true;
            lblAgregarDescripcion.Location = new Point(12, 120);
            lblAgregarDescripcion.Name = "lblAgregarDescripcion";
            lblAgregarDescripcion.Size = new Size(69, 15);
            lblAgregarDescripcion.TabIndex = 5;
            lblAgregarDescripcion.Text = "Descripcion";
            lblAgregarDescripcion.Click += label3_Click;
            // 
            // cbAgregarMarca
            // 
            cbAgregarMarca.FormattingEnabled = true;
            cbAgregarMarca.Location = new Point(130, 146);
            cbAgregarMarca.Name = "cbAgregarMarca";
            cbAgregarMarca.Size = new Size(121, 23);
            cbAgregarMarca.TabIndex = 7;
            // 
            // cbAgregarCategoria
            // 
            cbAgregarCategoria.FormattingEnabled = true;
            cbAgregarCategoria.Location = new Point(130, 175);
            cbAgregarCategoria.Name = "cbAgregarCategoria";
            cbAgregarCategoria.Size = new Size(121, 23);
            cbAgregarCategoria.TabIndex = 8;
            // 
            // lblAgregarMarca
            // 
            lblAgregarMarca.AutoSize = true;
            lblAgregarMarca.Location = new Point(12, 149);
            lblAgregarMarca.Name = "lblAgregarMarca";
            lblAgregarMarca.Size = new Size(40, 15);
            lblAgregarMarca.TabIndex = 9;
            lblAgregarMarca.Text = "Marca";
            // 
            // lblAgregarCategoria
            // 
            lblAgregarCategoria.AutoSize = true;
            lblAgregarCategoria.Location = new Point(12, 178);
            lblAgregarCategoria.Name = "lblAgregarCategoria";
            lblAgregarCategoria.Size = new Size(58, 15);
            lblAgregarCategoria.TabIndex = 10;
            lblAgregarCategoria.Text = "Categoria";
            // 
            // numAgregarPrecio
            // 
            numAgregarPrecio.Location = new Point(131, 204);
            numAgregarPrecio.Name = "numAgregarPrecio";
            numAgregarPrecio.Size = new Size(120, 23);
            numAgregarPrecio.TabIndex = 11;
            // 
            // lblAgregarPrecio
            // 
            lblAgregarPrecio.AutoSize = true;
            lblAgregarPrecio.Location = new Point(12, 206);
            lblAgregarPrecio.Name = "lblAgregarPrecio";
            lblAgregarPrecio.Size = new Size(40, 15);
            lblAgregarPrecio.TabIndex = 12;
            lblAgregarPrecio.Text = "Precio";
            lblAgregarPrecio.UseWaitCursor = true;
            // 
            // btnAgregarAgregar
            // 
            btnAgregarAgregar.Location = new Point(12, 388);
            btnAgregarAgregar.Name = "btnAgregarAgregar";
            btnAgregarAgregar.Size = new Size(147, 50);
            btnAgregarAgregar.TabIndex = 13;
            btnAgregarAgregar.Text = "Agregar";
            btnAgregarAgregar.UseVisualStyleBackColor = true;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarAgregar);
            Controls.Add(lblAgregarPrecio);
            Controls.Add(numAgregarPrecio);
            Controls.Add(lblAgregarCategoria);
            Controls.Add(lblAgregarMarca);
            Controls.Add(cbAgregarCategoria);
            Controls.Add(cbAgregarMarca);
            Controls.Add(textBox3);
            Controls.Add(lblAgregarDescripcion);
            Controls.Add(textBox2);
            Controls.Add(lblAgregarNombreProducto);
            Controls.Add(textBox1);
            Controls.Add(lblAgregarCodigoProducto);
            Controls.Add(lblTituloAgregar);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ((System.ComponentModel.ISupportInitialize)numAgregarPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloAgregar;
        private Label lblAgregarCodigoProducto;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblAgregarNombreProducto;
        private TextBox textBox3;
        private Label lblAgregarDescripcion;
        private ComboBox cbAgregarMarca;
        private ComboBox cbAgregarCategoria;
        private Label lblAgregarMarca;
        private Label lblAgregarCategoria;
        private NumericUpDown numAgregarPrecio;
        private Label lblAgregarPrecio;
        private Button btnAgregarAgregar;
    }
}