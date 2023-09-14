using dominio;
using Negocio;
using TP2.Forms;

namespace TP2
{
    public partial class Form1 : Form
    {

        private Form? formActivo;

        public Form1()
        {
            InitializeComponent();
            formActivo = null;
        }

        private void AbrirForm(Form childForm, object btnSender)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblInicio.Text = childForm.Text;
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.Lista(), sender);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.Agregar(), sender);
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.ListaMarcas(), sender);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.ListaCategorias(), sender);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.Articulos.Buscar(), sender);
        }
    }
}