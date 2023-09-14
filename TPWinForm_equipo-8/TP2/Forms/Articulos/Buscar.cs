using dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2.Forms.Articulos
{
    public partial class Buscar : Form
    {
        private List<Articulo> articulos;

        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            try
            {
                articulos = Negocio.Articulos.Listar();
                dgvBuscarArticulos.Rows.Clear();

                foreach (var articulo in articulos)
                {
                    string precioFormateado = articulo.Precio.ToString("N3");
                    int row = dgvBuscarArticulos.Rows.Add();
                    dgvBuscarArticulos.Rows[row].Cells["Id"].Value = articulo.Id;
                    dgvBuscarArticulos.Columns["Id"].Visible = false;
                    dgvBuscarArticulos.Rows[row].Cells["Codigo"].Value = articulo.Codigo;
                    dgvBuscarArticulos.Rows[row].Cells["Nombre"].Value = articulo.Nombre;
                    dgvBuscarArticulos.Rows[row].Cells["Descripcion"].Value = articulo.Descripcion;
                    dgvBuscarArticulos.Rows[row].Cells["Categoria"].Value = articulo.Categoria;
                    dgvBuscarArticulos.Rows[row].Cells["Precio"].Value = precioFormateado;
                    dgvBuscarArticulos.Rows[row].Cells["IdCategoria"].Value = articulo.IdCategoria;
                    dgvBuscarArticulos.Rows[row].Cells["Marca"].Value = articulo.Marca;
                    dgvBuscarArticulos.Rows[row].Cells["IdMarca"].Value = articulo.IdMarca;
                    dgvBuscarArticulos.Rows[row].Cells["Imagenes"].Value = articulo.Imagenes.Aggregate("", (p, n) => $"{p};{n.Url}").TrimStart(';');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBuscarArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
