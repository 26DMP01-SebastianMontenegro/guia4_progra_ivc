using System;

namespace HoroscopoZodiacal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Declaración de variables
            int dia, mes;
            string signo = "";
            string horoscopo = "";

            // Paso 2: Captura de datos
            Console.Write("Ingrese su día de nacimiento (1-31): ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su mes de nacimiento en número (1-12): ");
            mes = int.Parse(Console.ReadLine());

            // Paso 3: Estructura condicional anidada para determinar el signo
            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
            {
                signo = "Aries";
                horoscopo = "Hoy es un gran día para iniciar ese proyecto de programación pendiente. ¡Tu energía está al máximo!";
            }
            else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
            {
                signo = "Tauro";
                horoscopo = "La paciencia será tu mejor aliada hoy. Un antiguo problema que no resolvías por fin tendrá sentido.";
            }
            else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            {
                signo = "Géminis";
                horoscopo = "Tu mente está llena de ideas brillantes. Buen momento para trabajar en equipo y compartir soluciones.";
            }
            else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
            {
                signo = "Cáncer";
                horoscopo = "Escucha a tu intuición hoy. Pasar tiempo organizando tus apuntes de estudio te traerá mucha calma.";
            }
            else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
            {
                signo = "Leo";
                horoscopo = "Tu liderazgo natural brillará con fuerza. No temas tomar la iniciativa ante los retos difíciles.";
            }
            else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            {
                signo = "Virgo";
                horoscopo = "Tu gran atención al detalle te salvará de un error crítico hoy. Revisa bien antes de entregar tus tareas.";
            }
            else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            {
                signo = "Libra";
                horoscopo = "El equilibrio llegará a tu rutina. Un asunto que te preocupaba se resolverá de forma justa.";
            }
            else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            {
                signo = "Escorpio";
                horoscopo = "Día de gran enfoque y transformación. Encontrarás una solución muy creativa a un problema complejo.";
            }
            else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            {
                signo = "Sagitario";
                horoscopo = "Tu optimismo es contagioso hoy. Una pequeña aventura o cambio en tu rutina te vendrá excelente.";
            }
            else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
            {
                signo = "Capricornio";
                horoscopo = "Tu disciplina dará frutos muy pronto. Sigue esforzándote, la constancia es tu superpoder.";
            }
            else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
            {
                signo = "Acuario";
                horoscopo = "Tu originalidad romperá esquemas. Estás un paso adelante diseñando soluciones innovadoras.";
            }
            else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
            {
                signo = "Piscis";
                horoscopo = "Tu gran empatía ayudará a un amigo cercano hoy. Confía plenamente en tus talentos creativos.";
            }
            else
            {
                signo = "Desconocido";
                horoscopo = "La fecha ingresada no es válida. Revisa los números e intenta de nuevo.";
            }

            // Paso 4: Despliegue de los resultados
            Console.WriteLine("\n=== TU RESULTADO ===");
            Console.WriteLine($"Signo Zodiacal: {signo}");
            Console.WriteLine($"Horóscopo: {horoscopo}");

            // Pausa de consola
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}