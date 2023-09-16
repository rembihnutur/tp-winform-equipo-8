namespace TP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnCategorias = new Button();
            btnMarcas = new Button();
            btnBuscar = new Button();
            btnLista = new Button();
            lblInicio = new Label();
            panelDesktop = new Panel();
            btnAcerca = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.Highlight;
            panelMenu.Controls.Add(btnAcerca);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(btnMarcas);
            panelMenu.Controls.Add(btnBuscar);
            panelMenu.Controls.Add(btnLista);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(189, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnCategorias
            // 
            btnCategorias.Dock = DockStyle.Top;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategorias.ForeColor = SystemColors.ButtonFace;
            btnCategorias.Location = new Point(0, 180);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Padding = new Padding(5, 0, 0, 0);
            btnCategorias.Size = new Size(189, 60);
            btnCategorias.TabIndex = 8;
            btnCategorias.Text = "Categorias";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnMarcas
            // 
            btnMarcas.Dock = DockStyle.Top;
            btnMarcas.FlatAppearance.BorderSize = 0;
            btnMarcas.FlatStyle = FlatStyle.Flat;
            btnMarcas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarcas.ForeColor = SystemColors.ButtonFace;
            btnMarcas.Location = new Point(0, 120);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Padding = new Padding(5, 0, 0, 0);
            btnMarcas.Size = new Size(189, 60);
            btnMarcas.TabIndex = 7;
            btnMarcas.Text = "Marcas";
            btnMarcas.TextAlign = ContentAlignment.MiddleLeft;
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Dock = DockStyle.Top;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(0, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(5, 0, 0, 0);
            btnBuscar.Size = new Size(189, 60);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.UseWaitCursor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLista
            // 
            btnLista.Dock = DockStyle.Top;
            btnLista.FlatAppearance.BorderSize = 0;
            btnLista.FlatStyle = FlatStyle.Flat;
            btnLista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLista.ForeColor = SystemColors.ButtonFace;
            btnLista.Location = new Point(0, 0);
            btnLista.Name = "btnLista";
            btnLista.Padding = new Padding(5, 0, 0, 0);
            btnLista.Size = new Size(189, 60);
            btnLista.TabIndex = 5;
            btnLista.Text = "Productos";
            btnLista.TextAlign = ContentAlignment.MiddleLeft;
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // lblInicio
            // 
            lblInicio.Anchor = AnchorStyles.Top;
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblInicio.Location = new Point(431, 9);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(59, 28);
            lblInicio.TabIndex = 1;
            lblInicio.Text = "Inicio";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(189, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(611, 450);
            panelDesktop.TabIndex = 2;
            // 
            // btnAcerca
            // 
            btnAcerca.Dock = DockStyle.Top;
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatStyle = FlatStyle.Flat;
            btnAcerca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcerca.ForeColor = SystemColors.ButtonFace;
            btnAcerca.Location = new Point(0, 240);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Padding = new Padding(5, 0, 0, 0);
            btnAcerca.Size = new Size(189, 60);
            btnAcerca.TabIndex = 9;
            btnAcerca.Text = "Acerca de";
            btnAcerca.TextAlign = ContentAlignment.MiddleLeft;
            btnAcerca.UseVisualStyleBackColor = true;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDesktop);
            Controls.Add(lblInicio);
            Controls.Add(panelMenu);
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Label lblInicio;
        private Panel panelDesktop;
        private Button btnLista;
        private Button btnCategorias;
        private Button btnMarcas;
        private Button btnBuscar;
        private Button btnAcerca;
    }
}