using System;

namespace ClasificacionTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Declaración de variables para almacenar decimales (double)
            double lado1, lado2, lado3;

            // Paso 2: Lectura de las medidas ingresadas por el usuario
            Console.Write("Ingrese la longitud del primer lado: ");
            lado1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la longitud del segundo lado: ");
            lado2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la longitud del tercer lado: ");
            lado3 = double.Parse(Console.ReadLine());

            // Paso 3: Evaluación de los lados mediante estructuras if / else if
            if (lado1 == lado2 && lado2 == lado3)
            {
                // Todos los lados son iguales
                Console.WriteLine("\nEl triángulo es Equilátero (todos sus lados son iguales).");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                // Al menos un par de lados coincide
                Console.WriteLine("\nEl triángulo es Isósceles (tiene dos lados iguales).");
            }
            else
            {
                // Ningún lado es igual a otro
                Console.WriteLine("\nEl triángulo es Escaleno (todos sus lados son diferentes).");
            }

            // Pausa de cortesía para Visual Studio
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}