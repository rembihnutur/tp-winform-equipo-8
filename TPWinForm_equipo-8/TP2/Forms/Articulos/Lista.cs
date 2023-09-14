using dominio;
using Negocio;
using System.Data.SqlClient;

namespace TP2.Forms
{
    public partial class Lista : Form
    {
        private List<Articulo> articulos;
        private List<Marca> marcas;
        private List<Categoria> categorias;

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
            articulos = Negocio.Articulos.Listar();
            dgvArticulos.Rows.Clear();
            pnlNavegacion.Visible = false;

            cargar();
            dgvArticulos.ClearSelection();
            ocultarColumna();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Codigo");
        }

        public void cargar()
        {
            try
            {
                articulos = Negocio.Articulos.Listar();
                dgvArticulos.Rows.Clear();

                foreach (var articulo in articulos)
                {
                    string precioFormateado = articulo.Precio.ToString("N3");
                    int row = dgvArticulos.Rows.Add();
                    dgvArticulos.Rows[row].Cells["Id"].Value = articulo.Id;
                    dgvArticulos.Columns["Id"].Visible = false;
                    dgvArticulos.Rows[row].Cells["Codigo"].Value = articulo.Codigo;
                    dgvArticulos.Rows[row].Cells["Nombre"].Value = articulo.Nombre;
                    dgvArticulos.Rows[row].Cells["Descripcion"].Value = articulo.Descripcion;
                    dgvArticulos.Rows[row].Cells["Categoria"].Value = articulo.Categoria;
                    dgvArticulos.Rows[row].Cells["Precio"].Value = precioFormateado;
                    dgvArticulos.Rows[row].Cells["IdCategoria"].Value = articulo.IdCategoria;
                    dgvArticulos.Rows[row].Cells["Marca"].Value = articulo.Marca;
                    dgvArticulos.Rows[row].Cells["IdMarca"].Value = articulo.IdMarca;
                    dgvArticulos.Rows[row].Cells["Precio"].Value = articulo.Precio;
                    dgvArticulos.Rows[row].Cells["Imagenes"].Value = articulo.Imagenes.Aggregate("", (p, n) => $"{p};{n.Url}").TrimStart(';');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (idxImg > 0)
                {
                    btnNavIzq.PerformClick();
                }
                else
                {
                    btnNavDer.PerformClick();
                }
                return;
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
            string? campo = cboCampo.SelectedItem?.ToString();
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
            dgvArticulos.DataSource = articulosFiltrados;
            ocultarColumna();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarEditar()
        {
            lblCodigo.Visible = true;
            lblNombre.Visible = true;
            lblDescripcion.Visible = true;
            lblMarca.Visible = true;
            lblCategoria.Visible = true;
            lblPrecio.Visible = true;
            tbCodigo.Visible = true;
            tbNombre.Visible = true;
            tbDescripcion.Visible = true;
            cbCategoria.Visible = true;
            cbMarca.Visible = true;
            nudPrecio.Visible = true;
            btnGuardar.Visible = true;

            dgvArticulos.Top = 250;
            picImagen.Top = 250;
        }

        private void ocultarEditar()
        {
            lblCodigo.Visible = false;
            lblNombre.Visible = false;
            lblDescripcion.Visible = false;
            lblMarca.Visible = false;
            lblCategoria.Visible = false;
            lblPrecio.Visible = false;
            tbCodigo.Visible = false;
            tbNombre.Visible = false;
            tbDescripcion.Visible = false;
            cbCategoria.Visible = false;
            cbMarca.Visible = false;
            nudPrecio.Visible = false;
            btnGuardar.Visible = false;

            dgvArticulos.Top = 60;
            picImagen.Top = 60;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            mostrarEditar();

            marcas = Marcas.Listar();
            cbMarca.DataSource = marcas;
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";

            categorias = Categorias.Listar();
            cbCategoria.DataSource = categorias;
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descripcion";

            if (dgvArticulos.SelectedRows.Count > 0)
            {
                tbCodigo.Text = dgvArticulos.SelectedRows[0].Cells["Codigo"].Value.ToString();
                tbNombre.Text = dgvArticulos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                tbDescripcion.Text = dgvArticulos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                nudPrecio.Text = dgvArticulos.SelectedRows[0].Cells["Precio"].Value.ToString();
            }

            else if (dgvArticulos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un articulo.");
            }
        }

        private void picImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Articulo articulo = new Articulo();
            articulo.Id = (int)dgvArticulos.SelectedRows[0].Cells["Id"].Value;
            articulo.Codigo = tbCodigo.Text;
            articulo.Nombre = tbNombre.Text;
            articulo.Descripcion = tbDescripcion.Text;
            articulo.Categoria = (string)cbCategoria.Text;
            articulo.Marca = (string)cbMarca.Text;
            articulo.IdMarca = Convert.ToInt32(cbMarca.SelectedValue);
            articulo.IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            articulo.Precio = (decimal)nudPrecio.Value;
            Negocio.Articulos.Editar(articulo);

            MessageBox.Show("Articulo editado exitosamente:\n" +
                            "Nombre: " + articulo.Nombre +
                            "\nDescripcion: " + articulo.Descripcion);

            ocultarEditar();
            cargar();
            dgvArticulos.Update();
            dgvArticulos.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar el articulo " + dgvArticulos.SelectedRows[0].Cells["Nombre"].Value.ToString() + "?", "Eliminar articulo", MessageBoxButtons.YesNo);
                switch (resultado)
                {
                    case DialogResult.Yes:
                        try
                        {
                            // Aca va la funcion de eliminar.
                            MessageBox.Show("Eliminado.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("No se pudo eliminar el registro. Error: " + ex.ToString());
                        }
                        break;
                    case DialogResult.No:
                        break;
                }

            }

            else if (dgvArticulos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un articulo.");
            }
        }
    }
}
