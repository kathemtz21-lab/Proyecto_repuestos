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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // Define la ruta relativa del archivo que contiene los datos del inventario
            string ruta = "datos.txt";

            // Verifica la existencia del archivo en el directorio para evitar errores de lectura
            if (File.Exists(ruta))
            {
                // Lee todas las líneas del archivo de texto y las almacena en un arreglo de cadenas
                string[] lineas = File.ReadAllLines(ruta);

                // Recorre cada línea del archivo de forma individual
                foreach (string linea in lineas)
                {
                    // Separa la línea en campos utilizando la barra vertical ('|') como delimitador
                    string[] campos = linea.Split('|');

                    // Inserta una nueva fila en el DataGridView asignando los campos a sus respectivas columnas
                    dgvResultadoInventario.Rows.Add(campos);
                }
            }
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirInformes(this);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirInicio(this);

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirInventario(this);
        }

        private void btnExistencias_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirExistenciasAdmin(this);
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirEliminarRepuesto(this);
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirAgregarRepuesto(this);
        }
    }
}
