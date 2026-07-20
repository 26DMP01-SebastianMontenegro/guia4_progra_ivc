using System;

namespace ConversorDecimalBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("=== CONVERSOR DECIMAL <-> BINARIO ===");
            Console.WriteLine("1. Convertir de Decimal a Binario");
            Console.WriteLine("2. Convertir de Binario a Decimal");
            // Línea corregida aquí:
            Console.Write("Seleccione una opción (1 o 2): "); 
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese un número entero positivo en decimal: ");
                    int numDecimal = int.Parse(Console.ReadLine());
                    string binarioResultado = "";

                    if (numDecimal == 0)
                    {
                        binarioResultado = "0";
                    }
                    else
                    {
                        // Algoritmo de divisiones sucesivas
                        while (numDecimal > 0)
                        {
                            int residuo = numDecimal % 2;
                            binarioResultado = residuo + binarioResultado; 
                            numDecimal = numDecimal / 2;
                        }
                    }
                    Console.WriteLine($"El número en binario es: {binarioResultado}");
                    break;

                case 2:
                    Console.Write("\nIngrese el número binario: ");
                    string binarioInput = Console.ReadLine();
                    int resultadoDecimal = 0;
                    int potencia = 1;

                    // Algoritmo de multiplicación por potencias de 2
                    for (int i = binarioInput.Length - 1; i >= 0; i--)
                    {
                        if (binarioInput[i] == '1')
                        {
                            resultadoDecimal += potencia;
                        }
                        potencia *= 2; 
                    }
                    Console.WriteLine($"El número en decimal es: {resultadoDecimal}");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}