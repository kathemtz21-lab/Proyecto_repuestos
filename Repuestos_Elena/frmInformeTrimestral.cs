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
    public partial class frmInformeTrimestral : Form
    {
        public frmInformeTrimestral()
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
            string ruta = "Inventario_mensual.txt";

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(';');
                    dgvResultadoInformeT.Rows.Add(campos);
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
    }

}