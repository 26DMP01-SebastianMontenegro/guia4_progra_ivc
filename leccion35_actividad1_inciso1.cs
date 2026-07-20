using System;

namespace ConvertidorMonedas
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("=== CONVERTIDOR DE MONEDA INTERNACIONAL ===");
                
                // Captura del monto inicial
                Console.Write("Ingrese la cantidad en moneda local (Quetzales): ");
                double cantidad = double.Parse(Console.ReadLine());

                // Operaciones con las tasas de cambio
                double usd = cantidad / 7.75;
                double eur = cantidad / 8.40;
                double mxn = cantidad * 2.20;
                double jpy = cantidad * 19.50;
                double gbp = cantidad / 10.10;

                // Impresión de resultados redondeados a 2 decimales
                Console.WriteLine($"\nLa cantidad de Q{cantidad} equivale a:");
                Console.WriteLine($"- Estados Unidos : ${Math.Round(usd, 2)} USD");
                Console.WriteLine($"- Unión Europea  : {Math.Round(eur, 2)} EUR");
                Console.WriteLine($"- México         : ${Math.Round(mxn, 2)} MXN");
                Console.WriteLine($"- Japón          : ¥{Math.Round(jpy, 2)} JPY");
                Console.WriteLine($"- Reino Unido    : £{Math.Round(gbp, 2)} GBP");
                Console.WriteLine("--------------------------------------------");

                // Pregunta de continuidad directa
                Console.Write("¿Desea convertir otra cantidad? (S/N): ");
                respuesta = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine(); 

            } while (respuesta == 's'); // Se repite si el usuario presiona 's'
        }
    }
}