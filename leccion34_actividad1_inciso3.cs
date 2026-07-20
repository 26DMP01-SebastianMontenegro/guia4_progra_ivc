using System;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Declaración de variables
            double centigrados, resultado;
            char opcion;

            // Paso 2: Captura del valor inicial
            Console.Write("Ingrese la cantidad en grados Centígrados: ");
            centigrados = double.Parse(Console.ReadLine());

            // Paso 3: Mostrar el menú en pantalla
            Console.WriteLine("\n=== MENÚ DE CONVERSIÓN ===");
            Console.WriteLine("a. Fahrenheit");
            Console.WriteLine("b. Celsius");
            Console.WriteLine("c. Kelvin");
            Console.Write("Seleccione una opción (a, b o c): ");
            
            // Leemos el carácter e ignoramos problemas de mayúsculas
            opcion = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine(); // Salto de línea estético

            // Paso 4 y 5: Procesamiento de fórmulas por casos
            switch (opcion)
            {
                case 'a':
                    resultado = (centigrados * 1.8) + 32;
                    Console.WriteLine($"\n{centigrados} grados Centígrados equivale a {resultado} grados Fahrenheit.");
                    break;

                case 'b':
                    resultado = centigrados;
                    Console.WriteLine($"\n{centigrados} grados Centígrados equivale a {resultado} grados Celsius.");
                    break;

                case 'c':
                    resultado = centigrados + 273.15;
                    Console.WriteLine($"\n{centigrados} grados Centígrados equivale a {resultado} Kelvin.");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                    break;
            }

            // Pausa de cortesía
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}