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
    // Clase para el formulario de inicio 
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        // La palabra clave "this" en cada método de la presente clase, representa la
        // instancia actual de la clase en la que se está ejecutando el código, ya que los
        // diferentes métodos de la clase clsNavegacion necesitan saber desde qué formulario están siendo llamados.

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInicio de la clase clsNavegacion para abrir el formulario de inicio
            // La palabra clave this en representa la instancia actual de la clase en la que se está ejecutando el código,
            // en este caso, el formulario frmInicio. Al pasar this como argumento, se está pasando una referencia,
            // ya que el método AbrirInicio necesita saber desde qué formulario se le está llamando para poder ocultarlo.
            clsNavegacion.AbrirInicio(this);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInventario de la clase clsNavegacion para abrir el formulario de inventario
            clsNavegacion.AbrirInventario(this);
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInformes de la clase clsNavegacion para abrir el formulario de informes
            clsNavegacion.AbrirInformes(this);
        }

        private void btnExistencias_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirExistenciasAdmin de la clase clsNavegacion para abrir el formulario de existencias del lado del administrador
            clsNavegacion.AbrirExistenciasAdmin(this);
        }

        private void btnCambiarSucursal_Click(object sender, EventArgs e)
        {// Llama al método AbrirSucursales de la clase clsNavegacion para abrir el formulario de sucursales
            clsNavegacion.AbrirSucursales(this);

        }

        private void btnAgregarR_Click(object sender, EventArgs e)
        {// Llama al método AbrirAgregarRepuesto de la clase clsNavegacion para abrir el formulario de agregar repuesto
            clsNavegacion.AbrirAgregarRepuesto(this);
        }

        private void btnCrearInforme_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInformes de la clase clsNavegacion para abrir el formulario de informes
            clsNavegacion.AbrirInformes(this);
        }

        private void btnConsultarE_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirExistenciasAdmin de la clase clsNavegacion para abrir el formulario de existencias del lado del administrador
            clsNavegacion.AbrirExistenciasAdmin(this);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
