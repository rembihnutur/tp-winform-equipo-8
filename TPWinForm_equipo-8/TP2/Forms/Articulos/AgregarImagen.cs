using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.Interfaces;

namespace TP2.Forms.Articulos
{
    public partial class AgregarImagen : Form
    {
        public AgregarImagen()
        {
            InitializeComponent();
        }

        private void AgregarImagen_Shown(object sender, EventArgs e)
        {
            txtRuta.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text.Trim().Length > 0)
            {
                try
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    pgCargando.Visible = true;

                    // Validamos que la imagen exista y pueda cargarse.
                    PictureBox pic = new PictureBox();
                    pic.Load(txtRuta.Text);

                    ((IAgregarImagen)Owner).AgregarImagen(pic);

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No es posible agregar este tipo de imagen");
                }
                finally
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    pgCargando.Visible = false;
                }
            }
        }

        private void txtRuta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
