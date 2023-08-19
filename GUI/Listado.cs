using PrecargadoDeInformacion.GUI;
using PrecargadoDeInformacion.Logica;

namespace PrecargadoDeInformacion
{
    public partial class Listado : Form
    {
        Usuario usuario = new Usuario();
        public Listado()
        {
            InitializeComponent();
        }




        private void cargarDatos()
        {
            dgv.Rows.Clear();
            List<Usuario> usuarios = usuario.obtenerUsuarios();
            foreach (var usuario in usuarios)
            {
                dgv.Rows.Add(usuario.Id, usuario.Nombre, usuario.Tel, usuario.Mail, usuario.Calle, usuario.NroPuerta);
            }
        }






        private void btnAlta_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show(this);
            Hide();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show(this);
            Hide();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}