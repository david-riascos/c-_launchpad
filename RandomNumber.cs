namespace principal
{
    internal class RandomNumber
    {
        /**
        * Este programa genera un número aleatorio entre 1 y 100 utilizando la clase Random en C#.
        * El método Main es el punto de entrada del programa,
        * donde se crea una instancia de la clase Random y se utiliza el método Next para generar el número aleatorio.
        */
        public static void Main(string[] args)
        {
            // Fix encoding para caracteres especiales como →
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100

            Console.WriteLine($"Número aleatorio generado: {numeroAleatorio}");
            Console.ReadLine(); // Espera a que el usuario presione Enter antes de cerrar la consola
        }
    }
}