using dominio;
using Negocio;

namespace TP2.Forms
{
    public partial class Lista : Form
    {
        private List<Articulo> articulos;

        public Lista()
        {
            InitializeComponent();
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            cargar();
            ocultarColumna();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Codigo");
        }

        private void cargar()
        {
            try
            {
                articulos = Negocio.Articulos.Listar();
                dgvArticulos.Rows.Clear();

                foreach (var articulo in articulos)
                {
                    int row = dgvArticulos.Rows.Add();
                    dgvArticulos.Rows[row].Cells["Id"].Value = articulo.Id;
                    dgvArticulos.Columns["Id"].Visible = false;
                    dgvArticulos.Rows[row].Cells["Codigo"].Value = articulo.Codigo;
                    dgvArticulos.Rows[row].Cells["Nombre"].Value = articulo.Nombre;
                    dgvArticulos.Rows[row].Cells["Descripcion"].Value = articulo.Descripcion;
                    dgvArticulos.Rows[row].Cells["Categoria"].Value = articulo.Categoria;
                    dgvArticulos.Rows[row].Cells["IdCategoria"].Value = articulo.IdCategoria;
                    dgvArticulos.Rows[row].Cells["Marca"].Value = articulo.Marca;
                    dgvArticulos.Rows[row].Cells["IdMarca"].Value = articulo.IdMarca;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ocultarColumna()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;
        }

        private List<Articulo> filtrarPorCampo(string campo, string filtro)
        {
            List<Articulo> articulosFiltrados;
            if (campo == "Nombre")
            {
                return articulosFiltrados = articulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
            }
            if (campo == "Descripcion")
            {
                return articulosFiltrados = articulos.FindAll(x => x.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            return articulosFiltrados = articulos.FindAll(x => x.Codigo.ToLower().Contains(filtro.ToLower()));
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> articulosFiltrados;
            string campo = cboCampo.SelectedItem?.ToString();
            if (campo == null)
            {
                txtFiltro.Text = "";
                MessageBox.Show("Es obligatorio seleccionar algun campo");
                return;
            }
            string filtro = txtFiltro.Text;
            if (filtro.Length >= 2)
            {
                articulosFiltrados = filtrarPorCampo(campo, filtro);
            }
            else
            {
                articulosFiltrados = articulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articulosFiltrados;
            ocultarColumna();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
