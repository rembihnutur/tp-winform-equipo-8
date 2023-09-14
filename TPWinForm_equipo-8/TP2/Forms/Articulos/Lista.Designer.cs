﻿namespace TP2.Forms
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
            Precio = new DataGridViewTextBoxColumn();
            btnGrabarNuevo = new Button();
            picImagen = new PictureBox();
            btnNavIzq = new Button();
            btnNavDer = new Button();
            pnlNavegacion = new Panel();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            cboCampo = new ComboBox();
            btnEditar = new Button();
            tbCodigo = new TextBox();
            lblCodigo = new Label();
            tbNombre = new TextBox();
            lblNombre = new Label();
            tbDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblMarca = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            nudPrecio = new NumericUpDown();
            cbMarca = new ComboBox();
            cbCategoria = new ComboBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
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
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Nombre, Descripcion, Categoria, IdCategoria, Marca, IdMarca, Imagenes, Precio });
            dgvArticulos.Location = new Point(5, 60);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.RowTemplate.Height = 25;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // btnGrabarNuevo
            // 
            btnGrabarNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGrabarNuevo.Location = new Point(497, 15);
            btnGrabarNuevo.Name = "btnGrabarNuevo";
            btnGrabarNuevo.Size = new Size(110, 39);
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
            picImagen.Click += picImagen_Click;
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
            txtFiltro.Size = new Size(123, 23);
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
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(613, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 39);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(129, 57);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(100, 23);
            tbCodigo.TabIndex = 12;
            tbCodigo.Visible = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 60);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 11;
            lblCodigo.Text = "Codigo";
            lblCodigo.Visible = false;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(129, 86);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 14;
            tbNombre.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            lblNombre.Visible = false;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(129, 114);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(100, 100);
            tbDescripcion.TabIndex = 16;
            tbDescripcion.Visible = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(16, 118);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.Visible = false;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(268, 60);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 17;
            lblMarca.Text = "Marca";
            lblMarca.Visible = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(268, 89);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 19;
            lblCategoria.Text = "Categoria";
            lblCategoria.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(268, 118);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 20;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(365, 115);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 21;
            nudPrecio.Visible = false;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(365, 52);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(121, 23);
            cbMarca.TabIndex = 23;
            cbMarca.Visible = false;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(365, 86);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(121, 23);
            cbCategoria.TabIndex = 24;
            cbCategoria.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Location = new Point(12, 221);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 39);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Location = new Point(705, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 39);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(cbCategoria);
            Controls.Add(cbMarca);
            Controls.Add(nudPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblMarca);
            Controls.Add(tbDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(tbNombre);
            Controls.Add(lblNombre);
            Controls.Add(tbCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnEditar);
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
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloProductos;
        private DataGridView dgvArticulos;
        private Button btnGrabarNuevo;
        private PictureBox picImagen;
        private Button btnNavIzq;
        private Button btnNavDer;
        private Panel pnlNavegacion;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private ComboBox cboCampo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn Imagenes;
        private Button btnEditar;
        private TextBox tbCodigo;
        private Label lblCodigo;
        private TextBox tbNombre;
        private Label lblNombre;
        private TextBox tbDescripcion;
        private Label lblDescripcion;
        private Label lblMarca;
        private Label lblCategoria;
        private Label lblPrecio;
        private NumericUpDown nudPrecio;
        private ComboBox cbMarca;
        private ComboBox cbCategoria;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}