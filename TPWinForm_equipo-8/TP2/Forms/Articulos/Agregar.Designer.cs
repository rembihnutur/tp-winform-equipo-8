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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            button1 = new Button();
            dgvArticulos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
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
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(130, 117);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(231, 23);
            cmbMarca.TabIndex = 7;
            cmbMarca.DropDownClosed += cmbMarca_DropDownClosed;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
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
            btnAgregar.Location = new Point(422, 373);
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
            // button1
            // 
            button1.Location = new Point(423, 157);
            button1.Name = "button1";
            button1.Size = new Size(230, 26);
            button1.TabIndex = 13;
            button1.Text = "AGREGAR IMAGEN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.AllowUserToDeleteRows = false;
            dgvArticulos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvArticulos.BackgroundColor = SystemColors.Control;
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
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { Id, Imagen, Ruta });
            dgvArticulos.EnableHeadersVisualStyles = false;
            dgvArticulos.GridColor = SystemColors.Control;
            dgvArticulos.Location = new Point(13, 189);
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
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HotTrack;
            dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvArticulos.RowTemplate.Height = 25;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.ShowEditingIcon = false;
            dgvArticulos.Size = new Size(640, 178);
            dgvArticulos.TabIndex = 16;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
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
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvArticulos);
            Controls.Add(txtPrecio);
            Controls.Add(button1);
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
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
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
        private Button button1;
        private DataGridView dgvArticulos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Ruta;
    }
}