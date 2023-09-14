namespace TP2.Forms
{
    partial class ListaMarcas
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
            lblListaMarcas = new Label();
            dgvListaMarcas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            lblCategoriaId = new Label();
            btnGuardar = new Button();
            btnAgregar = new Button();
            tbDescripcion = new TextBox();
            lblDescripcion = new Label();
            btnEditar = new Button();
            btnGuardarAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaMarcas).BeginInit();
            SuspendLayout();
            // 
            // lblListaMarcas
            // 
            lblListaMarcas.AutoSize = true;
            lblListaMarcas.Location = new Point(12, 9);
            lblListaMarcas.Name = "lblListaMarcas";
            lblListaMarcas.Size = new Size(45, 15);
            lblListaMarcas.TabIndex = 0;
            lblListaMarcas.Text = "Marcas";
            // 
            // dgvListaMarcas
            // 
            dgvListaMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaMarcas.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion });
            dgvListaMarcas.Location = new Point(12, 65);
            dgvListaMarcas.Name = "dgvListaMarcas";
            dgvListaMarcas.RowTemplate.Height = 25;
            dgvListaMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaMarcas.Size = new Size(776, 375);
            dgvListaMarcas.TabIndex = 1;
            dgvListaMarcas.CellContentClick += dgvListaMarcas_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // lblCategoriaId
            // 
            lblCategoriaId.AutoSize = true;
            lblCategoriaId.Location = new Point(251, 63);
            lblCategoriaId.Name = "lblCategoriaId";
            lblCategoriaId.Size = new Size(18, 15);
            lblCategoriaId.TabIndex = 35;
            lblCategoriaId.Text = "ID";
            lblCategoriaId.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Location = new Point(104, 89);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 39);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Location = new Point(610, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 39);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(145, 55);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(100, 23);
            tbDescripcion.TabIndex = 31;
            tbDescripcion.Visible = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 58);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 30;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(702, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 39);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardarAgregar
            // 
            btnGuardarAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarAgregar.Location = new Point(12, 89);
            btnGuardarAgregar.Name = "btnGuardarAgregar";
            btnGuardarAgregar.Size = new Size(86, 39);
            btnGuardarAgregar.TabIndex = 36;
            btnGuardarAgregar.Text = "GUARDAR";
            btnGuardarAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarAgregar.UseVisualStyleBackColor = true;
            btnGuardarAgregar.Visible = false;
            btnGuardarAgregar.Click += btnGuardarAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Location = new Point(518, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 39);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ListaMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(lblCategoriaId);
            Controls.Add(btnGuardarAgregar);
            Controls.Add(btnAgregar);
            Controls.Add(tbDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(btnEditar);
            Controls.Add(dgvListaMarcas);
            Controls.Add(lblListaMarcas);
            Name = "ListaMarcas";
            Text = "ListaDeMarcas";
            ((System.ComponentModel.ISupportInitialize)dgvListaMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaMarcas;
        private DataGridView dgvListaMarcas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private Label lblCategoriaId;
        private Button btnGuardar;
        private Button btnAgregar;
        private TextBox tbDescripcion;
        private Label lblDescripcion;
        private Button btnEditar;
        private Button btnGuardarAgregar;
        private Button btnEliminar;
    }
}