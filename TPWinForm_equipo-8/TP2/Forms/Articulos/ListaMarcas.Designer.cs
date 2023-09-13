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
            dgvListaMarcas.Location = new Point(12, 27);
            dgvListaMarcas.Name = "dgvListaMarcas";
            dgvListaMarcas.RowTemplate.Height = 25;
            dgvListaMarcas.Size = new Size(776, 411);
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
            // ListaMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}