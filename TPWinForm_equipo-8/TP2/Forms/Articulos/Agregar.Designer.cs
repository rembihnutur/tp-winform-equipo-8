namespace TP2.Forms
{
    partial class Agregar
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
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            lblAgregarNombreProducto = new Label();
            txtDescripcion = new TextBox();
            lblAgregarDescripcion = new Label();
            cmbMarca = new ComboBox();
            cmbCategoria = new ComboBox();
            lblAgregarMarca = new Label();
            lblAgregarCategoria = new Label();
            lblAgregarPrecio = new Label();
            btnAgregar = new Button();
            txtPrecio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            SuspendLayout();
            // 
            // lblTituloAgregar
            // 
            lblTituloAgregar.AutoSize = true;
            lblTituloAgregar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloAgregar.Location = new Point(12, 9);
            lblTituloAgregar.Name = "lblTituloAgregar";
            lblTituloAgregar.Size = new Size(193, 28);
            lblTituloAgregar.TabIndex = 0;
            lblTituloAgregar.Text = "AGREGAR ARTICULO";
            // 
            // lblAgregarCodigoProducto
            // 
            lblAgregarCodigoProducto.AutoSize = true;
            lblAgregarCodigoProducto.Location = new Point(12, 63);
            lblAgregarCodigoProducto.Name = "lblAgregarCodigoProducto";
            lblAgregarCodigoProducto.Size = new Size(114, 15);
            lblAgregarCodigoProducto.TabIndex = 1;
            lblAgregarCodigoProducto.Text = "Codigo de producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(130, 59);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(67, 23);
            txtCodigo.TabIndex = 2;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(381, 23);
            txtNombre.TabIndex = 4;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // lblAgregarNombreProducto
            // 
            lblAgregarNombreProducto.AutoSize = true;
            lblAgregarNombreProducto.Location = new Point(215, 63);
            lblAgregarNombreProducto.Name = "lblAgregarNombreProducto";
            lblAgregarNombreProducto.Size = new Size(51, 15);
            lblAgregarNombreProducto.TabIndex = 3;
            lblAgregarNombreProducto.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(130, 88);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(523, 23);
            txtDescripcion.TabIndex = 6;
            txtDescripcion.KeyDown += txtDescripcion_KeyDown;
            // 
            // lblAgregarDescripcion
            // 
            lblAgregarDescripcion.AutoSize = true;
            lblAgregarDescripcion.Location = new Point(12, 92);
            lblAgregarDescripcion.Name = "lblAgregarDescripcion";
            lblAgregarDescripcion.Size = new Size(69, 15);
            lblAgregarDescripcion.TabIndex = 5;
            lblAgregarDescripcion.Text = "Descripcion";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(130, 117);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(231, 23);
            cmbMarca.TabIndex = 7;
            cmbMarca.DropDownClosed += cmbMarca_DropDownClosed;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(447, 117);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(206, 23);
            cmbCategoria.TabIndex = 8;
            cmbCategoria.DropDownClosed += cmbCategoria_DropDownClosed;
            // 
            // lblAgregarMarca
            // 
            lblAgregarMarca.AutoSize = true;
            lblAgregarMarca.Location = new Point(12, 121);
            lblAgregarMarca.Name = "lblAgregarMarca";
            lblAgregarMarca.Size = new Size(40, 15);
            lblAgregarMarca.TabIndex = 9;
            lblAgregarMarca.Text = "Marca";
            // 
            // lblAgregarCategoria
            // 
            lblAgregarCategoria.AutoSize = true;
            lblAgregarCategoria.Location = new Point(367, 121);
            lblAgregarCategoria.Name = "lblAgregarCategoria";
            lblAgregarCategoria.Size = new Size(58, 15);
            lblAgregarCategoria.TabIndex = 10;
            lblAgregarCategoria.Text = "Categoria";
            // 
            // lblAgregarPrecio
            // 
            lblAgregarPrecio.AutoSize = true;
            lblAgregarPrecio.Location = new Point(12, 150);
            lblAgregarPrecio.Name = "lblAgregarPrecio";
            lblAgregarPrecio.Size = new Size(40, 15);
            lblAgregarPrecio.TabIndex = 12;
            lblAgregarPrecio.Text = "Precio";
            lblAgregarPrecio.UseWaitCursor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(239, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(230, 50);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR ARTICULO";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.DecimalPlaces = 2;
            txtPrecio.Location = new Point(130, 146);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 23);
            txtPrecio.TabIndex = 15;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecio);
            Controls.Add(btnAgregar);
            Controls.Add(lblAgregarPrecio);
            Controls.Add(lblAgregarCategoria);
            Controls.Add(lblAgregarMarca);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbMarca);
            Controls.Add(txtDescripcion);
            Controls.Add(lblAgregarDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblAgregarNombreProducto);
            Controls.Add(txtCodigo);
            Controls.Add(lblAgregarCodigoProducto);
            Controls.Add(lblTituloAgregar);
            Name = "Agregar";
            Load += Agregar_Load;
            Shown += FormAgregar_Shown;
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloAgregar;
        private Label lblAgregarCodigoProducto;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label lblAgregarNombreProducto;
        private TextBox txtDescripcion;
        private Label lblAgregarDescripcion;
        private ComboBox cmbMarca;
        private ComboBox cmbCategoria;
        private Label lblAgregarMarca;
        private Label lblAgregarCategoria;
        private Label lblAgregarPrecio;
        private Button btnAgregar;
        private NumericUpDown txtPrecio;
    }
}