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
    // El formulario actual es una ventana que permite a los administradores
    // consultar las existencias de repuestos disponibles en la tienda.
    public partial class frmExistenciasAdmin : Form
    {
        public frmExistenciasAdmin()
        {
            InitializeComponent();
        }

        private void btnCambiarSucursal_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirSucursales de la clase clsNavegacion para abrir el formulario de sucursales
            clsNavegacion.AbrirSucursales(this);
        }

        // Evento que se ejecuta al cargar el formulario de administración de existencias.
        // Lee los datos desde un archivo plano (.txt) y los carga en el DataGridView.
        private void frmExistenciasAdmin_Load(object sender, EventArgs e)
        {
            // Define la ruta relativa del archivo que contiene los datos de las existencias
            string ruta = "existencias.txt";
            // Verifica la existencia previa del archivo para evitar excepciones en tiempo de ejecución (FileNotFoundException)
            if (File.Exists(ruta))
            {
                // Lee todas las líneas del archivo de texto y las almacena en un arreglo de cadenas
                string[] lineas = File.ReadAllLines(ruta);
                // Recorre cada línea del archivo individualmente
                foreach (string linea in lineas)
                {// Separa la línea en un arreglo de campos utilizando la coma (',') como delimitador
                    string[] campos = linea.Split(',');
                    // Agrega una nueva fila al DataGridView mapeando cada campo a su columna correspondiente
                    dgvResultados.Rows.Add(campos);
                }
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInicio de la clase clsNavegacion para abrir el formulario de inicio
            clsNavegacion.AbrirInicio(this);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInventario de la clase clsNavegacion para abrir el formulario de inventario
            clsNavegacion.AbrirInventario(this);
        }


        private void btnInformes_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirInformes de la clase clsNavegacion para abrir el formulario de informes
            clsNavegacion.AbrirInformes(this);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
