public class Funciones
{
    public static int IngresarNumero(string mensaje)
    {
        int numero;
        do
        {
            Console.Write(mensaje);
            numero = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        } while (numero == 0);
        return numero;
    }

    public static string IngresarTexto(string mensaje)
    {
        string texto;
        do
        {
            Console.Write(mensaje);
            texto = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.Write("Entrada inválida. Por favor, ingrese un texto no vacío: ");
            }
        } while (string.IsNullOrWhiteSpace(texto));
        return texto;
    }
}