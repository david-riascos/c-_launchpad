namespace principal

{
    internal class OperatorArimentics
    {
        /**
        * Este programa realiza operaciones aritméticas básicas (suma, resta, multiplicación y división)
        * entre dos números ingresados por el usuario. El método Main es el punto de entrada del programa,
        * donde se utilizan Console.ReadLine para obtener la entrada del usuario y luego se realizan las operaciones.
        */
        public static void Main(string[] args)
        {
            // Fix encoding para caracteres especiales como →
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Por favor, ingresa el primer número: ");
            string numero1Texto = Console.ReadLine();
            double numero1;
            if (!double.TryParse(numero1Texto, out numero1))
            {
                Console.WriteLine("El primer número ingresado no es válido.");
                return;
            }

            Console.Write("Por favor, ingresa el segundo número: ");
            string numero2Texto = Console.ReadLine();
            double numero2;
            if (!double.TryParse(numero2Texto, out numero2))
            {
                Console.WriteLine("El segundo número ingresado no es válido.");
                return;
            }

            double suma = numero1 + numero2;
            double resta = numero1 - numero2;
            double multiplicacion = numero1 * numero2;
            double division = numero2 != 0 ? numero1 / numero2 : double.NaN;
            int modulo = (int)numero1 % (int)numero2;

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");

            if (double.IsNaN(division))
                Console.WriteLine("División: No se puede dividir por cero.");
            else
                Console.WriteLine($"División: {division}");
                
            Console.WriteLine($"Módulo: {modulo}");
        }

    }
}