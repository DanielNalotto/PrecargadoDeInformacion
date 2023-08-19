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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void regresarAlListado()
        {
            Owner.Show();
            Close();
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            InformacionUsuario informacionUsuario = new InformacionUsuario();
            informacionUsuario.Show(Owner);
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            regresarAlListado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlListado();
        }
    }
}
