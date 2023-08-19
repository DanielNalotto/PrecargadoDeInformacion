using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecargadoDeInformacion.GUI
{
    public partial class InformacionUsuario : Form
    {
        public InformacionUsuario()
        {
            InitializeComponent();
        }

        private void regresarAgregarUsuario()
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show(Owner);
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            regresarAgregarUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAgregarUsuario();
        }
    }
}
