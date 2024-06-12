namespace _22_06_24.Task2
{
    internal class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public Car(int year, string brand, string model) : base(year)
        {
            Brand = brand;
            Model = model;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Year : {Year} , Brand : {Brand}, Model : {Model}," +
                $" MaxSpeed : {MaxSpeed}, Color : {Color}");
        }
    }
}
