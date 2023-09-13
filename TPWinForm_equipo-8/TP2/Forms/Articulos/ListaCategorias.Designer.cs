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
            lblListaCategorias = new Label();
            dgvListaCategorias = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblListaCategorias
            // 
            lblListaCategorias.AutoSize = true;
            lblListaCategorias.Location = new Point(12, 9);
            lblListaCategorias.Name = "lblListaCategorias";
            lblListaCategorias.Size = new Size(63, 15);
            lblListaCategorias.TabIndex = 0;
            lblListaCategorias.Text = "Categorias";
            // 
            // dgvListaCategorias
            // 
            dgvListaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCategorias.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion });
            dgvListaCategorias.Location = new Point(12, 110);
            dgvListaCategorias.Name = "dgvListaCategorias";
            dgvListaCategorias.RowTemplate.Height = 25;
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
            // ListaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}