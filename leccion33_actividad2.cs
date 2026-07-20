using System;

namespace LaFraseInvertida
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Declaración de variables
            string frase;
            string fraseInvertida = "";

            // Paso 2: Captura del texto
            Console.Write("Ingrese la frase que desea invertir: ");
            frase = Console.ReadLine();

            // Paso 3 y 4: Ciclo for invertido
            // Iniciamos en el último índice (frase.Length - 1) y bajamos hasta 0
            for (int i = frase.Length - 1; i >= 0; i--)
            {
                // Extraemos el carácter de la posición 'i' y lo sumamos a la nueva cadena
                fraseInvertida += frase[i];
            }

            // Despliegue de los resultados en la consola
            Console.WriteLine("\n=== RESULTADO ===");
            Console.WriteLine($"Texto original: {frase}");
            Console.WriteLine($"Texto invertido: {fraseInvertida}");

            // Pausa de ejecución para Visual Studio
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}