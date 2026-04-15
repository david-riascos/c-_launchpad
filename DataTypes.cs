namespace principal
{
    internal class DataTypes
    {
        /**
        * Este programa declara y muestra diferentes tipos numéricos primitivos en C#.
        * El método Main es el punto de entrada del programa, donde se declaran
        * variables de distintos tipos y se imprimen en la consola.
        */
        public static void Main(string[] args)
        {
            // Enteros
            byte nivel = 255; // El valor máximo para byte es 255 y el mínimo es 0
            short temperatura = -300; // El valor mínimo para short es -32768 y el máximo es 32767
            int edad = 25; // El valor mínimo para int es -2147483648 y el máximo es 2147483647
            long poblacion = 8000000000L; // El valor mínimo para long es -9223372036854775808 y el máximo es 9223372036854775807, se usa 'L' para indicar que es un literal de tipo long
            char letra = 'A'; // El tipo char representa un solo carácter Unicode, y se declara con comillas simples

            // Decimales
            float peso = 72.5f; // El valor mínimo para float es aproximadamente 1.5 x 10^-45 y el máximo es aproximadamente 3.4 x 10^38, se usa 'f' para indicar que es un literal de tipo float
            const double PI = 3.14159265358979; // El valor mínimo para double es aproximadamente 5.0 x 10^-324 y el máximo es aproximadamente 1.7 x 10^308
            decimal precio = 99999.99m; // El valor mínimo para decimal es aproximadamente 1.0 x 10^-28 y el máximo es aproximadamente 7.9 x 10^28, se usa 'm' para indicar que es un literal de tipo decimal

            // Booleanos
            bool esVerdadero = true; // El tipo bool solo puede tener los valores true o false


            // Mostrar enteros
            Console.WriteLine("=== Enteros ===");
            Console.WriteLine($"byte    - nivel:      {nivel}");
            Console.WriteLine($"short   - temperatura:{temperatura}");
            Console.WriteLine($"int     - edad:       {edad}");
            Console.WriteLine($"long    - poblacion:  {poblacion}");
            Console.WriteLine($"char    - letra:      {letra}");

            // Mostrar decimales
            Console.WriteLine("\n=== Decimales ===");
            Console.WriteLine($"float   - peso:       {peso}");
            Console.WriteLine($"double  - pi:         {PI}");
            Console.WriteLine($"decimal - precio:     {precio}");

            // Mostrar booleanos
            Console.WriteLine("\n=== Booleanos ===");
            Console.WriteLine($"bool    - esVerdadero: {esVerdadero}");
        }
    }
}