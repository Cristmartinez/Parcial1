using System.Security.Principal;

namespace Punto1_Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vendedor Quiere saber si recibira la comision del 10% por cada venta realizada y cuanto obtendra por las  3 ventas realizadas del mes ademas cuanto sera el total con su sueldo y sus comisiones ademas mostrar cual fue la venta que le genero mayor comision y por ultimo cual fue el promedio de comisiones que recibio por cada venta

            //Declaramos las variables sueldo base
            double sueldoBase = 1000000;

            //Ventas Realizadas 
            double venta1 = 500000;
            double venta2 = 450000;
            double venta3 = 100000;
            

            // Calculamos la comision total 

            double comisionTotal = ventasTotales.Sum(venta => venta * 0.10);

            //Calculamos el Total obtenido por el vendedor con su sueldo y comisiones

            double totalMes = sueldoBase + comisionTotal;

            //Calculamos la mayor comision obtenida 

            double mayorComision = ventasTotales.Sum((venta) => venta * 0.10);

            // Para calcular promedio de comisiones obtenidas

            double promedioComision = comisionTotal / ventasTotales.Length;

            // validar si el vendedor supera el objetivo de 1000000 de ventas por mes

            double totalVentas = venta1 + venta2 + venta3;
            bool alcanzoObjetivo = totalVentas >= 1000000;

            // Vendedor Aplicaria o no al bono extra de 100000

            if (alcanzoObjetivo)  totalMes += 100000;

            //Resultados 

            Console.WriteLine("La Comision Obtenida por las 3 ventas realizadas es: " + comisionTotal ); 
            Console.WriteLine("El total recibido en el mes es de : "  + totalMes );
            Console.WriteLine("La venta que te genero mayor comision fue: " + mayorComision );
            Console.WriteLine("El promedio de comisiones por venta es: " + promedioComision );

            if (alcanzoObjetivo) Console.WriteLine("Bien hecho has logrado obtener el beneficio extra de $100000");
            else Console.WriteLine("Lo siento no alcanzaste la meta para obtener el beneficio extra");                             
        }
    }
}
