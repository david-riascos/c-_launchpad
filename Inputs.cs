using System.Globalization;

namespace principal
{
    internal class Casting
    {
        public static void Main(string[] args)
        {
  

            System.Console.Write("Ingresa tu nombre:   ");
            string nombre = Console.ReadLine();

            System.Console.Write("Ingresa tu edad:    ");
            string edadInput = Console.ReadLine();
            int edad = int.Parse(edadInput);    

            System.Console.Write("Ingresa tu altura:  ");
            string alturaInput = Console.ReadLine();
            float altura = float.Parse(alturaInput, CultureInfo.InvariantCulture); // Usamos InvariantCulture para asegurar el formato decimal  

            System.Console.WriteLine($"\nHola {nombre}, tienes {edad} años y mides {altura} metros.");
            
            Console.ReadKey();
        }
    }
}