namespace ejercicio02;

class Program
{
    static void Main(string[] args)
    {
        //Inicializar el diccionario con al menos 3 recursos y sus cantidades.
        Dictionary<string, int> inventario = new Dictionary<string, int>();
        inventario.Add("madera", 5);
        inventario.Add("vidrio", 0);
        inventario.Add("oro", 10);
        
        //Menú 
        int opcion;

        do {
            Console.Clear();
            opcion = Funciones.IngresarNumero("Ingrese opción:");

            switch(opcion) {
                case 1:
                 //Ver inventario
                foreach(string item in inventario.Keys) {
                    Console.WriteLine("MATERIAL: " + item + ", STOCK: " + inventario[item]);
                }
                break;
                
                case 2:
                string recurso = Funciones.IngresarTexto("Ingrese recurso:").ToLower();
                int cantidad = Funciones.IngresarNumero("Ingrese cantidad a sumar:");
                if(inventario.ContainsKey(recurso)) {
                    inventario[recurso] += cantidad;
                } else {
                    inventario.Add(recurso, cantidad);
                }
                break;

                case 3:
                recurso = Funciones.IngresarTexto("Ingrese recurso:").ToLower();
                cantidad = Funciones.IngresarNumero("Ingrese cantidad a gastar:");
                if(inventario.ContainsKey(recurso)) {
                    if (inventario[recurso] > cantidad){
                        inventario[recurso] -= cantidad;
                        if(inventario[recurso] <= 5){
                            Console.WriteLine("ALERTA: REABASTECER " + recurso);
                        }
                    }else{
                        Console.WriteLine("Estas gastando mas de lo que hay");
                    }
                    
                } else {
                    Console.WriteLine("Recurso no encontrado");
                }
                break;

                case 4:
                recurso = Funciones.IngresarTexto("Ingrese recurso:").ToLower();
                    if(inventario.ContainsKey(recurso))
                    {
                        Console.WriteLine(recurso + " tiene un stock de " + inventario[recurso]);
                    }else{
                        Console.WriteLine("Recurso no encontrado");
                    }
                break;
            }
            Console.ReadLine();

        } while(opcion != 5);


        //Opción 2: Actualizar el stock. Si el recurso existe, suma la cantidad; si no existe, debe agregarlo al sistema.

        //Opción 3: Consumir un recurso (resta su stock)
        //si un recurso baja de 5 unidades (luego de consumirse), el programa muestre un mensaje de "ALERTA: REABASTECER [Nombre del Recurso]".

        //Opción 4: Consultar un recurso específico que el usuario ingresa por teclado y mostrar su información.

        //Opción 5: Salir del programa
    }
}
