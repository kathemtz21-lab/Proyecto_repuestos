using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repuestos_Elena
{
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void btnInformeAnual_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirInformeAnual(this);
        }

        private void btnInformeTrimestral_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirInformeTrimestral(this);
        }

        private void btnInformeMensual_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirInformeMensual(this);
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {

        }
    }
}
