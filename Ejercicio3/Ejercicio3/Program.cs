using System;

class Program
{
    static void Main()
    {
        // Declaramos el arreglo sales para almacenar las ventas.
        decimal[,] sales = new decimal[5, 4];

        // Colocamos las (hipoteticas) ventas del mes anterior
        int[,] datosVentas = {
            { 1, 1, 100 }, { 1, 2, 200 }, { 1, 3, 300 },
            { 2, 1, 150 }, { 2, 2, 250 }, { 2, 5, 350 },
            { 3, 3, 400 }, { 3, 4, 500 }, { 4, 5, 600 }
        };

        // Procesamos las ventas y almacenamos los totales en el arreglo sales.
        for (int i = 0; i < datosVentas.GetLength(0); i++)
        {//Ajustamos los indices y el valor de las ventas
            int vendedor = datosVentas[i, 0] - 1; 
            int producto = datosVentas[i, 1] - 1; 
            decimal venta = datosVentas[i, 2];    

            // Sumamos la venta en la posición correspondiente del arreglo sales.
            sales[producto, vendedor] += venta;
        }

        // Imprimir encabezados de vendedores
        Console.WriteLine("Producto\tVendedor 1\tVendedor 2\tVendedor 3\tVendedor 4\tTotal Producto");

        // Variable para almacenar el total global de las ventas
        decimal totalGeneral = 0;

        // Procesamos cada producto (
        for (int producto = 0; producto < 5; producto++)
        {
            decimal totalProducto = 0; // Total de ventas por producto
            Console.Write("Producto " + (producto + 1) + "\t");

            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                Console.Write(sales[producto, vendedor] + "\t\t");
                totalProducto += sales[producto, vendedor]; // Acumulamos total por producto
            }

            // Imprimimos el total de ventas por producto
            Console.WriteLine(totalProducto);
            totalGeneral += totalProducto; // Acumulamos para el total general
        }

        // Imprimimos la fila de totales por vendedor
        Console.Write("Total Vendedor\t");

        for (int vendedor = 0; vendedor < 4; vendedor++)
        {
            decimal totalVendedor = 0;

            // Sumamos las ventas de cada vendedor
            for (int producto = 0; producto < 5; producto++)
            {
                totalVendedor += sales[producto, vendedor];
            }

            // Imprimimos el total de ventas por vendedor
            Console.Write(totalVendedor + "\t\t");
        }

        // Imprimimos el total general al final
        Console.WriteLine(totalGeneral);
    }
}
