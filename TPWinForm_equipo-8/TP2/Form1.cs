using dominio;
using Negocio;
using TP2.Forms;
using TP2.Forms.Articulos;

namespace TP2
{
    public partial class Form1 : Form
    {

        private Form? formActivo;
        private Lista lista = new Forms.Lista();


        public Form1()
        {
            InitializeComponent();
            formActivo = null;
        }

        public void AbrirForm(Form childForm)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            lblInicio.Text = childForm.Text;
        }
        private void btnLista_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            lista = new Forms.Lista();
            AbrirForm(lista);

        }

        public void desactivateBtnBuscar ()
        {
            btnBuscar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLista.PerformClick();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            AbrirForm(new Forms.ListaMarcas());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            AbrirForm(new Forms.ListaCategorias());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.ShowDialog();
            lista.filtrosBusqueda(buscar);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.Acerca());
        }
    }
}