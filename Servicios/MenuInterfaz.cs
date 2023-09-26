using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// Interfaz con la relación de la funcionalidad menú
    /// 250923 - chi
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero
        /// 250923 - chi
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// Método que muestra menú y recoge la selección del user.
        /// 260923 - chi
        /// </summary>
        /// <returns>un entro con la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }
}
        