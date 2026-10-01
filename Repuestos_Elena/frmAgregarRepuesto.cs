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
    public partial class frmAgregarRepuesto : Form
    {
        public frmAgregarRepuesto()
        {
            InitializeComponent();
        }

        // Evento que se dispara al presionar el botón Cancelar.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
          
            // 'this' hace referencia a la ventana actual y Close() libera sus recursos y la destruye.
            this.Close();
        }

        private void frmAgregarRepuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
