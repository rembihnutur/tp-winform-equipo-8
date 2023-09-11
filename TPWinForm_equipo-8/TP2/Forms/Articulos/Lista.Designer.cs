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
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
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
            dgvArticulos.Location = new Point(5, 60);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.RowTemplate.Height = 25;
            dgvArticulos.Size = new Size(790, 385);
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
            btnGrabarNuevo.Location = new Point(659, 12);
            btnGrabarNuevo.Name = "btnGrabarNuevo";
            btnGrabarNuevo.Size = new Size(136, 39);
            btnGrabarNuevo.TabIndex = 2;
            btnGrabarNuevo.Text = "AGREGAR NUEVO";
            btnGrabarNuevo.UseVisualStyleBackColor = true;
            // 
            // FormListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGrabarNuevo);
            Controls.Add(dgvArticulos);
            Controls.Add(lblTituloProductos);
            Name = "FormListaProductos";
            Load += FormListaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
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
    }
}