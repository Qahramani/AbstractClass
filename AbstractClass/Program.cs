namespace _22_06_24.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus(1930);
            Car car = new Car(1988, "BMW", "Dord Tekerli");
            Vehicle[] vehicles = { bus, car };
            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }
        }
    }
}
