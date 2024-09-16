using System;

class ProgramaSalarios
{
    static void Main()
    {
        // Declaramos el arreglo
        int[] rangos = new int[9];
        int contadorVendedores = 0;

        // Abrimos un bucle que procese a 20 vendedores
        while (contadorVendedores < 20)
        {
            // Pedir al usuario las ventas brutas del vendedor
            Console.Write("Ingrese las ventas brutas del vendedor " + contadorVendedores + ": ");
            double ventasBrutas = Convert.ToDouble(Console.ReadLine());

            // Calcular el salario total del vendedor
            double salario = 200 + (0.09 * ventasBrutas);

            int salarioEntero = (int)salario; // Truncar a entero

            // Determinar el rango en el que cae el salario

            if (salarioEntero >= 1000)
            {
                rangos[8]++; 
            }
            else if (salarioEntero >= 900)
            {
                rangos[7]++;
            }
            else if (salarioEntero >= 800)
            {
                rangos[6]++;
            }
            else if (salarioEntero >= 700)
            {
                rangos[5]++;
            }
            else if (salarioEntero >= 600)
            {
                rangos[4]++;
            }
            else if (salarioEntero >= 500)
            {
                rangos[3]++;
            }
            else if (salarioEntero >= 400)
            {
                rangos[2]++;
            }
            else if (salarioEntero >= 300)
            {
                rangos[1]++;
            }
            else
            {
                rangos[0]++; 
            }

            // Aumentar el contador
            contadorVendedores++;
        }

        // Mostrar resultados
        Console.WriteLine("Distribución de salarios:");
        Console.WriteLine("$200-$299: " + rangos[0]);
        Console.WriteLine("$300-$399: " + rangos[1]);
        Console.WriteLine("$400-$499: " + rangos[2]);
        Console.WriteLine("$500-$599: " + rangos[3]);
        Console.WriteLine("$600-$699: " + rangos[4]);
        Console.WriteLine("$700-$799: " + rangos[5]);
        Console.WriteLine("$800-$899: " + rangos[6]);
        Console.WriteLine("$900-$999: " + rangos[7]);
        Console.WriteLine("$1000+: " + rangos[8]);
    }
}
