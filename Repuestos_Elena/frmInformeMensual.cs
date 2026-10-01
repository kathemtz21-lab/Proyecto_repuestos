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
    public partial class frmInformeMensual : Form
    {
        public frmInformeMensual()
        {
            InitializeComponent();
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

        private void btnInforme_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirInformes(this);
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            // Define la ruta relativa del archivo que contiene los datos del inventario mensual
            string ruta = "Inventario_mensual.txt";

            // Comprueba si el archivo existe en el directorio para evitar excepciones de tipo FileNotFoundException
            if (File.Exists(ruta))
            {
                // Lee todas las líneas del archivo de texto y las carga en un arreglo de cadenas de texto
                string[] lineas = File.ReadAllLines(ruta);

                // Procesa cada registro/línea del archivo en un ciclo iterativo
                foreach (string linea in lineas)
                {
                    // Divide el contenido de la línea en un arreglo de datos utilizando el punto y coma (';') como separador
                    string[] campos = linea.Split(';');

                    // Agrega una nueva fila al DataGridView poblando las celdas con el contenido del arreglo de campos
                    dgvResultadoInformeM.Rows.Add(campos);
                }
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarSucursal_Click(object sender, EventArgs e)
        {
            clsNavegacion.AbrirSucursales(this);
        }

        private void btnCambiarSucursal_Click_1(object sender, EventArgs e)
        {
            clsNavegacion.AbrirSucursales(this);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }

}