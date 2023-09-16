namespace TP2.Forms
{
    partial class ListaCategorias
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
            lblListaCategorias = new Label();
            dgvListaCategorias = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            tbDescripcion = new TextBox();
            lblDescripcion = new Label();
            btnAgregar = new Button();
            btnGuardar = new Button();
            btnGuardarAgregar = new Button();
            lblCategoriaId = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblListaCategorias
            // 
            lblListaCategorias.AutoSize = true;
            lblListaCategorias.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblListaCategorias.Location = new Point(12, 9);
            lblListaCategorias.Name = "lblListaCategorias";
            lblListaCategorias.Size = new Size(105, 28);
            lblListaCategorias.TabIndex = 0;
            lblListaCategorias.Text = "Categorias";
            // 
            // dgvListaCategorias
            // 
            dgvListaCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaCategorias.BackgroundColor = SystemColors.Control;
            dgvListaCategorias.BorderStyle = BorderStyle.None;
            dgvListaCategorias.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListaCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.Padding = new Padding(0, 15, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCategorias.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion });
            dgvListaCategorias.EnableHeadersVisualStyles = false;
            dgvListaCategorias.GridColor = SystemColors.Control;
            dgvListaCategorias.Location = new Point(12, 110);
            dgvListaCategorias.Name = "dgvListaCategorias";
            dgvListaCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(0, 15, 0, 15);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HotTrack;
            dgvListaCategorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvListaCategorias.RowTemplate.Height = 50;
            dgvListaCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaCategorias.ShowEditingIcon = false;
            dgvListaCategorias.Size = new Size(776, 328);
            dgvListaCategorias.TabIndex = 1;
            dgvListaCategorias.CellContentClick += dgvListaCategorias_CellContentClick;
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
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(702, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 39);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(145, 55);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(100, 23);
            tbDescripcion.TabIndex = 18;
            tbDescripcion.Visible = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 58);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 17;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Location = new Point(610, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 39);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Location = new Point(12, 88);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 39);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnGuardarAgregar
            // 
            btnGuardarAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarAgregar.Location = new Point(104, 88);
            btnGuardarAgregar.Name = "btnGuardarAgregar";
            btnGuardarAgregar.Size = new Size(86, 39);
            btnGuardarAgregar.TabIndex = 27;
            btnGuardarAgregar.Text = "GUARDAR";
            btnGuardarAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarAgregar.UseVisualStyleBackColor = true;
            btnGuardarAgregar.Visible = false;
            btnGuardarAgregar.Click += btnGuardarAgregar_Click;
            // 
            // lblCategoriaId
            // 
            lblCategoriaId.AutoSize = true;
            lblCategoriaId.Location = new Point(251, 63);
            lblCategoriaId.Name = "lblCategoriaId";
            lblCategoriaId.Size = new Size(18, 15);
            lblCategoriaId.TabIndex = 28;
            lblCategoriaId.Text = "ID";
            lblCategoriaId.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Location = new Point(518, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 39);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ListaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(lblCategoriaId);
            Controls.Add(btnGuardarAgregar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregar);
            Controls.Add(tbDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(btnEditar);
            Controls.Add(dgvListaCategorias);
            Controls.Add(lblListaCategorias);
            Name = "ListaCategorias";
            Text = "ListaCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaCategorias;
        private DataGridView dgvListaCategorias;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private Button btnEditar;
        private TextBox tbDescripcion;
        private Label lblDescripcion;
        private Button btnAgregar;
        private Button btnGuardar;
        private Button btnGuardarAgregar;
        private Label lblCategoriaId;
        private Button btnEliminar;
    }
}