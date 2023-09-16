using dominio;
using Negocio;
using System.Data.SqlClient;

namespace TP2.Forms
{
    public partial class ListaCategorias : Form
    {
        private List<Categoria> categorias;

        public ListaCategorias()
        {
            InitializeComponent();
            cargar();
        }

        private void cargar()
        {

            try
            {
                categorias = Categorias.Listar();
                dgvListaCategorias.Rows.Clear();

                foreach (var cat in categorias)
                {
                    int row = dgvListaCategorias.Rows.Add();
                    dgvListaCategorias.Rows[row].Cells["Id"].Value = cat.Id;
                    dgvListaCategorias.Columns["Id"].Visible = false;
                    dgvListaCategorias.Rows[row].Cells["Descripcion"].Value = cat.Descripcion;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvListaCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void mostrarEditar()
        {
            lblDescripcion.Visible = true;
            tbDescripcion.Visible = true;
            btnGuardar.Visible = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvListaCategorias.Top = 250;
        }

        private void ocultarEditar()
        {
            lblDescripcion.Visible = false;
            tbDescripcion.Visible = false;
            btnGuardar.Visible = false;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = true;

            dgvListaCategorias.Top = 60;
        }

        private void mostrarAgregar()
        {
            lblDescripcion.Visible = true;
            tbDescripcion.Visible = true;
            btnGuardarAgregar.Visible = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvListaCategorias.Top = 250;
        }

        private void ocultarAgregar()
        {
            lblDescripcion.Visible = false;
            tbDescripcion.Visible = false;
            btnGuardarAgregar.Visible = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;

            dgvListaCategorias.Top = 60;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            mostrarEditar();

            if (dgvListaCategorias.SelectedRows.Count > 0)
            {
                tbDescripcion.Text = dgvListaCategorias.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                lblCategoriaId.Text = dgvListaCategorias.SelectedRows[0].Cells["Id"].Value.ToString();
            }

            else if (dgvListaCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoria.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Descripcion = tbDescripcion.Text;
            categoria.Id = Convert.ToInt32(lblCategoriaId.Text);
            Negocio.Categorias.Editar(categoria);

            MessageBox.Show("Categoria editada exitosamente.");

            ocultarEditar();
            cargar();
            dgvListaCategorias.Update();
            dgvListaCategorias.Refresh();
        }

        private void btnGuardarAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Descripcion = tbDescripcion.Text;
            Negocio.Categorias.Grabar(categoria);

            MessageBox.Show("Categoria agregada exitosamente.");

            ocultarAgregar();
            cargar();
            dgvListaCategorias.Update();
            dgvListaCategorias.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarAgregar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaCategorias.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar la categoria " + dgvListaCategorias.SelectedRows[0].Cells["Descripcion"].Value.ToString() + "?", "Eliminar categoria", MessageBoxButtons.YesNo);
                switch (resultado)
                {
                    case DialogResult.Yes:
                        try
                        {
                            int idCategoria = (int)dgvListaCategorias.SelectedRows[0].Cells["Id"].Value;
                            // Aca va la funcion de eliminar.
                            Negocio.Categorias.Eliminar(idCategoria);
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

            else if (dgvListaCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una marca.");
            }
        }
    }
}