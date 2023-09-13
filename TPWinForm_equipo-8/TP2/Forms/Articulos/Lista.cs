using dominio;
using Negocio;

namespace TP2.Forms
{
    public partial class Lista : Form
    {
        private List<Articulo> articulos;

        private string[] imgs;

        private int idxImg;

        public Lista()
        {
            InitializeComponent();
            articulos = new List<Articulo>();
            imgs = Array.Empty<string>();
            idxImg = 0;
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            articulos = Articulos.Listar();
            dgvArticulos.Rows.Clear();
            pnlNavegacion.Visible = false;

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

                dgvArticulos.Rows[row].Cells["Imagenes"].Value = articulo.Imagenes.Aggregate("", (p, n) => $"{p};{n.Url}").TrimStart(';');
            }
        }

        private void btnGrabarNuevo_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).AbrirForm(new Agregar());
        }

        private void dgvArticulos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Limpiamos posible imagen anterior.
            picImagen.Image = null;
            pnlNavegacion.Visible = false;
            imgs = Array.Empty<string>();

            // Evitamos el error cuando hacen click en la esq superior izquierda (no sé cómo se llama).
            if (e.RowIndex < 0) return;

            string imagenes = (string)dgvArticulos.Rows[e.RowIndex].Cells["Imagenes"].Value;

            // Si no tiene imagenes, salimos.
            if (imagenes.Trim().Length == 0) return;

            // Damos soporte para multiples imagenes para un mismo articulo.
            imgs = imagenes.Split(";");

            // Safety check -> No deberia pasar nunca (deberia haber salido antes)
            if (imgs.Length == 0) return;

            // La navegacion solamente tendria sentido cuando hay mas de una imagen a mostrar.
            pnlNavegacion.Visible = imgs.Length > 1;

            idxImg = 0;
            MostrarImagen();
        }

        private void btnNavIzq_Click(object sender, EventArgs e)
        {
            if (idxImg - 1 >= 0)
            {
                idxImg--;
                MostrarImagen();
            }
        }

        private void btnNavDer_Click(object sender, EventArgs e)
        {
            if (idxImg + 1 < imgs.Length)
            {
                idxImg++;
                MostrarImagen();
            }
        }

        private void MostrarImagen()
        {
            try
            {
                picImagen.Load(imgs[idxImg]);
            }
            catch (Exception)
            {
                // Se intenta ir a alguna imagen valida (Caso del Articulo con ID == 2).
                if (idxImg > 0) {
                    btnNavIzq.PerformClick();
                }
                else
                {
                    btnNavDer.PerformClick();
                }
                return;
            }
        }
    }
}
