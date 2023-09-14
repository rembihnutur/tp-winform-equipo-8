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
            AbrirForm(new Forms.Lista());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLista.PerformClick();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.ListaMarcas());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.ListaCategorias());
        }
    }
}