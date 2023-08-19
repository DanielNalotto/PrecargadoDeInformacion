using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrecargadoDeInformacion.Logica;

namespace PrecargadoDeInformacion.GUI
{
    public partial class AgregarUsuario : Form
    {
        Usuario usuario;
        
        public AgregarUsuario()
        {
            usuario = new Usuario();
            InitializeComponent();
        }

        public AgregarUsuario(string user, string tel, string mail, string calle, string nroPuerta)
        {
            InitializeComponent();
            usuario = new Usuario();
            cargarInformacion(user, tel, mail, calle, nroPuerta);
        }

        private void cargarInformacion(string user, string tel, string mail, string calle, string nroPuerta)
        {
            txtUser.Text = user;
            txtTel.Text = tel;
            txtMail.Text = mail;
            txtCalle.Text = calle;
            txtNroPuerta.Text = nroPuerta;
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            InformacionUsuario informacionUsuario = new InformacionUsuario(txtUser.Text);
            informacionUsuario.Show(Owner);
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (usuario.validarNombre(txtUser.Text))
            {
                usuario.crearUsuario(txtUser.Text, txtTel.Text, txtMail.Text, txtCalle.Text, txtNroPuerta.Text);
                MessageBox.Show("Se guardaron los datos");
                Listado listado = new Listado();
                listado.Show(Owner);
                Close();
            }
            else
            {
                MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
    }
}
