using System;

namespace PiedraPapelTijeras
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            // Instanciamos la clase Random para generar números al azar
            Random random = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine("=== JUEGO: PIEDRA, PAPEL O TIJERAS ===");
                Console.WriteLine("1. Piedra");
                Console.WriteLine("2. Papel");
                Console.WriteLine("3. Tijeras");
                Console.Write("Seleccione su opción (1-3): ");
                int usuario = int.Parse(Console.ReadLine());

                if (usuario < 1 || usuario > 3)
                {
                    Console.WriteLine("Opción no válida.");
                }
                else
                {
                    // Genera un número aleatorio entre 1 y 3 (el 4 queda excluido)
                    int computadora = random.Next(1, 4);

                    // Arreglo auxiliar para mostrar los nombres de las opciones fácilmente
                    string[] opciones = { "", "Piedra", "Papel", "Tijeras" };
                    
                    Console.WriteLine($"\nTú elegiste: {opciones[usuario]}");
                    Console.WriteLine($"La computadora elegió: {opciones[computadora]}");

                    // Evaluación del resultado
                    if (usuario == computadora)
                    {
                        Console.WriteLine("\n¡Es un empate!");
                    }
                    else if ((usuario == 1 && computadora == 3) || 
                             (usuario == 2 && computadora == 1) || 
                             (usuario == 3 && computadora == 2))
                    {
                        Console.WriteLine("\n¡Felicidades! ¡Ganaste tú!");
                    }
                    else
                    {
                        Console.WriteLine("\n¡Gana la computadora!");
                    }
                }

                Console.WriteLine("--------------------------------------------");
                Console.Write("¿Desea jugar de nuevo? (S/N): ");
                respuesta = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

            } while (respuesta == 's');
        }
    }
}