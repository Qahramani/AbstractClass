namespace _22_06_24.Task2
{
    internal class Bus : Vehicle
    {
        public int PassengerCount { get; set; }
        public Bus(int year) : base(year)
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Year : {Year}, Passenger count : {PassengerCount} , Color : {Color}");
        }
    }
}
