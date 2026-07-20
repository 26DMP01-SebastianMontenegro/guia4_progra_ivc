using System;

namespace CalculadoraCambio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE VUELTO ===");
            
            // Entrada de datos de la transacción
            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad con la que pagó el cliente: ");
            double pago = double.Parse(Console.ReadLine());

            // Validación de seguridad
            if (pago < precio)
            {
                Console.WriteLine("\nError: El dinero es insuficiente para completar la compra.");
            }
            else
            {
                double cambio = pago - precio;
                Console.WriteLine($"\nEl cambio total a entregar es: Q{Math.Round(cambio, 2)}");
                Console.WriteLine("--------------------------------------------");

                // Conversión de billetes aplicando casteo explícito (int)
                int b200 = (int)(cambio / 200);
                cambio -= b200 * 200;

                int b100 = (int)(cambio / 100);
                cambio -= b100 * 100;

                int b50 = (int)(cambio / 50);
                cambio -= b50 * 50;

                int b20 = (int)(cambio / 20);
                cambio -= b20 * 20;

                // Redondeamos el sobrante final para evitar errores decimales de precisión
                double monedas = Math.Round(cambio, 2);

                // Salida de resultados estructurada
                Console.WriteLine("Entregar el cambio de la siguiente manera:");
                Console.WriteLine($"- Billetes de 200: {b200}");
                Console.WriteLine($"- Billetes de 100: {b100}");
                Console.WriteLine($"- Billetes de 50:  {b50}");
                Console.WriteLine($"- Billetes de 20:  {b20}");
                Console.WriteLine($"- Restante en monedas: Q{monedas}");
            }
        }
    }
}