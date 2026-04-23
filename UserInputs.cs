namespace principal
{
    internal class UserInputs
    {
        /**
        * Este programa solicita al usuario que ingrese su nombre y edad, y luego muestra un mensaje personalizado.
        * El método Main es el punto de entrada del programa, donde se utilizan Console.ReadLine para obtener la entrada del usuario.
        */
        public static void Main(string[] args)
        {
            // Fix encoding para caracteres especiales como →
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor, ingresa tu edad: ");
            string edadTexto = Console.ReadLine();
            int edad;
            if (int.TryParse(edadTexto, out edad))
            {
                Console.WriteLine($"\n¡Hola {nombre}! Tienes {edad} años.");
            }
            else
            {
                Console.WriteLine("\nLa edad ingresada no es válida.");
            }
        }
    }
}