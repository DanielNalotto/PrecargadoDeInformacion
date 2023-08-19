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
        Usuario usuario;
        string user;
        int id;

        public InformacionUsuario(string user)
        {
            InitializeComponent();
            this.user = user;
            usuario = new Usuario();
        }

        public InformacionUsuario(int id)
        {
            InitializeComponent();
            this.id = id;
            usuario = new Usuario();
        }

        private void regresarAgregarUsuario()
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
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
                AgregarUsuario agregarUsuario = new AgregarUsuario(this.user, txtTel.Text, txtMail.Text, txtCalle.Text, txtPuerta.Text);
                agregarUsuario.Show(Owner);
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAgregarUsuario();
        }
    }
}
