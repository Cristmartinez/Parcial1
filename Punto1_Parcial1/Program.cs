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
            double[] ventasTotales = { 500000, 450000, 100000 };

            // Calculamos la comision total 

            double comisionTotal = ventasTotales.Sum(venta => venta * 0.10);

        }
    }
}
