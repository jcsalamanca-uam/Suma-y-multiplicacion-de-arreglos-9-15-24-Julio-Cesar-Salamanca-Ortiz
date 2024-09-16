using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al sistema de asignado de asientos, creado por Julio Cesar Salamanca Ortiz\n");
        //declaramos las variables
        int ContIndefinido = 1;
        int Fumador, AsientoFumador = 1, AsientoNoFumador = 6, FumadorANoFumador, NoFumadorAFumador;
        //Creamos un bucle que permita insertar varios valores
        while (ContIndefinido == 1)
        {
            //Permitimos que el usuario elija su opcion
            Console.WriteLine("Escriba '1' para fumador y '2' para no fumador:\n");
            Console.WriteLine("1. Fumador\n2.No fumador");

            Fumador = int.Parse(Console.ReadLine());

            //Le asignamos un asiento de fumador
            if (Fumador == 1 && AsientoFumador <= 5)
            {
                Console.WriteLine($"Su asiento es el numero: " + AsientoFumador + " Usted esta en la seccion de fumadores, disfrute su vuelo.\n");
                AsientoFumador++;
            }
            //Le damos la opcion de tomar un asiento de no fumador
            else if (Fumador == 1 && AsientoFumador > 5)
            {
                Console.WriteLine("Desafortunadamente, la seccion de fumadores esta llena, desea ser movido a la seccion de no fumadores?\n");
                Console.WriteLine("1.Si\n 2.No");
                FumadorANoFumador = int.Parse(Console.ReadLine());

                if (FumadorANoFumador == 1)
                {
                    Console.WriteLine($"Su asiento es el numero: " + AsientoNoFumador + " Usted esta en la seccion de no fumadores, disfrute su vuelo.\n");
                    AsientoNoFumador++;
                }

                else if (FumadorANoFumador == 2)
                {
                    Console.WriteLine("The next flight leaves in 3 hours\n");
                }
            }



            //Le damos un asiento de no fumador
            if (Fumador == 2 && AsientoNoFumador <= 10)
            {
                Console.WriteLine($"Su asiento es el numero: " + AsientoNoFumador + " Usted esta en la seccion de no fumadores, disfrute su vuelo.\n");
                AsientoNoFumador++;

            }
            //Le damos la opcion de tener un asiento de fumador.
            else if (Fumador == 2 && AsientoNoFumador > 10)
            {
                Console.WriteLine("Desafortunadamente, la seccion de no fumadores esta llena, desea ser movido a la seccion de fumadores?\n");
                Console.WriteLine("1.Si\n 2.No");
                NoFumadorAFumador = int.Parse(Console.ReadLine());

                if (NoFumadorAFumador == 1)
                {
                    Console.WriteLine($"Su asiento es el numero: " + AsientoFumador + " Usted esta en la seccion de fumadores, disfrute su vuelo.\n");
                    AsientoFumador++;
                }

                else if (NoFumadorAFumador == 2)
                {
                    Console.WriteLine("The next flight leaves in 3 hours.\n");
                }
            }

        }

    }
}