using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa que lanza 3600 dados, calcula el total y cuantas veces salio cada numero, Por Julio Cesar Salamanca Ortiz\n\n");
        //Creamos una instancia de la clase "Random"
        Random random = new Random();
        //Declaramos las variables
        int Dice1, Dice2, ContGen = 0, Cont2 = 0, Cont3 = 0, Cont4 = 0, Cont5 = 0, Cont6 = 0, Cont7 = 0, Cont8 = 0, Cont9 = 0, Cont10 = 0, Cont11 = 0, Cont12 = 0, TotalGen = 0, TotalLocal = 0;
        //Creamos un "while" que nos permita lanzar 3600 dados de 6 caras
        while (ContGen <= 3600)
        {
            Dice1 = random.Next(1, 7);
            Dice2 = random.Next(1, 7);
            TotalLocal = Dice1 + Dice2;
            //Usamos contadores para almacenar la cantidad de veces que aparece cada resultado
            if (TotalLocal == 2)
            {
                Cont2++;
            }
            else if (TotalLocal == 3)
            {
                Cont3++;
            }
            else if (TotalLocal == 4)
            {
                Cont4++;
            }
            else if (TotalLocal == 5)
            {
                Cont5++;
            }
            else if (TotalLocal == 6)
            {
                Cont6++;
            }
            else if (TotalLocal == 7)
            {
                Cont7++;
            }
            else if (TotalLocal == 8)
            {
                Cont8++;
            }
            else if (TotalLocal == 9)
            {
                Cont9++;
            }
            else if (TotalLocal == 10)
            {
                Cont10++;
            }
            else if (TotalLocal == 11)
            {
                Cont11++;
            }
            else if (TotalLocal == 12)
            {
                Cont12++;
            }
            //Le sumamos el lanzamiento al total
            TotalGen += TotalLocal;
            ContGen++;
        }
        //Imprimimos los resultados.
        Console.WriteLine("Aqui estan los resultados de cuantas veces salio cada numero: \n");

        Console.WriteLine("Valor\t2\t3\t4\t5\t6\t7\t8\t9\t10\t11\t12\n");

        Console.WriteLine("Veces\t" + Cont2 + "\t" + Cont3 + "\t" + Cont4 + "\t" + Cont5 + "\t" + Cont6 + "\t" + Cont7 + "\t" + Cont8 + "\t" + Cont9 + "\t" + Cont10 + "\t" + Cont11 + "\t" + Cont12);

        Console.WriteLine($"El total de todas las tiradas de dado es: " + TotalGen);

    }



}