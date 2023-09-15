namespace TP2.Forms.Articulos
{
    partial class Buscar
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
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            lblCampo = new Label();
            cboCampo = new ComboBox();
            lblCriterio = new Label();
            cboCriterio = new ComboBox();
            btnBuscar = new Button();
            txtFiltro2 = new TextBox();
            lblY = new Label();
            SuspendLayout();
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(426, 52);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(34, 15);
            lblFiltro.TabIndex = 3;
            lblFiltro.Text = "Entre";
            // 
            // txtFiltro
            // 
            txtFiltro.Enabled = false;
            txtFiltro.Location = new Point(465, 48);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(100, 23);
            txtFiltro.TabIndex = 4;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(24, 52);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(46, 15);
            lblCampo.TabIndex = 5;
            lblCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(74, 48);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(121, 23);
            cboCampo.TabIndex = 6;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Location = new Point(215, 52);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(46, 15);
            lblCriterio.TabIndex = 7;
            lblCriterio.Text = "Criterio";
            // 
            // cboCriterio
            // 
            cboCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(263, 48);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(121, 23);
            cboCriterio.TabIndex = 8;
            cboCriterio.SelectedIndexChanged += cboCriterio_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(335, 103);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 36);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtFiltro2
            // 
            txtFiltro2.Enabled = false;
            txtFiltro2.Location = new Point(598, 48);
            txtFiltro2.Name = "txtFiltro2";
            txtFiltro2.Size = new Size(100, 23);
            txtFiltro2.TabIndex = 10;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(575, 52);
            lblY.Name = "lblY";
            lblY.Size = new Size(14, 15);
            lblY.TabIndex = 11;
            lblY.Text = "Y";
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 185);
            Controls.Add(lblY);
            Controls.Add(txtFiltro2);
            Controls.Add(btnBuscar);
            Controls.Add(cboCriterio);
            Controls.Add(lblCriterio);
            Controls.Add(cboCampo);
            Controls.Add(lblCampo);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            MaximizeBox = false;
            MaximumSize = new Size(768, 224);
            MinimizeBox = false;
            MinimumSize = new Size(768, 224);
            Name = "Buscar";
            Text = "Buscar";
            Load += Buscar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Label lblCampo;
        private ComboBox cboCampo;
        private Label lblCriterio;
        private ComboBox cboCriterio;
        private Button btnBuscar;
        private TextBox txtFiltro2;
        private Label lblY;
    }
}