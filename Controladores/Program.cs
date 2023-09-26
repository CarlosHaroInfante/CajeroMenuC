using CajeroMenuC.Servicios;

namespace CajeroMenuC.Controladores 
{
    /// <summary>
    /// Clase Principal de la aplicación
    /// 250923 - chi
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// 250923 - chi
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mostrarMensajeBienvenida();

            //variable que controla la entrada y salida del bucle.
            bool cerrarMenu = false;

            //Contiene la opción de usuario
            int opcionSeleccionada;

            //Desde la primera iteración (vuelta) debe cumplirse la condición.
            while (!cerrarMenu)
            {
               opcionSeleccionada = menuInterfaz.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);

                switch (opcionSeleccionada)
                
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta el caso 0.");
                        cerrarMenu = true;
                        break;//sale del switch y pasa a la siguiente parte del código
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta el caso 1.");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta el caso 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta el caso 3.");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta el caso 4.");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta el caso 5.");
                        break;
                    default: //cuando el user no escoge una opción válida se ira a deault.

                        Console.WriteLine("[INFO] - La opción seleccionada no coincide con ninguna.");
                        break;
                    
                }

            }
        }

    }

}
