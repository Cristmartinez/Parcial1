namespace Punto2_Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Velocidad de los trenes 
            double VelocidadTren1 = 80;
            double VelocidadTren2 = 100;

            //Inicio Recorrido 
            double Tiempoincial = 11 - 10;

            double DistanciaEntreTrenes = VelocidadTren1 * Tiempoincial;

            double TiempoAlcanzarTren = DistanciaEntreTrenes / (VelocidadTren2 - VelocidadTren1);

            double HoraAlcanzarlo = TiempoAlcanzarTren + 10;

            Console.WriteLine($"El segundo tren alcanzará al primer tren a las {HoraAlcanzarlo}");
        }
    }
}

