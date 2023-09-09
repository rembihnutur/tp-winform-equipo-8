namespace TP2
{
    public partial class Form1 : Form
    {

        private Form formActivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.FormListaProductos(), sender);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms.FormAgregar(), sender);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {

        }
    }
}