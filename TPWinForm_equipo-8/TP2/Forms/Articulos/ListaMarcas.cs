using dominio;
using Negocio;

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
    }
}
