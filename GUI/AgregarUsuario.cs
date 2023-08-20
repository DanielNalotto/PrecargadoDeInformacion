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
        bool ingresar;
        
        public AgregarUsuario(bool ingresar)
        {
            usuario = new Usuario();
            InitializeComponent();
            this.ingresar = ingresar;
        }

        public AgregarUsuario(string user, int tel, string mail, string calle, int nroPuerta, bool ingresar)
        {
            InitializeComponent();
            usuario = new Usuario();
            usuario.Nombre = user;
            usuario.Tel = tel;
            usuario.Mail = mail;
            usuario.Calle = calle;
            usuario.NroPuerta = nroPuerta;
            cargarInformacion();
            this.ingresar = ingresar;
        }

        public AgregarUsuario(int id, string user, int tel, string mail, string calle, int nroPuerta, bool ingresar)
        {
            InitializeComponent();
            usuario = new Usuario();
            usuario.Id = id;
            usuario.Nombre = user;
            usuario.Tel = tel;
            usuario.Mail = mail;
            usuario.Calle = calle;
            usuario.NroPuerta = nroPuerta;
            cargarInformacion();
            this.ingresar = ingresar;
        }

        private void cargarInformacion()
        {
            txtUser.Text = usuario.Nombre;
            txtTel.Text = usuario.Tel.ToString();
            txtMail.Text = usuario.Mail;
            txtCalle.Text = usuario.Calle;
            txtNroPuerta.Text = usuario.NroPuerta.ToString();

            /*txtUser.Text = user;
            txtTel.Text = tel;
            txtMail.Text = mail;
            txtCalle.Text = calle;
            txtNroPuerta.Text = nroPuerta;*/
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            InformacionUsuario informacionUsuario;
            if (this.ingresar)
            {
                usuario = usuario.crearUsuario(txtUser.Text, txtTel.Text, txtMail.Text, txtCalle.Text, txtNroPuerta.Text);
                informacionUsuario = new InformacionUsuario(usuario.Nombre, usuario.Tel, usuario.Mail, usuario.Calle, usuario.NroPuerta, this.ingresar);
            }
            else
            {
                informacionUsuario = new InformacionUsuario(usuario.Id, usuario.Nombre, usuario.Tel, usuario.Mail, usuario.Calle, usuario.NroPuerta, this.ingresar);
            }

            informacionUsuario.Show(Owner);
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (usuario.validarNombre(txtUser.Text))
            {
                Usuario nuevoUsuario = usuario.crearUsuario(txtUser.Text, txtTel.Text, txtMail.Text, txtCalle.Text, txtNroPuerta.Text);
                nuevoUsuario.Id = usuario.Id;

                if (ingresar)
                {
                    bool resultado = usuario.ingresarUsuario(nuevoUsuario);
                    if (resultado)
                        MessageBox.Show("Se guardaron los datos");
                    else
                        MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool resultado = usuario.modificarUsuario(nuevoUsuario);
                    if (resultado)
                        MessageBox.Show("Se modificaron los datos");
                    else
                        MessageBox.Show("No se modificaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Listado listado = new Listado();
            listado.Show(Owner);
            Close();           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
    }
}
