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
    public partial class InformacionUsuario : Form
    {
        Usuario usuario = new Usuario();
        bool ingresar;

        public InformacionUsuario(string user, int tel, string mail, string calle, int nroPuerta, bool ingresar)
        {
            InitializeComponent();
            usuario.Nombre = user;
            usuario.Tel = tel;
            usuario.Mail = mail;
            usuario.Calle = calle;
            usuario.NroPuerta = nroPuerta;
            this.ingresar = ingresar;
        }

        public InformacionUsuario(int id, string user, int tel, string mail, string calle, int nroPuerta, bool ingresar)
        {
            InitializeComponent();
            usuario.Id = id;
            usuario.Nombre = user;
            usuario.Tel = tel;
            usuario.Mail = mail;
            usuario.Calle = calle;
            usuario.NroPuerta = nroPuerta;
            this.ingresar = ingresar;
            cargarDatos();
        }
        private void regresarAgregarUsuario(Usuario newUser)
        {
            AgregarUsuario agregarUsuario;
            if (this.ingresar)
                agregarUsuario = new AgregarUsuario(newUser.Nombre, newUser.Tel, newUser.Mail, newUser.Calle, newUser.NroPuerta, this.ingresar);
            else
                agregarUsuario = new AgregarUsuario(usuario.Id, newUser.Nombre, newUser.Tel, newUser.Mail, newUser.Calle, newUser.NroPuerta, this.ingresar);
            agregarUsuario.Show(Owner);
            Close();
        }

        private void marcarIncorrecto(bool correcto, Label lbl)
        {
            if (correcto)
                lbl.ForeColor = Color.Black;
            else
                lbl.ForeColor = Color.Red;
        }

        private void cargarDatos()
        {
            txtTel.Text = usuario.Tel.ToString();
            txtMail.Text = usuario.Mail;
            txtCalle.Text = usuario.Calle;
            txtPuerta.Text = usuario.NroPuerta.ToString();
        }

        private bool validarDatos()
        {
            bool tel = usuario.validarTel(txtTel.Text);
            bool mail = usuario.validarMail(txtMail.Text);
            bool calle = usuario.validarCalle(txtCalle.Text);
            bool nroPuerta = usuario.validarNroPuerta(txtPuerta.Text);
            marcarIncorrecto(tel, lblTel);
            marcarIncorrecto(mail, lblMail);
            marcarIncorrecto(calle, lblCalle);
            marcarIncorrecto(nroPuerta, lblPuerta);
            return tel && mail && calle && nroPuerta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Usuario newUser = usuario.crearUsuario(usuario.Nombre, txtTel.Text, txtMail.Text, txtCalle.Text, txtPuerta.Text);
                regresarAgregarUsuario(newUser);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAgregarUsuario(usuario);
        }
    }
}
