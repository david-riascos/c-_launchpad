namespace principal
{
    internal class ClaseMath
    {
        /**
        * Este programa demuestra el uso de la clase Math en C#. El método Main es el punto de entrada del programa,
        * donde se realizan varias operaciones matemáticas utilizando los métodos estáticos de la clase Math.
        */
        public static void Main(string[] args)
        {
            // Fix encoding para caracteres especiales como →
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double numero = 16.0;

            double raizCuadrada = Math.Sqrt(numero);
            double potencia = Math.Pow(numero, 2);
            double valorAbsoluto = Math.Abs(-numero);
            double redondeoArriba = Math.Ceiling(raizCuadrada);
            double redondeoAbajo = Math.Floor(raizCuadrada);
            double redondeo = Math.Round(raizCuadrada);
            double pi = Math.PI;
            double maximo = Math.Max(numero, raizCuadrada);
            double minimo = Math.Min(numero, raizCuadrada);
            

            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Raíz cuadrada: {raizCuadrada}");
            Console.WriteLine($"Potencia (número al cuadrado): {potencia}");
            Console.WriteLine($"Valor absoluto: {valorAbsoluto}");
            Console.WriteLine($"Redondeo hacia arriba: {redondeoArriba}");
            Console.WriteLine($"Redondeo hacia abajo: {redondeoAbajo}");
            Console.WriteLine($"Redondeo: {redondeo}");
            Console.WriteLine($"Valor de π: {pi}");
            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"Mínimo: {minimo}");
        }



    }
}