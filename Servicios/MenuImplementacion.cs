using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{

    /// <summary>
    /// Clase que implementa la interfaz del menú
    /// 250923 - chi
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz //conecta los servicios //MenuImplementacion siempre es una clase y el menu interfaz una interfaz

    {

        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Banco CSI1";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("0. Cerrar APP");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar dinero");
            Console.WriteLine("3. Sacar dinero");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0'); //Lee solo 1 carácter. Muestra el resultado en pantalla

           return opcionIntroducida;
        }
    }

}
