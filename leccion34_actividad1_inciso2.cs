using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Declaración de variables para alta precisión decimal
            double peso, altura, imc;

            Console.WriteLine("=== CALCULADORA DE IMC ===");

            // Paso 2: Captura y conversión de los datos ingresados
            Console.Write("Ingrese su peso en kilogramos (ejemplo: 70.5): ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su altura en metros (ejemplo: 1.75): ");
            altura = double.Parse(Console.ReadLine());

            // Paso 3: Validación para prevenir la división por cero
            if (altura > 0)
            {
                // Paso 4: Cálculo del IMC
                imc = peso / (altura * altura);

                // Mostramos el resultado formateado a 2 decimales
                Console.WriteLine($"\nSu Índice de Masa Corporal (IMC) es: {Math.Round(imc, 2)}");

                // Paso 5: Estructura condicional anidada para determinar el estado
                if (imc < 18.5)
                {
                    Console.WriteLine("Clasificación: Bajo peso");
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    Console.WriteLine("Clasificación: Peso normal");
                }
                else if (imc >= 25 && imc < 30)
                {
                    Console.WriteLine("Clasificación: Sobrepeso");
                }
                else
                {
                    Console.WriteLine("Clasificación: Obesidad");
                }
            }
            else
            {
                Console.WriteLine("\nError: La altura debe ser una cantidad mayor a cero.");
            }

            // Pausa de ejecución de la consola
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}