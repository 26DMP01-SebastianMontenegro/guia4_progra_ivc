using System;

namespace ConversionesMetros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Declaración de variables
            double metros, resultado;
            char opcion;

            // Paso 2: Captura del valor en metros
            Console.Write("Ingrese la cantidad en metros: ");
            metros = double.Parse(Console.ReadLine());

            // Paso 3: Despliegue del menú en la consola
            Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
            Console.WriteLine("a. Milímetros");
            Console.WriteLine("b. Centímetros");
            Console.WriteLine("c. Decímetros");
            Console.WriteLine("d. Hectómetros");
            Console.WriteLine("e. Kilómetros");
            Console.Write("Seleccione una opción (a-e): ");
            
            // Leemos el caracter ingresado y lo convertimos a minúscula automáticamente
            opcion = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine(); // Salto de línea estético

            // Paso 4 y 5: Estructura condicional Switch para procesar la selección
            switch (opcion)
            {
                case 'a':
                    resultado = metros * 1000;
                    Console.WriteLine($"\n{metros} metros equivale a {resultado} milímetros.");
                    break;
                case 'b':
                    resultado = metros * 100;
                    Console.WriteLine($"\n{metros} metros equivale a {resultado} centímetros.");
                    break;
                case 'c':
                    resultado = metros * 10;
                    Console.WriteLine($"\n{metros} metros equivale a {resultado} decímetros.");
                    break;
                case 'd':
                    resultado = metros / 100;
                    Console.WriteLine($"\n{metros} metros equivale a {resultado} hectómetros.");
                    break;
                case 'e':
                    resultado = metros / 1000;
                    Console.WriteLine($"\n{metros} metros equivale a {resultado} kilómetros.");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                    break;
            }

            // Pausa para que no se cierre la consola inmediatamente en Visual Studio
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}