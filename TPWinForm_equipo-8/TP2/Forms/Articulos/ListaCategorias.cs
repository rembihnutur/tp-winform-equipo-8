using dominio;
using Negocio;

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
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvListaCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
