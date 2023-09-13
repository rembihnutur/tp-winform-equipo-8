using dominio;
using Negocio;

namespace TP2.Forms
{
    public partial class Agregar : Form
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
                    // XXX: Colocar algun mensaje?
                    return;
                }
            }

            if ((int)cmbMarca.SelectedValue < 1) return;
            if ((int)cmbCategoria.SelectedValue < 1) return;

            // Armamos el objeto que vamos a grabar.
            Articulo articulo = new Articulo()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = double.Parse(txtPrecio.Text),
                IdCategoria = (int)cmbCategoria.SelectedValue,
                IdMarca = (int)cmbMarca.SelectedValue
            };
            
            // Chequeamos que se haya podido grabar. Faltaría chequear posibles excepciones.
            if (!Negocio.Articulos.Grabar(articulo))
            {
                MessageBox.Show("No se ha podido grabar correctamente el Articulo");
            }

            // Limpiamos el formulario
            foreach (Control ctrl in new Control[] { txtCodigo, txtDescripcion, txtNombre, txtPrecio })
            {
                ctrl.Text = "";
            }

            cmbMarca.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;

            // Devolvemos el foco al primer control.
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigo.Text.Trim().Length == 0) return;

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
        }
    }
}
