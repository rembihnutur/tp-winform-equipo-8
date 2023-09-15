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
        private List<Categoria>? categorias;
        private List<Marca>? marcas;

        public string campo = "";
        public string criterio = "";
        public string filtro = "";
        public string filtro2 = "";
        public bool busqueda = false;

        public Buscar()
        {
            InitializeComponent();
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if(cboCriterio.Text == "Entre")
                {                    
                    if(!(soloNumeros(txtFiltro2.Text)) && txtFiltro2.Text.Length > 0)
                    {
                        MessageBox.Show("Solo nros para filtrar por precio en ambos campos");
                        return true;
                    }                        
                }

                if (!(soloNumeros(txtFiltro.Text)) && txtFiltro.Text.Length > 0)
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }             
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Marca");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarFiltro())
                    return;
                campo = cboCampo.SelectedItem.ToString();
                criterio = cboCriterio.SelectedItem.ToString();
                if (campo == "Precio")
                {
                    filtro = txtFiltro.Text;
                    if (cboCriterio.SelectedItem.ToString() == "Entre")
                    {
                        filtro2 = txtFiltro2.Text;
                    }

                }
                busqueda = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string campo = cboCampo.SelectedItem.ToString();

                if (campo == "Categoria")
                {
                    txtFiltro.Enabled = false;
                    txtFiltro2.Enabled = false;
                    categorias = Negocio.Categorias.Listar();

                    cboCriterio.Items.Clear();
                    foreach (var categoria in categorias)
                    {
                        cboCriterio.Items.Add(categoria.Descripcion);
                    }
                }

                if (campo == "Marca")
                {
                    txtFiltro.Enabled = false;
                    txtFiltro2.Enabled = false;
                    marcas = Negocio.Marcas.Listar();

                    cboCriterio.Items.Clear();
                    foreach (var marca in marcas)
                    {
                        cboCriterio.Items.Add(marca.Descripcion);
                    }
                }

                if (campo == "Precio")
                {
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Menor que");
                    cboCriterio.Items.Add("Mayor que");
                    cboCriterio.Items.Add("Entre");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = cboCriterio.SelectedItem.ToString();
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                txtFiltro.Enabled = true;
                txtFiltro2.Enabled = false;
                if (criterio == "Entre")
                {
                    txtFiltro2.Enabled = true;
                }
            }
        }
    }
}
