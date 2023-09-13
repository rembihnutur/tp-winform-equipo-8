namespace TP2.Forms
{
    partial class Lista
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
            lblTituloProductos = new Label();
            dgvArticulos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            IdMarca = new DataGridViewTextBoxColumn();
            Imagenes = new DataGridViewTextBoxColumn();
            btnGrabarNuevo = new Button();
            picImagen = new PictureBox();
            btnNavIzq = new Button();
            btnNavDer = new Button();
            pnlNavegacion = new Panel();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            cboCampo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            pnlNavegacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloProductos
            // 
            lblTituloProductos.AutoSize = true;
            lblTituloProductos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloProductos.Location = new Point(22, 13);
            lblTituloProductos.Name = "lblTituloProductos";
            lblTituloProductos.Size = new Size(111, 28);
            lblTituloProductos.TabIndex = 0;
            lblTituloProductos.Text = "ARTICULOS";
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.AllowUserToDeleteRows = false;
            dgvArticulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Nombre, Descripcion, Categoria, IdCategoria, Marca, IdMarca, Imagenes });
            dgvArticulos.Location = new Point(5, 60);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.RowTemplate.Height = 25;
            dgvArticulos.Size = new Size(454, 409);
            dgvArticulos.TabIndex = 1;
            dgvArticulos.RowHeaderMouseClick += dgvArticulos_RowHeaderMouseClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // IdCategoria
            // 
            IdCategoria.DataPropertyName = "IdCategoria";
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.Visible = false;
            // 
            // Marca
            // 
            Marca.DataPropertyName = "Marca";
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // IdMarca
            // 
            IdMarca.DataPropertyName = "IdMarca";
            IdMarca.HeaderText = "IdMarca";
            IdMarca.Name = "IdMarca";
            IdMarca.ReadOnly = true;
            IdMarca.Visible = false;
            // 
            // Imagenes
            // 
            Imagenes.DataPropertyName = "Imagenes";
            Imagenes.HeaderText = "Imagenes";
            Imagenes.Name = "Imagenes";
            Imagenes.ReadOnly = true;
            Imagenes.Visible = false;
            // 
            // btnGrabarNuevo
            // 
            btnGrabarNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGrabarNuevo.Location = new Point(655, 12);
            btnGrabarNuevo.Name = "btnGrabarNuevo";
            btnGrabarNuevo.Size = new Size(136, 39);
            btnGrabarNuevo.TabIndex = 2;
            btnGrabarNuevo.Text = "AGREGAR NUEVO";
            btnGrabarNuevo.UseVisualStyleBackColor = true;
            btnGrabarNuevo.Click += btnGrabarNuevo_Click;
            // 
            // picImagen
            // 
            picImagen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picImagen.BorderStyle = BorderStyle.Fixed3D;
            picImagen.Location = new Point(465, 60);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(326, 343);
            picImagen.TabIndex = 3;
            picImagen.TabStop = false;
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
            btnNavIzq.Click += btnNavIzq_Click;
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
            btnNavDer.Click += btnNavDer_Click;
            // 
            // pnlNavegacion
            // 
            pnlNavegacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlNavegacion.Controls.Add(btnNavIzq);
            pnlNavegacion.Controls.Add(btnNavDer);
            pnlNavegacion.Location = new Point(465, 409);
            pnlNavegacion.Name = "pnlNavegacion";
            pnlNavegacion.Size = new Size(326, 43);
            pnlNavegacion.TabIndex = 6;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(165, 22);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(34, 15);
            lblFiltro.TabIndex = 4;
            lblFiltro.Text = "Filtro";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(363, 18);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(194, 23);
            txtFiltro.TabIndex = 5;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(219, 18);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(121, 23);
            cboCampo.TabIndex = 7;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(pnlNavegacion);
            Controls.Add(picImagen);
            Controls.Add(cboCampo);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(btnGrabarNuevo);
            Controls.Add(dgvArticulos);
            Controls.Add(lblTituloProductos);
            Name = "Lista";
            Load += FormListaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            pnlNavegacion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloProductos;
        private DataGridView dgvArticulos;
        private Button btnGrabarNuevo;
        private PictureBox picImagen;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn Imagenes;
        private Button btnNavIzq;
        private Button btnNavDer;
        private Panel pnlNavegacion;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private ComboBox cboCampo;
    }
}