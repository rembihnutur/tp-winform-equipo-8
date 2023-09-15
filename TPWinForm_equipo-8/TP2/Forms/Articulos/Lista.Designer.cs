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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            pnlCargaImagen = new Panel();
            progressBar1 = new ProgressBar();
            gbEditar = new GroupBox();
            label1 = new Label();
            dgvImagenes = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            pnlCargaImagen.SuspendLayout();
            gbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImagenes).BeginInit();
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
            dgvArticulos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvArticulos.BackgroundColor = SystemColors.Control;
            dgvArticulos.BorderStyle = BorderStyle.None;
            dgvArticulos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvArticulos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(0, 15, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Nombre, Descripcion, Categoria, IdCategoria, Marca, IdMarca, Imagenes, Precio });
            dgvArticulos.EnableHeadersVisualStyles = false;
            dgvArticulos.GridColor = SystemColors.Control;
            dgvArticulos.Location = new Point(5, 60);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(0, 15, 0, 15);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HotTrack;
            dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvArticulos.RowTemplate.Height = 50;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.ShowEditingIcon = false;
            dgvArticulos.Size = new Size(593, 598);
            dgvArticulos.TabIndex = 1;
            dgvArticulos.RowHeaderMouseClick += dgvArticulos_RowHeaderMouseClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
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
            btnGrabarNuevo.Location = new Point(636, 15);
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
            picImagen.BackgroundImageLayout = ImageLayout.Zoom;
            picImagen.BorderStyle = BorderStyle.Fixed3D;
            picImagen.Location = new Point(604, 59);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(326, 343);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
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
            pnlNavegacion.Location = new Point(604, 408);
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
            txtFiltro.Enabled = false;
            txtFiltro.Location = new Point(363, 18);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(123, 23);
            txtFiltro.TabIndex = 5;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            txtFiltro.Leave += txtFiltro_Leave;
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(219, 18);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(121, 23);
            cboCampo.TabIndex = 7;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(752, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 39);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(98, 20);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(100, 23);
            tbCodigo.TabIndex = 12;
            tbCodigo.Visible = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(46, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 11;
            lblCodigo.Text = "Codigo";
            lblCodigo.Visible = false;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(98, 49);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 14;
            tbNombre.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            lblNombre.Visible = false;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(98, 78);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(357, 24);
            tbDescripcion.TabIndex = 16;
            tbDescripcion.Visible = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 82);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.Visible = false;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(288, 24);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 17;
            lblMarca.Text = "Marca";
            lblMarca.Visible = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(270, 53);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 19;
            lblCategoria.Text = "Categoria";
            lblCategoria.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(52, 111);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 20;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(98, 108);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(100, 23);
            nudPrecio.TabIndex = 21;
            nudPrecio.TextAlign = HorizontalAlignment.Right;
            nudPrecio.Visible = false;
            // 
            // cbMarca
            // 
            cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(334, 20);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(121, 23);
            cbMarca.TabIndex = 23;
            cbMarca.Visible = false;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(334, 49);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(121, 23);
            cbCategoria.TabIndex = 24;
            cbCategoria.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Location = new Point(264, 296);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(217, 39);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Location = new Point(844, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 39);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pnlCargaImagen
            // 
            pnlCargaImagen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCargaImagen.Controls.Add(progressBar1);
            pnlCargaImagen.Location = new Point(604, 408);
            pnlCargaImagen.Name = "pnlCargaImagen";
            pnlCargaImagen.Size = new Size(326, 43);
            pnlCargaImagen.TabIndex = 6;
            pnlCargaImagen.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 8);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(302, 14);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 0;
            // 
            // gbEditar
            // 
            gbEditar.Controls.Add(label1);
            gbEditar.Controls.Add(dgvImagenes);
            gbEditar.Controls.Add(cbCategoria);
            gbEditar.Controls.Add(btnGuardar);
            gbEditar.Controls.Add(cbMarca);
            gbEditar.Controls.Add(button1);
            gbEditar.Controls.Add(nudPrecio);
            gbEditar.Controls.Add(lblPrecio);
            gbEditar.Controls.Add(lblCodigo);
            gbEditar.Controls.Add(lblCategoria);
            gbEditar.Controls.Add(tbCodigo);
            gbEditar.Controls.Add(lblMarca);
            gbEditar.Controls.Add(lblNombre);
            gbEditar.Controls.Add(tbDescripcion);
            gbEditar.Controls.Add(tbNombre);
            gbEditar.Controls.Add(lblDescripcion);
            gbEditar.Location = new Point(22, 15);
            gbEditar.Name = "gbEditar";
            gbEditar.Size = new Size(490, 344);
            gbEditar.TabIndex = 40;
            gbEditar.TabStop = false;
            gbEditar.Text = "EDITAR ARTICULO";
            gbEditar.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 136);
            label1.Name = "label1";
            label1.Size = new Size(181, 12);
            label1.TabIndex = 28;
            label1.Text = "(*) Doble click para eliminar una imagen";
            // 
            // dgvImagenes
            // 
            dgvImagenes.AllowUserToAddRows = false;
            dgvImagenes.AllowUserToDeleteRows = false;
            dgvImagenes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvImagenes.BackgroundColor = SystemColors.Control;
            dgvImagenes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvImagenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvImagenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImagenes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Imagen, Ruta });
            dgvImagenes.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvImagenes.EnableHeadersVisualStyles = false;
            dgvImagenes.GridColor = SystemColors.Control;
            dgvImagenes.Location = new Point(8, 151);
            dgvImagenes.MultiSelect = false;
            dgvImagenes.Name = "dgvImagenes";
            dgvImagenes.ReadOnly = true;
            dgvImagenes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvImagenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvImagenes.RowHeadersVisible = false;
            dgvImagenes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HotTrack;
            dgvImagenes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvImagenes.RowTemplate.Height = 25;
            dgvImagenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImagenes.ShowEditingIcon = false;
            dgvImagenes.Size = new Size(474, 137);
            dgvImagenes.TabIndex = 27;
            dgvImagenes.CellMouseDoubleClick += dgvImagenes_CellMouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Imagen
            // 
            Imagen.DataPropertyName = "Imagen";
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Resizable = DataGridViewTriState.False;
            Imagen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Ruta
            // 
            Ruta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ruta.DataPropertyName = "Ruta";
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            Ruta.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(348, 113);
            button1.Name = "button1";
            button1.Size = new Size(133, 34);
            button1.TabIndex = 26;
            button1.Text = "AGREGAR IMAGEN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(939, 660);
            Controls.Add(gbEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(pnlCargaImagen);
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
            pnlCargaImagen.ResumeLayout(false);
            gbEditar.ResumeLayout(false);
            gbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImagenes).EndInit();
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn Imagenes;
        private DataGridViewTextBoxColumn Precio;
        private Panel pnlCargaImagen;
        private ProgressBar progressBar1;
        private GroupBox gbEditar;
        private DataGridView dgvImagenes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Ruta;
        private Button button1;
        private Label label1;
    }
}