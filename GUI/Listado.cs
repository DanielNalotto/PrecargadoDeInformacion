using Microsoft.VisualBasic.ApplicationServices;
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


        ///  ------------------------- METODOS AUXILIARES ----------------------------
        private void cargarDatos()
        {
            dgv.Rows.Clear();
            List<Usuario> usuarios = usuario.obtenerUsuarios();
            foreach (var usuario in usuarios)
            {
                dgv.Rows.Add(usuario.Id, usuario.Nombre, usuario.Tel, usuario.Mail, usuario.Calle, usuario.NroPuerta);
            }
        }

        private Usuario seleccionarUsuario()
        {
            string user, mail, calle;
            int id, tel, nroPuerta;

            id = Convert.ToInt32(dgv.SelectedCells[0].Value);
            user = dgv.SelectedCells[1].Value.ToString();
            tel = Convert.ToInt32(dgv.SelectedCells[2].Value);
            mail = dgv.SelectedCells[3].Value.ToString();
            calle = dgv.SelectedCells[4].Value.ToString();
            nroPuerta = Convert.ToInt32(dgv.SelectedCells[5].Value);

            return new Usuario(id, user, tel, mail, calle, nroPuerta);
        }






        private void btnAlta_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario(true);
            agregarUsuario.Show(this);
            Hide();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Usuario usuario = seleccionarUsuario();
            AgregarUsuario agregarUsuario = new AgregarUsuario(usuario.Id, usuario.Nombre, usuario.Tel, usuario.Mail, usuario.Calle, usuario.NroPuerta, false);
            agregarUsuario.Show(this);
            Hide();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}