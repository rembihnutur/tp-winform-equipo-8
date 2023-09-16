namespace TP2.Forms
{
    partial class VerArticulo
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
            pnlNavegacion = new Panel();
            btnNavIzq = new Button();
            btnNavDer = new Button();
            picImagen = new PictureBox();
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblMarca = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblPrecioTexto = new Label();
            lblCategoriaTexto = new Label();
            lblMarcaTexto = new Label();
            lblDescripcionTexto = new Label();
            lblNombreTexto = new Label();
            lblCodigoTexto = new Label();
            lblTitulo = new Label();
            pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // pnlNavegacion
            // 
            pnlNavegacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlNavegacion.Controls.Add(btnNavIzq);
            pnlNavegacion.Controls.Add(btnNavDer);
            pnlNavegacion.Location = new Point(462, 217);
            pnlNavegacion.Name = "pnlNavegacion";
            pnlNavegacion.Size = new Size(326, 43);
            pnlNavegacion.TabIndex = 8;
            // 
            // btnNavIzq
            // 
            btnNavIzq.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavIzq.Location = new Point(119, 4);
            btnNavIzq.Name = "btnNavIzq";
            btnNavIzq.Size = new Size(37, 35);
            btnNavIzq.TabIndex = 4;
            btnNavIzq.Text = "<";
            btnNavIzq.UseVisualStyleBackColor = true;
            // 
            // btnNavDer
            // 
            btnNavDer.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavDer.Location = new Point(171, 4);
            btnNavDer.Name = "btnNavDer";
            btnNavDer.Size = new Size(37, 35);
            btnNavDer.TabIndex = 5;
            btnNavDer.Text = ">";
            btnNavDer.UseVisualStyleBackColor = true;
            // 
            // picImagen
            // 
            picImagen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picImagen.BorderStyle = BorderStyle.Fixed3D;
            picImagen.Location = new Point(462, 12);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(326, 199);
            picImagen.TabIndex = 7;
            picImagen.TabStop = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(15, 196);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 26;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(15, 167);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 25;
            lblCategoria.Text = "Categoria";
            lblCategoria.Visible = false;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(15, 138);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 24;
            lblMarca.Text = "Marca";
            lblMarca.Visible = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(15, 110);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 23;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 81);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 22;
            lblNombre.Text = "Nombre";
            lblNombre.Visible = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(15, 52);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 21;
            lblCodigo.Text = "Codigo";
            lblCodigo.Visible = false;
            // 
            // lblPrecioTexto
            // 
            lblPrecioTexto.AutoSize = true;
            lblPrecioTexto.Location = new Point(114, 196);
            lblPrecioTexto.Name = "lblPrecioTexto";
            lblPrecioTexto.Size = new Size(40, 15);
            lblPrecioTexto.TabIndex = 32;
            lblPrecioTexto.Text = "Precio";
            lblPrecioTexto.Visible = false;
            // 
            // lblCategoriaTexto
            // 
            lblCategoriaTexto.AutoSize = true;
            lblCategoriaTexto.Location = new Point(114, 167);
            lblCategoriaTexto.Name = "lblCategoriaTexto";
            lblCategoriaTexto.Size = new Size(58, 15);
            lblCategoriaTexto.TabIndex = 31;
            lblCategoriaTexto.Text = "Categoria";
            lblCategoriaTexto.Visible = false;
            // 
            // lblMarcaTexto
            // 
            lblMarcaTexto.AutoSize = true;
            lblMarcaTexto.Location = new Point(114, 138);
            lblMarcaTexto.Name = "lblMarcaTexto";
            lblMarcaTexto.Size = new Size(40, 15);
            lblMarcaTexto.TabIndex = 30;
            lblMarcaTexto.Text = "Marca";
            lblMarcaTexto.Visible = false;
            // 
            // lblDescripcionTexto
            // 
            lblDescripcionTexto.AutoSize = true;
            lblDescripcionTexto.Location = new Point(114, 110);
            lblDescripcionTexto.Name = "lblDescripcionTexto";
            lblDescripcionTexto.Size = new Size(69, 15);
            lblDescripcionTexto.TabIndex = 29;
            lblDescripcionTexto.Text = "Descripcion";
            lblDescripcionTexto.Visible = false;
            // 
            // lblNombreTexto
            // 
            lblNombreTexto.AutoSize = true;
            lblNombreTexto.Location = new Point(114, 81);
            lblNombreTexto.Name = "lblNombreTexto";
            lblNombreTexto.Size = new Size(51, 15);
            lblNombreTexto.TabIndex = 28;
            lblNombreTexto.Text = "Nombre";
            lblNombreTexto.Visible = false;
            // 
            // lblCodigoTexto
            // 
            lblCodigoTexto.AutoSize = true;
            lblCodigoTexto.Location = new Point(114, 52);
            lblCodigoTexto.Name = "lblCodigoTexto";
            lblCodigoTexto.Size = new Size(46, 15);
            lblCodigoTexto.TabIndex = 27;
            lblCodigoTexto.Text = "Codigo";
            lblCodigoTexto.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(77, 23);
            lblTitulo.TabIndex = 33;
            lblTitulo.Text = "Nombre";
            // 
            // VerArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 261);
            Controls.Add(lblTitulo);
            Controls.Add(lblPrecioTexto);
            Controls.Add(lblCategoriaTexto);
            Controls.Add(lblMarcaTexto);
            Controls.Add(lblDescripcionTexto);
            Controls.Add(lblNombreTexto);
            Controls.Add(lblCodigoTexto);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblMarca);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(pnlNavegacion);
            Controls.Add(picImagen);
            Name = "VerArticulo";
            Text = "VerArticulo";
            pnlNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavegacion;
        private Button btnNavIzq;
        private Button btnNavDer;
        private PictureBox picImagen;
        private Label lblPrecio;
        private Label lblCategoria;
        private Label lblMarca;
        private Label lblDescripcion;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblPrecioTexto;
        private Label lblCategoriaTexto;
        private Label lblMarcaTexto;
        private Label lblDescripcionTexto;
        private Label lblNombreTexto;
        private Label lblCodigoTexto;
        private Label lblTitulo;
    }
}