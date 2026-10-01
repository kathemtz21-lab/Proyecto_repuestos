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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();
            // Al presionar la X en la nueva ventana, cierra todo el proceso
            frmInicio.FormClosed += (s, args) => Application.Exit();
        }

        // La palabra clave "this" en cada método de la presente clase, representa la
        // instancia actual de la clase en la que se está ejecutando el código, ya que los
        // diferentes métodos de la clase clsNavegacion necesitan saber desde qué formulario están siendo llamados.
        private void btnIniciarCliente_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirExistenciasCliente(this);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
