using PrecargadoDeInformacion.GUI;

namespace PrecargadoDeInformacion
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show(this);
            Hide();
        }
    }
}