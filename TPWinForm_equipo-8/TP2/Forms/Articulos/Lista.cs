using dominio;
using Negocio;

namespace TP2.Forms
{
    public partial class Lista : Form
    {
        private List<Articulo>? articulos;

        public Lista()
        {
            InitializeComponent();
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            articulos = Articulos.Listar();
            dgvArticulos.Rows.Clear();

            foreach (var articulo in articulos)
            {
                int row = dgvArticulos.Rows.Add();
                dgvArticulos.Rows[row].Cells["Id"].Value = articulo.Id;
                dgvArticulos.Rows[row].Cells["Codigo"].Value = articulo.Codigo;
                dgvArticulos.Rows[row].Cells["Nombre"].Value = articulo.Nombre;
                dgvArticulos.Rows[row].Cells["Descripcion"].Value = articulo.Descripcion;
                dgvArticulos.Rows[row].Cells["Categoria"].Value = articulo.Categoria;
                dgvArticulos.Rows[row].Cells["IdCategoria"].Value = articulo.IdCategoria;
                dgvArticulos.Rows[row].Cells["Marca"].Value = articulo.Marca;
                dgvArticulos.Rows[row].Cells["IdMarca"].Value = articulo.IdMarca;
            }
        }
    }
}
