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
    // El formulario frmExistenciasCliente es una ventana que permite a los clientes consultar
    // las existencias de repuestos disponibles en la tienda.
    public partial class frmExistenciasCliente : Form
    {
        public frmExistenciasCliente()
        {
            InitializeComponent();
        }

        private void btnCambiarSucursal_Click(object sender, EventArgs e)
        {
            // Llama al método AbrirSucursales de la clase clsNavegacion para abrir el formulario de sucursales
            clsNavegacion.AbrirSucursales(this);
        }

        private void frmExistenciasCliente_Load(object sender, EventArgs e)
        {
            // Define la ruta relativa del archivo que contiene los datos de las existencias
            string ruta = "existencias.txt";

            // Verifica si el archivo existe en la ruta especificada antes de intentarlo abrir
            if (File.Exists(ruta))
            {
                // Lee todas las líneas del archivo de texto y las almacena en un arreglo de cadenas
                string[] lineas = File.ReadAllLines(ruta);

                // Recorre cada línea del archivo una por una
                foreach (string linea in lineas)
                {
                    // Separa la línea actual en varios campos utilizando la coma (',') como delimitador
                    string[] campos = linea.Split(',');

                    // Agrega una nueva fila al DataGridView asignando cada campo a su respectiva columna
                    dgvResultados.Rows.Add(campos);
                }
            }
        }
    }
}
