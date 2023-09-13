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
            btnGrabarNuevo = new Button();
            pictureBox1 = new PictureBox();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            cboCampo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Nombre, Descripcion, Categoria, IdCategoria, Marca, IdMarca });
            dgvArticulos.Location = new Point(12, 145);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.RowTemplate.Height = 25;
            dgvArticulos.Size = new Size(585, 269);
            dgvArticulos.TabIndex = 1;
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
            // btnGrabarNuevo
            // 
            btnGrabarNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGrabarNuevo.Location = new Point(652, 26);
            btnGrabarNuevo.Name = "btnGrabarNuevo";
            btnGrabarNuevo.Size = new Size(136, 39);
            btnGrabarNuevo.TabIndex = 2;
            btnGrabarNuevo.Text = "AGREGAR NUEVO";
            btnGrabarNuevo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(644, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 135);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(32, 70);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(34, 15);
            lblFiltro.TabIndex = 4;
            lblFiltro.Text = "Filtro";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(230, 66);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(194, 23);
            txtFiltro.TabIndex = 5;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(86, 66);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(121, 23);
            cboCampo.TabIndex = 7;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboCampo);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(pictureBox1);
            Controls.Add(btnGrabarNuevo);
            Controls.Add(dgvArticulos);
            Controls.Add(lblTituloProductos);
            Name = "Lista";
            Load += FormListaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloProductos;
        private DataGridView dgvArticulos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn IdMarca;
        private Button btnGrabarNuevo;
        private PictureBox pictureBox1;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private ComboBox cboCampo;
    }
}