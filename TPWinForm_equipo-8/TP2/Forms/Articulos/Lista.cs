using dominio;
using Negocio;
using System.Data.SqlClient;
using TP2.Interfaces;

namespace TP2.Forms
{
    public partial class Lista : Form, IAgregarImagen
    {
        private List<Articulo> articulos;
        private List<Marca>? marcas;
        private List<Categoria>? categorias;

        private List<Imagen> imgs;

        private int idxImg;

        public Lista()
        {
            InitializeComponent();

            articulos = new List<Articulo>();
            imgs = new List<Imagen>() { };
            idxImg = 0;
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            pnlNavegacion.Visible = false;

            nudPrecio.Maximum = decimal.MaxValue;
            nudPrecio.Minimum = 0;

            cargar();
            dgvArticulos.ClearSelection();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Codigo");
        }

        public void cargar()
        {
            try
            {
                articulos = Negocio.Articulos.Listar();
                dgvArticulos.DataSource = articulos;
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
            imgs = new List<Imagen>() { };

            // Evitamos el error cuando hacen click en la esq superior izquierda (no sé cómo se llama).
            if (e.RowIndex < 0) return;

            if (dgvArticulos.Rows[e.RowIndex].Cells["Imagenes"].Value == null) return;

            imgs = ((List<Imagen>)dgvArticulos.Rows[e.RowIndex].Cells["Imagenes"].Value);

            // Si no tiene imagenes, salimos.
            if (imgs.Count == 0) return;

            // La navegacion solamente tendria sentido cuando hay mas de una imagen a mostrar.
            pnlNavegacion.Visible = imgs.Count > 1;

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
            if (idxImg + 1 < imgs.Count)
            {
                idxImg++;
                MostrarImagen();
            }
        }

        private void MostrarImagen()
        {
            try
            {
                // Mostramos una barra de carga por si la conexion a internet no es muy buena y tarda mas de un par de segundos en cargarnos la imagen.
                pnlCargaImagen.Visible = true;

                picImagen.Load(imgs[idxImg].Url);

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
            finally
            {
                pnlCargaImagen.Visible = false;
            }
        }

        private List<Articulo> filtrarPorCampo(string campo, string filtro)
        {
            List<Articulo> articulosFiltrados;

            if (campo == "Nombre")
            {
                return articulosFiltrados = articulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
            }
            else if (campo == "Descripcion")
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

            pnlCargaImagen.Visible = false;
            pnlNavegacion.Visible = false;

            dgvArticulos.Top = 400;
            picImagen.Top = 400;

            gbEditar.Visible = true;
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
            gbEditar.Visible = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un articulo.");
                return;
            }

            mostrarEditar();

            marcas = Marcas.Listar();
            marcas.Append(new Marca() { });
            cbMarca.DataSource = marcas;
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";

            categorias = Categorias.Listar();
            categorias.Append(new Categoria() { });
            cbCategoria.DataSource = categorias;
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descripcion";

            tbCodigo.Text = dgvArticulos.SelectedRows[0].Cells["Codigo"].Value.ToString();
            tbNombre.Text = dgvArticulos.SelectedRows[0].Cells["Nombre"].Value.ToString();
            tbDescripcion.Text = dgvArticulos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            nudPrecio.Value = (decimal)dgvArticulos.SelectedRows[0].Cells["Precio"].Value;

            cbCategoria.SelectedValue = (int)dgvArticulos.SelectedRows[0].Cells["IdCategoria"].Value;
            cbMarca.SelectedValue = (int)dgvArticulos.SelectedRows[0].Cells["IdMarca"].Value;

            var imgs = Negocio.Imagenes.ByArticuloId((int)dgvArticulos.SelectedRows[0].Cells["Id"].Value);
            foreach (Imagen img in imgs)
            {
                try
                {
                    var pic = new PictureBox();
                    pic.Load(img.Url);
                    Image imagen = (Image)pic.Image;
                    dgvImagenes.Rows.Add(img.Id, imagen, img.Url);
                }
                catch (Exception)
                {
                    continue;
                }
            }
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
            articulo.Imagenes = new List<Imagen> { };

            foreach (DataGridViewRow fila in dgvImagenes.Rows)
            {
                articulo.Imagenes.Add(new Imagen
                {
                    Url = (string)fila.Cells["Ruta"].Value,
                });
            }

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
            if (dgvArticulos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un articulo.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar el articulo " + dgvArticulos.SelectedRows[0].Cells["Nombre"].Value.ToString() + "?", "Eliminar articulo", MessageBoxButtons.YesNo);
            switch (resultado)
            {
                case DialogResult.Yes:
                    try
                    {
                        // Aca va la funcion de eliminar.
                        string idArticulo = (string)dgvArticulos.SelectedRows[0].Cells["Id"].Value;
                        Negocio.Articulos.Eliminar(idArticulo);
                        MessageBox.Show("Eliminado.");
                        cargar();
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

        private void dgvImagenes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (MessageBox.Show("¿Desea eliminar la imagen?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvImagenes.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Forms.Articulos.AgregarImagen();
            frm.Owner = this;
            frm.Show();
        }

        public void AgregarImagen(PictureBox pic)
        {
            try
            {
                dgvImagenes.Rows.Add("", (Image)pic.Image, pic.ImageLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la imagen. Por favor, corrobore la URL suministrada y vuelva a intentar.\nError: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void filtrosBusqueda(Articulos.Buscar parametros)
        {
            try
            {
                if (!parametros.busqueda) return;
                string campo = parametros.campo, criterio = parametros.criterio, filtro1 = parametros.filtro, filtro2 = parametros.filtro2;
                articulos = Negocio.Articulos.Filtrar(campo, criterio, filtro1, filtro2);
                dgvArticulos.DataSource = articulos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Enabled = true;
        }

        private void txtFiltro_Leave(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            cboCampo.SelectedItem = null;
        }
    }
}
