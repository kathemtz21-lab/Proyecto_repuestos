using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repuestos_Elena
{
    // Clase para manejar la navegación entre formularios
    //(especialmente para hacer funcionar los botones de navegación)
    internal class clsNavegacion
    {
        // En cada método, se ha colocado Hide() y Close() para que al abrir un formulario,
        // el anterior se oculte y se cierre, para que no se acumulen formularios abiertos


        // Método para abrir el formulario de inicio, y así despúes solo llamarlo en cada boton
        public static void AbrirInicio(Form formularioAnterior)
        {
            // Crea una nueva instancia de la ventana de Inicio
            frmInicio frmInicio = new frmInicio();
            // Oculta la ventana previa para que no permanezca visible en pantalla
            formularioAnterior.Hide();
            // Muestra la ventana de Inicio y detiene la ejecución hasta que se cierre
            frmInicio.ShowDialog();
            // Cierra y libera de la memoria el formulario anterior tras cerrar la ventana de Inicio
            formularioAnterior.Close();
        }

        // Método para abrir el formulario de inventario
        public static void AbrirInventario(Form formularioAnterior)
        {
            // Crea una nueva instancia de la ventana de Inventario
            frmInventario frmInventario = new frmInventario();
            // Oculta la ventana previa para que no permanezca visible en pantalla
            formularioAnterior.Hide();
            // Muestra la ventana de Inventario y detiene la ejecución hasta que se cierre
            frmInventario.ShowDialog();
            // Cierra y libera de la memoria el formulario anterior tras cerrar la ventana de Inventario
            formularioAnterior.Close();
        }

        // Y ASÍ SEGUIRÁN LOS DEMÁS MÉTODOS PARA CADA FORMULARIO, SIGUIENDO EL MISMO PATRÓN DE OCULTAR EL
        // FORMULARIO ANTERIOR, MOSTRAR EL NUEVO Y CERRAR EL ANTERIOR AL FINAL (EXECPTO PARA LAS VENTANAS EMERGENTES)

        // Método para abrir el formulario de existencias, pero del lado del administrador
        public static void AbrirExistenciasAdmin(Form formularioAnterior)
        {
            frmExistenciasAdmin frmExistenciasAdmin = new frmExistenciasAdmin();
            formularioAnterior.Hide();
            frmExistenciasAdmin.ShowDialog();
            formularioAnterior.Close();
        }

        // Método para abrir el formulario de existencias, pero del lado del cliente
        public static void AbrirExistenciasCliente(Form formularioAnterior)
        {
            frmExistenciasCliente frmExistenciasCliente = new frmExistenciasCliente();
            formularioAnterior.Hide();
            frmExistenciasCliente.ShowDialog();
            formularioAnterior.Close();
        }

        // Método para abrir el formulario de informes que despues abre uno de los 3 tipos de informes
        public static void AbrirInformes(Form formularioAnterior)
        {
            //Ventana emergente , por lo que no se cierra el formulario anterior
            FrmInformes frmInformes = new FrmInformes();
            frmInformes.ShowDialog();
        }

        // Método para abrir el formulario de informe mensual
        public static void AbrirInformeMensual(Form formularioAnterior)
        {
            frmInformeMensual frmInformeMensual = new frmInformeMensual();
            formularioAnterior.Hide();
            frmInformeMensual.ShowDialog();
            formularioAnterior.Close();
        }

        // Método para abrir el formulario de informe anual
        public static void AbrirInformeAnual(Form formularioAnterior)
        {
            frmInformeAnual frmInformeAnual = new frmInformeAnual();
            formularioAnterior.Hide();
            frmInformeAnual.ShowDialog();
            formularioAnterior.Close();
        }

        // Método para abrir el formulario de informe trimestral
        public static void AbrirInformeTrimestral(Form formularioAnterior)
        {
            frmInformeTrimestral frmInformeTrimestral = new frmInformeTrimestral();
            formularioAnterior.Hide();
            frmInformeTrimestral.ShowDialog();
            formularioAnterior.Close();
        }

        // Método para abrir el formulario de agregar repuesto
        public static void AbrirAgregarRepuesto(Form formularioAnterior)
        {
            frmAgregarRepuesto frmAgregarRepuesto = new frmAgregarRepuesto();
            frmAgregarRepuesto.ShowDialog();
            // No se cierra el formulario anterior para permitir volver a él después de agregar un repuesto
        }

        // Método para abrir el formulario de eliminar repuesto
        public static void AbrirEliminarRepuesto(Form formularioAnterior)
        {
            frmEliminarRepuesto frmEliminarRepuesto = new frmEliminarRepuesto();
            frmEliminarRepuesto.ShowDialog();
            // No se cierra el formulario anterior para permitir volver a él después de eliminar un repuesto
        }

        // Método para abrir el formulario de Abrir sucursales
        public static void AbrirSucursales(Form formularioAnterior)
        {
            frmSucursales frmSucursales = new frmSucursales();
            frmSucursales.ShowDialog();
            // No se cierra el formulario anterior para permitir volver a él después de dar clic en cambiar sucursal
        }


        public static void CerrarSesion()
        {

        }
    }
}

