class Car
{
    private string brand;
    private int year;
    private long petrol;
    private double tankSize;
    private double mpg;
    private string owner;

    public Car()
    {
        brand = "";
        year = 0;
        petrol = 0;
        tankSize = 100;
        mpg = 0;
        owner = "";
    }

    public Car(string brand, int year, long petrol, double tankSize, double mpg, string owner)
    {
        this.brand = brand;
        this.year = year;
        this.petrol = petrol;
        this.tankSize = tankSize;
        this.mpg = mpg;
        this.owner = owner;
    }

    public void display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Owner: " + owner);    
    }

    public double fillPetrol(double gallons)
    {
        double space = tankSize - petrol;
        if(gallons <= space)
        {
            petrol += (long)gallons;
            return petrol;
        }
        else
        {
            petrol = (long)tankSize;
            return petrol;
        }
    }

    public double drive(double distance)
    {
        double expectedDistance = petrol * mpg;
        if(distance <= expectedDistance)
        {
            double fuelUsed = distance / mpg;
            petrol -= (long)fuelUsed;
            return distance;
        }
        else
        {
            petrol = 0;
            return expectedDistance;
        }
    }

    public string changeOwner(string newOwner)
    {
        owner = newOwner;
        return owner;
    }

    private bool full()
    {
        return petrol == tankSize;
    }

    private bool empty()
    {
        return petrol == 0;
    }
}