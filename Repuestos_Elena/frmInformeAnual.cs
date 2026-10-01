using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Repuestos_Elena
{
    public partial class frmInformeAnual : Form
    {
        public frmInformeAnual()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInicio de la clase clsNavegacion para abrir el formulario de inicio usa
            clsNavegacion.AbrirInicio(this);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInventario de la clase clsNavegacion para abrir el formulario de inventario
            clsNavegacion.AbrirInventario(this);
        }

        private void btnExistencias_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirExistenciasAdmin de la clase clsNavegacion para abrir el formulario de existencias del lado del administrador
            clsNavegacion.AbrirExistenciasAdmin(this);
        }

        private void btnInforme_Click(object sender, EventArgs e)
        // Llama al método AbrirInformes de la clase clsNavegacion para abrir el formulario de informes atraves de this, que es el formulario actual
        {
            clsNavegacion.AbrirInformes(this);
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            // Define la ruta relativa del archivo que contiene el inventario de repuestos
            string ruta = "inventario_repuestos.txt";

            // Verifica la existencia del archivo para prevenir errores en tiempo de ejecución
            if (File.Exists(ruta))
            {
                // Lee todas las líneas del archivo de texto y las guarda en un arreglo
                string[] lineas = File.ReadAllLines(ruta);

                // Recorre cada línea del archivo de forma individual
                foreach (string linea in lineas)
                {
                    // Separa la línea en campos utilizando el punto y coma (';') como delimitador
                    string[] campos = linea.Split(';');

                    // Añade una nueva fila al DataGridView insertando los campos en sus columnas
                    dgvResultadoInformeA.Rows.Add(campos);
                }
            }
        }

        private void btnCambiarSucursal_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirSucursales de la clase clsNavegacion para abrir el formulario de sucursales
            clsNavegacion.AbrirSucursales(this);
        }
    }

}