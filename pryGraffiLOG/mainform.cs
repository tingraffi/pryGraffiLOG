using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGraffiLOG
{
    public partial class mainform : Form
    {
        clsAccesoBD objAccesoBD;

        public mainform()
        {
            InitializeComponent();
            objAccesoBD = new clsAccesoBD();
        }

        private void btnConectarBase_Click(object sender, EventArgs e)
        {
            objAccesoBD.ConectarBaseDatos();

            lblEstadoConexion.Text = objAccesoBD.EstadoConexion;
        }

        private void btnTraerDatos_Click(object sender, EventArgs e)
        {
            objAccesoBD.TraerDatos(DataGridViewLOG);
        }
    }
}
