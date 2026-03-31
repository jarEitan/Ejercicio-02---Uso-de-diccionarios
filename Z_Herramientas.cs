namespace MyApp
{
    internal class Z_Herramientas
    {
        // Colores predefinidos
        private ConsoleColor colorExito = ConsoleColor.Green;
        private ConsoleColor colorError = ConsoleColor.Red;
        private ConsoleColor colorInfo = ConsoleColor.Cyan;
        private ConsoleColor colorTitulo = ConsoleColor.Yellow;
        private ConsoleColor colorMenu = ConsoleColor.Magenta;

        /// <DECORACIÓN Y TÍTULOS>
        public void esperarYLimpiar(){
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        Console.SetCursorPosition(0, 0);
        Console.Clear();
Console.WriteLine("\x1b[3J");
        }
        public void MostrarTitulo(string titulo)
        {
            Console.SetCursorPosition(0,0);
            string borde = "═══════════════════════════════════════════════════";
            Console.ForegroundColor = colorTitulo;
            Console.WriteLine("╔" + borde + "╗");
            Console.WriteLine("║" + CentrarTexto(titulo, borde.Length) + "║");
            Console.WriteLine("╚" + borde + "╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        private string CentrarTexto(string texto, int ancho)
        {
            int espacios = Math.Max(0, (ancho - texto.Length) / 2);
            return new string(' ', espacios) + texto + new string(' ', ancho - espacios - texto.Length);
        }

        public void MostrarMensaje(string mensaje, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("► " + mensaje);
            Console.ResetColor();
        }

        public void MostrarExito(string mensaje)
        {
            Console.ForegroundColor = colorExito;
            Console.WriteLine("✓ " + mensaje);
            Console.ResetColor();
        }

        public void MostrarError(string mensaje)
        {
            Console.ForegroundColor = colorError;
            Console.WriteLine("✗ " + mensaje);
            Console.ResetColor();
        }

        public void MostrarLinea()
        {
            Console.ForegroundColor = colorInfo;
            Console.WriteLine("─────────────────────────────────────────────────────");
            Console.ResetColor();
        }

            /// <TODOS LOS PEDIR>
        public char PedirChar(string mensaje)
        {
            Console.WriteLine(mensaje);
            string txt = Console.ReadLine()!;
            char caracter = char.Parse(txt)!;
            return caracter;
        }
        public int PedirInt(string mensaje)
        {
            Console.WriteLine(mensaje);
            string txt = Console.ReadLine()!;
            int numero = int.Parse(txt);
            return numero;
        }
        public double PedirDouble(string mensaje)
        {
            Console.WriteLine(mensaje);
            string txt = Console.ReadLine()!;
            double numero = double.Parse(txt);
            return numero;
        }
        public string PedirTexto(string mensaje)
        {
            Console.WriteLine(mensaje);
            string texto = Console.ReadLine()!;
            return texto;
        }
        public bool PedirBool(string mensaje)
        {
            string txt;
            bool booleano = true;
            do
            {
                Console.WriteLine(mensaje);
                txt = Console.ReadLine()!;
                if (txt == "true" || txt == "false")
                {
                    booleano = bool.Parse(txt);
                }
                else
                {
                    Console.WriteLine("ERROR, solo true o false es aceptado");
                }
            }while(!(txt == "true" || txt == "false"));
            return booleano;
        }

            /// <MENU>
        //int opcion;
        //List<string> menu = new List<string>{"Alta de usuario", "Baja de usuario", "Lista de usuarios"};
        //opcion = herra.mostrarMenu(menu);
        //Console.WriteLine(opcion);
        public int mostrarMenu(List<string> menu)
        {
            Console.ForegroundColor = colorMenu;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║         📋      OPCIONES DISPONIBLES:  ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();

            int opcion;
            int lugar = 1;
            foreach (string item in menu)
            {
                Console.ForegroundColor = colorInfo;
                Console.Write($"  [{lugar}] ");
                Console.ResetColor();
                Console.WriteLine(item);
                lugar++;
            }
            Console.ForegroundColor = colorError;
            Console.Write($"  [{lugar}] ");
            Console.ResetColor();
            Console.WriteLine("Salir");
            Console.WriteLine();
            
            do
            {
                Console.ForegroundColor = colorTitulo;
                Console.Write("▶ Ingresa tu opción: ");
                Console.ResetColor();
                opcion = pedirOpcion(menu.Count);
                if (opcion < 1 || opcion > menu.Count + 1)
                {
                    MostrarError("Opción inválida, intenta de nuevo");
                }
            } while (opcion < 1 || opcion > menu.Count + 1);
            return opcion;
        }
        private int pedirOpcion(int n)
        {
            int opcion = -1;
            opcion = int.Parse(Console.ReadLine()!);
            return opcion;
        }

            /// <MACHETE SWITCH + MENU>
        private void sitch() //machete  
        {
            int opcion = 1;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado la opción 1.");
                    // Código del caso 1 aquí
                    break;

                case 2:
                    Console.WriteLine("Has seleccionado la opción 2.");
                    // Código del caso 2 aquí
                    break;

                case 3:
                    Console.WriteLine("Has seleccionado la opción 3.");
                    // Código del caso 3 aquí
                    break;

                case 4:
                    Console.WriteLine("Has seleccionado la opción 4.");
                    // Código del caso 4 aquí
                    break;

                case 5:
                    Console.WriteLine("Has seleccionado la opción 5.");
                    // Código del caso 5 aquí
                    break;

                case 6:
                    Console.WriteLine("Has seleccionado la opción 6.");
                    // Código del caso 6 aquí
                    break;

                case 7:
                    Console.WriteLine("Has seleccionado la opción 7.");
                    // Código del caso 7 aquí
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor ingrese un número del 1 al 8.");
                    break;
            }
        }
    }
}
