using System.Globalization;

namespace principal
{
    internal class Casting
    {
        /**
        * Este programa declara y muestra diferentes tipos numéricos primitivos en C#.
        * El método Main es el punto de entrada del programa, donde se declaran
        * variables de distintos tipos y se imprimen en la consola.
        */
        public static void Main(string[] args)
        {
            // Fix encoding para caracteres especiales como →
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Enteros
            byte nivel = 255;
            short temperatura = -300;
            int edad = 25;
            long poblacion = 8000000000L;
            char letra = 'A';

            // Decimales
            float peso = 72.5f;
            const double PI = 3.14159265358979;
            decimal precio = 99999.99m;

            // Booleanos
            bool esVerdadero = true;

            // =============================================
            // CASTING IMPLÍCITO
            // =============================================
            Console.WriteLine("\n=== Casting Implícito ===");

            byte numeroByte = 100;
            int numeroInt = numeroByte;
            long numeroLong = numeroInt;
            double numeroDouble = numeroLong;

            Console.WriteLine($"byte   → int:    {numeroByte} → {numeroInt}    | tipo: {numeroInt.GetType()}");
            Console.WriteLine($"int    → long:   {numeroInt} → {numeroLong}    | tipo: {numeroLong.GetType()}");
            Console.WriteLine($"long   → double: {numeroLong} → {numeroDouble} | tipo: {numeroDouble.GetType()}");

            char caracter = 'A';
            int valorUnicode = caracter;
            Console.WriteLine($"char   → int:    '{caracter}' → {valorUnicode}      | tipo: {valorUnicode.GetType()}");

            // =============================================
            // CASTING EXPLÍCITO
            // =============================================
            Console.WriteLine("\n=== Casting Explícito ===");

            double decimal1 = 9.99;
            int entero1 = (int)decimal1;
            Console.WriteLine($"double → int:    {decimal1} → {entero1} (pierde decimales) | tipo: {entero1.GetType()}");

            long numeroGrande = 1234567890123L;
            int numeroReducido = (int)numeroGrande;
            Console.WriteLine($"long   → int:    {numeroGrande} → {numeroReducido} (puede perder datos) | tipo: {numeroReducido.GetType()}");

            float flotante = 3.14f;
            int entero2 = (int)flotante;
            Console.WriteLine($"float  → int:    {flotante} → {entero2} (pierde decimales) | tipo: {entero2.GetType()}");

            int codigo = 66;
            char letra2 = (char)codigo;
            Console.WriteLine($"int    → char:   {codigo} → '{letra2}'           | tipo: {letra2.GetType()}");

            // =============================================
            // CONVERSIÓN CON Convert y Parse
            // =============================================   
            Console.WriteLine("\n=== Convert y Parse ===");

            string textoInt    = "42";
            string textoDouble = "3.14";
            string textoBool   = "True";

            int    convertido1 = Convert.ToInt32(textoInt);
            double convertido2 = Convert.ToDouble(textoDouble, CultureInfo.InvariantCulture);
            bool   convertido3 = Convert.ToBoolean(textoBool);
            int    parseado    = int.Parse(textoInt);

            Console.WriteLine($"Convert string → int:    \"{textoInt}\"   → {convertido1} | tipo: {convertido1.GetType()}");
            Console.WriteLine($"Convert string → double: \"{textoDouble}\" → {convertido2} | tipo: {convertido2.GetType()}");
            Console.WriteLine($"Convert string → bool:   \"{textoBool}\"  → {convertido3} | tipo: {convertido3.GetType()}");
            Console.WriteLine($"Parse   string → int:    \"{textoInt}\"   → {parseado}    | tipo: {parseado.GetType()}");

            Console.ReadKey();
        }
    }
}