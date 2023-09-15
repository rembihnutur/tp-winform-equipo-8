namespace TP2.Forms.Articulos
{
    partial class AgregarImagen
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
            button1 = new Button();
            button2 = new Button();
            txtRuta = new TextBox();
            groupBox1 = new GroupBox();
            pgCargando = new ProgressBar();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(97, 77);
            button1.Name = "button1";
            button1.Size = new Size(153, 37);
            button1.TabIndex = 0;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 77);
            button2.Name = "button2";
            button2.Size = new Size(153, 37);
            button2.TabIndex = 0;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(14, 22);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(453, 23);
            txtRuta.TabIndex = 1;
            txtRuta.KeyDown += txtRuta_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRuta);
            groupBox1.Location = new Point(14, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 61);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Direccion de la Imagen";
            // 
            // pgCargando
            // 
            pgCargando.Location = new Point(14, 120);
            pgCargando.Name = "pgCargando";
            pgCargando.Size = new Size(481, 10);
            pgCargando.Style = ProgressBarStyle.Marquee;
            pgCargando.TabIndex = 3;
            pgCargando.Visible = false;
            // 
            // AgregarImagen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 139);
            Controls.Add(pgCargando);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarImagen";
            StartPosition = FormStartPosition.CenterParent;
            Shown += AgregarImagen_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtRuta;
        private GroupBox groupBox1;
        private ProgressBar pgCargando;
    }
}