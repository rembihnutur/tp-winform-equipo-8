using dominio;
using Negocio;
using TP2.Forms.Articulos;
using TP2.Interfaces;

namespace TP2.Forms

{
    public partial class Agregar : Form, IAgregarImagen
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación minima de que haya algo cargado.
            foreach (Control ctrl in new Control[] { txtCodigo, txtDescripcion, txtNombre, txtPrecio })
            {
                if (ctrl.Text.Trim().Length == 0)
                {
                    MessageBox.Show(string.Format("Debe indicar algún valor para {0}", ctrl.Name.Replace("txt", "")), "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ctrl.Focus();
                    return;
                }
            }

            if ((int)cmbMarca.SelectedValue < 1)
            {
                MessageBox.Show("Debe indicar alga Marca", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbMarca.DroppedDown = true;
                return;
            }

            if ((int)cmbCategoria.SelectedValue < 1)
            {
                MessageBox.Show("Debe indicar alguna Categoría", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbCategoria.DroppedDown = true;
                return;
            }

            // Evitamos duplicado de articulos
            if (Negocio.Articulos.Existe(txtCodigo.Text))
            {
                MessageBox.Show("Ya existe un Articulo con este Código", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Armamos el objeto que vamos a grabar.
            Articulo articulo = new Articulo()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                IdCategoria = (int)cmbCategoria.SelectedValue,
                IdMarca = (int)cmbMarca.SelectedValue,
                Imagenes = new List<Imagen> { }
            };

            foreach (DataGridViewRow fila in dgvArticulos.Rows)
            {
                articulo.Imagenes.Add(new Imagen
                {
                    Url = (string)fila.Cells["Ruta"].Value,
                });
            }

            // Chequeamos que se haya podido grabar. Faltaría chequear posibles excepciones.
            if (!Negocio.Articulos.Grabar(articulo))
            {
                MessageBox.Show("No se ha podido grabar correctamente el Articulo", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Limpiamos el formulario
            foreach (Control ctrl in new Control[] { txtCodigo, txtDescripcion, txtNombre, txtPrecio })
            {
                ctrl.Text = "";
            }

            cmbMarca.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("Articulo grabado con éxito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerramos el formulario pasando el flujo del programa hacia el listado de los Articulos.
            ((Form1)ParentForm).AbrirForm(new Lista());
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigo.Text.Trim().Length == 0) return;

                if (Negocio.Articulos.Existe(txtCodigo.Text))
                {
                    MessageBox.Show("Ya existe un Articulo con este Código", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNombre.Text.Trim().Length == 0) return;

                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDescripcion.Text.Trim().Length == 0) return;

                cmbMarca.Focus();
            }
        }

        private void cmbMarca_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex < 0) return;

            cmbCategoria.Focus();
        }

        private void cmbCategoria_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex < 0) return;

            txtPrecio.Focus();
        }

        private void FormAgregar_Shown(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            List<Marca> marcas = Marcas.Listar();
            marcas.Prepend(new Marca { });
            cmbMarca.DataSource = marcas;
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Descripcion";

            List<Categoria> categorias = Categorias.Listar();
            categorias.Prepend(new Categoria { });
            cmbCategoria.DataSource = categorias;
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Descripcion";

            // Sabemos que por lo menos una de cada una vamos a tener seguro (por el .append).
            cmbMarca.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;

            txtPrecio.Maximum = decimal.MaxValue;
            txtPrecio.Minimum = 0;
        }

        public void AgregarImagen(PictureBox pic)
        {
            try
            {
                dgvArticulos.Rows.Add("", (Image)pic.Image, pic.ImageLocation);
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new AgregarImagen();
            frm.Owner = this;
            frm.Show();
        }
    }
}
