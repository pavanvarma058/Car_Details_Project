namespace SDD_Lab_Week_3;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", 2020, 10, 100, 30, "Charlie");
        car1.display();
        Console.WriteLine("Petrol after filling 20 gallons: " + car1.fillPetrol(20));
        Console.WriteLine("Petrol after filling 20 gallons: " + car1.fillPetrol(20));
        Console.WriteLine("Distance travelled: " + car1.drive(150));
        Console.WriteLine(car1.changeOwner("Alan"));
        car1.display();
    }
}
