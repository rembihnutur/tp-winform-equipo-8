using dominio;
using Negocio;
using System.Data.SqlClient;

namespace TP2.Forms
{
    public partial class ListaMarcas : Form
    {
        private List<Marca> marcas;
        public ListaMarcas()
        {
            InitializeComponent();
            cargar();
        }

        private void FormListaMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            try
            {
                marcas = Negocio.Marcas.Listar();
                dgvListaMarcas.Rows.Clear();

                foreach (var marca in marcas)
                {
                    int row = dgvListaMarcas.Rows.Add();
                    dgvListaMarcas.Rows[row].Cells["Id"].Value = marca.Id;
                    dgvListaMarcas.Columns["Id"].Visible = false;
                    dgvListaMarcas.Rows[row].Cells["Descripcion"].Value = marca.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListaMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarEditar()
        {
            lblDescripcion.Visible = true;
            tbDescripcion.Visible = true;
            btnGuardar.Visible = true;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;

            dgvListaMarcas.Top = 250;
        }

        private void ocultarEditar()
        {
            lblDescripcion.Visible = false;
            tbDescripcion.Visible = false;
            btnGuardar.Visible = false;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = true;

            dgvListaMarcas.Top = 65;
        }

        private void mostrarAgregar()
        {
            lblDescripcion.Visible = true;
            tbDescripcion.Visible = true;
            btnGuardarAgregar.Visible = true;

            dgvListaMarcas.Top = 250;
        }

        private void ocultarAgregar()
        {
            lblDescripcion.Visible = false;
            tbDescripcion.Visible = false;
            btnGuardarAgregar.Visible = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;

            dgvListaMarcas.Top = 65;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            mostrarEditar();

            if (dgvListaMarcas.SelectedRows.Count > 0)
            {
                tbDescripcion.Text = dgvListaMarcas.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                lblCategoriaId.Text = dgvListaMarcas.SelectedRows[0].Cells["Id"].Value.ToString();
            }

            else if (dgvListaMarcas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una marca.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Descripcion = tbDescripcion.Text;
            marca.Id = Convert.ToInt32(lblCategoriaId.Text);
            Negocio.Marcas.Editar(marca);

            MessageBox.Show("Marca editada exitosamente.");

            ocultarEditar();
            cargar();
            dgvListaMarcas.Update();
            dgvListaMarcas.Refresh();
        }

        private void btnGuardarAgregar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Descripcion = tbDescripcion.Text;
            Negocio.Marcas.Grabar(marca);

            MessageBox.Show("Marca agregada exitosamente.");

            ocultarAgregar();
            cargar();
            dgvListaMarcas.Update();
            dgvListaMarcas.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            mostrarAgregar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaMarcas.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar la marca " + dgvListaMarcas.SelectedRows[0].Cells["Descripcion"].Value.ToString() + "?", "Eliminar marca", MessageBoxButtons.YesNo);
                switch (resultado)
                {
                    case DialogResult.Yes:
                        try
                        {
                            int idMarca = (int)dgvListaMarcas.SelectedRows[0].Cells["Id"].Value;
                            // Aca va la funcion de eliminar.
                            Negocio.Marcas.Eliminar(idMarca);
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

            else if (dgvListaMarcas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una marca.");
            }
        }
    }
}
