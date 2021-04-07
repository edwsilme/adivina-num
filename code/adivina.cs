using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADIVINA
{
    //Nombre del Autor: Edward Eliecer Silva Mejia
    //Fecha: 15/11/2015
    //Doy fe que este ejercicio es de mi autoria, en caso de encontrar plagio la nota de todo mi 
    //trabajo debe ser de CERO ademas de las respectivas sansiones a que haya lugar

    class Program
    {
        static void Main(string[] args)
        {
            int level;

            Console.WriteLine("Adivina un numero al azar");
            Console.WriteLine("Dos niveles");
            Console.WriteLine("Que nivel desea jugar.");
            Console.WriteLine("1 para Nivel basico y ");
            Console.WriteLine("2 para el nivel experto.");
            level = Convert.ToInt32(Console.ReadLine());

            if (level == 1)
            {
                int num_x, num_jugador, num_intentos;

                Console.WriteLine("Nivel basico");
                Random generador = new Random();
                num_x = generador.Next(1, 1001);

                Console.WriteLine("Digite un numero aleatorio entre 1 y 1000 : \n");
                num_jugador = Convert.ToInt32(Console.ReadLine());
                num_intentos = 1;

                while ((num_x != num_jugador))
                {
                    if (num_x > num_jugador)
                    {
                        Console.WriteLine("Frio");
                    }
                    else
                    {
                        Console.WriteLine("Caliente");
                    }
                    num_intentos = num_intentos + 1;
                    num_jugador = Convert.ToInt32(Console.ReadLine());
                }

                if (num_x == num_jugador)
                {
                    Console.WriteLine("Exacto!");
                    Console.WriteLine("Felicitaciones, usted ha adivinado el numero");  
                    Console.WriteLine("Numero de intentos ", num_intentos);
                }
                else
                {
                    Console.WriteLine("Numero de intentos ", num_intentos);
                }
            }
            else 
            {
                if (level == 2)
                {
                    int num_x, num_jugador;

                    Console.WriteLine("Nivel experto");
                    Random generador = new Random();
                    num_x = generador.Next(1, 1001);

                    Console.WriteLine("Digite un numero aleatorio entre 1 y 1000 : \n");
                    num_jugador = Convert.ToInt32(Console.ReadLine());

                    int num_intentos = 5;

                    while ((num_x != num_jugador && num_intentos > 1))
                    {
                        num_intentos = -1;

                        if (num_x > num_jugador)
                        {
                            Console.WriteLine("Lejos");
                        }
                        else
                        {
                            Console.WriteLine("Cerca");
                        }
                        Console.WriteLine("Te quedan {0} intentos", num_intentos);
                        num_intentos = num_intentos + 1;
                        num_jugador = Convert.ToInt32(Console.ReadLine());
                    }

                    if (num_x == num_jugador)
                    {
                        Console.WriteLine("Exacto!");
                        Console.WriteLine("Felicitaciones, usted ha adivinado el numero");
                        Console.WriteLine("Numero de intentos ", num_intentos);
                    }
                    else
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Numero de intentos ", num_intentos);
                        Console.WriteLine("El numero era: ", num_x);
                    }
                }
                else
                {
                    Console.WriteLine("Solo se permiten dos niveles");
                    Console.WriteLine("Si desea puede reiniciar");
                }

            }

            Console.ReadKey();
        }
    }
}
