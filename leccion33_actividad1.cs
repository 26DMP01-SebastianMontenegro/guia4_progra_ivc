using System;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Declarar los arreglos de tamaño 10 en C#
            string[] nombres = new string[10];
            string[] telefonos = new string[10];
            int posicion;

            // Paso 2: Ciclo for para llenar los 10 espacios (del índice 0 al 9)
            Console.WriteLine("=== REGISTRO DE 10 CONTACTOS ===");
            for (int i = 0; i < 10; i++)
            {
                // Mostramos (i + 1) para que el usuario vea "Persona 1" en vez de "Persona 0"
                Console.Write($"Ingrese el nombre de la persona {i + 1}: ");
                nombres[i] = Console.ReadLine();

                Console.Write($"Ingrese el teléfono de {nombres[i]}: ");
                telefonos[i] = Console.ReadLine();
                Console.WriteLine("--------------------------------------------");
            }

            // Paso 3: Consulta de datos por posición humana (1-10)
            Console.WriteLine("\n=== CONSULTA DE CONTACTOS ===");
            Console.Write("Ingrese el número de posición que desea buscar (1-10): ");
            posicion = int.Parse(Console.ReadLine());

            // Validamos el rango ingresado
            if (posicion >= 1 && posicion <= 10)
            {
                // Restamos 1 para convertir la posición humana (1-10) a índice de computadora (0-9)
                int indiceReal = posicion - 1;

                Console.WriteLine($"\nDatos encontrados en la posición {posicion}:");
                Console.WriteLine($"-> Nombre: {nombres[indiceReal]}");
                Console.WriteLine($"-> Teléfono: {telefonos[indiceReal]}");
            }
            else
            {
                Console.WriteLine("Error: La posición ingresada no es válida. Debe ser entre 1 y 10.");
            }

            // Pausa para mantener abierta la consola
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}