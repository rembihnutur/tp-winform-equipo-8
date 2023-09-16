namespace TP2.Forms
{
    partial class Acerca
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
            lblAcerca = new Label();
            lblEstudiantes = new Label();
            splitContainer1 = new SplitContainer();
            lblProfesor = new Label();
            lblProfesorNombre = new Label();
            lblEstudiante3 = new Label();
            lblEstudiante2 = new Label();
            lblEstudiante1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAcerca
            // 
            lblAcerca.AutoSize = true;
            lblAcerca.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcerca.Location = new Point(12, 9);
            lblAcerca.Name = "lblAcerca";
            lblAcerca.Size = new Size(97, 28);
            lblAcerca.TabIndex = 0;
            lblAcerca.Text = "Acerca de";
            // 
            // lblEstudiantes
            // 
            lblEstudiantes.AutoSize = true;
            lblEstudiantes.Location = new Point(3, 0);
            lblEstudiantes.Name = "lblEstudiantes";
            lblEstudiantes.Size = new Size(67, 15);
            lblEstudiantes.TabIndex = 1;
            lblEstudiantes.Text = "Estudiantes";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 62);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblProfesor);
            splitContainer1.Panel1.Controls.Add(lblEstudiantes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblProfesorNombre);
            splitContainer1.Panel2.Controls.Add(lblEstudiante3);
            splitContainer1.Panel2.Controls.Add(lblEstudiante2);
            splitContainer1.Panel2.Controls.Add(lblEstudiante1);
            splitContainer1.Size = new Size(388, 100);
            splitContainer1.SplitterDistance = 129;
            splitContainer1.TabIndex = 2;
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(0, 60);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(51, 15);
            lblProfesor.TabIndex = 3;
            lblProfesor.Text = "Profesor";
            // 
            // lblProfesorNombre
            // 
            lblProfesorNombre.AutoSize = true;
            lblProfesorNombre.Location = new Point(3, 60);
            lblProfesorNombre.Name = "lblProfesorNombre";
            lblProfesorNombre.Size = new Size(149, 15);
            lblProfesorNombre.TabIndex = 3;
            lblProfesorNombre.Text = "Maximiliano Sar Fernandez";
            // 
            // lblEstudiante3
            // 
            lblEstudiante3.AutoSize = true;
            lblEstudiante3.Location = new Point(3, 30);
            lblEstudiante3.Name = "lblEstudiante3";
            lblEstudiante3.Size = new Size(103, 15);
            lblEstudiante3.TabIndex = 4;
            lblEstudiante3.Text = "Erika Sureda Ayala";
            // 
            // lblEstudiante2
            // 
            lblEstudiante2.AutoSize = true;
            lblEstudiante2.Location = new Point(3, 15);
            lblEstudiante2.Name = "lblEstudiante2";
            lblEstudiante2.Size = new Size(86, 15);
            lblEstudiante2.TabIndex = 4;
            lblEstudiante2.Text = "Pedro Galindez";
            // 
            // lblEstudiante1
            // 
            lblEstudiante1.AutoSize = true;
            lblEstudiante1.Location = new Point(3, 0);
            lblEstudiante1.Name = "lblEstudiante1";
            lblEstudiante1.Size = new Size(158, 15);
            lblEstudiante1.TabIndex = 3;
            lblEstudiante1.Text = "Maximiliano Gastón Ferreyra";
            // 
            // Acerca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(lblAcerca);
            Name = "Acerca";
            Text = "Inicio";
            Load += Inicio_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcerca;
        private Label lblEstudiantes;
        private SplitContainer splitContainer1;
        private Label lblEstudiante1;
        private Label lblProfesor;
        private Label lblProfesorNombre;
        private Label lblEstudiante3;
        private Label lblEstudiante2;
    }
}