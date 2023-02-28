using System.Runtime.Versioning;

namespace program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Amount of petrol consumed (liters): ");
            double petrol = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length of the trip (km): ");
            double travel = Convert.ToDouble(Console.ReadLine());

            double consumption = Convert.ToDouble((petrol / (travel / 100)));

            Console.WriteLine("The consumption of the car is " + consumption + " (liters / 100 km).");
        }
    }
}