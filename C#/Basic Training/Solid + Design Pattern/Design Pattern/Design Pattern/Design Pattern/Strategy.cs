public interface IMove
{
    void Move();
}


public class Bike : IMove
{
    public void Move()
    {
        Console.WriteLine("Bike is moving");
    }
}

public class Car : IMove
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}


public class Vehicle
{
    private IMove movableStrategy;

    public Vehicle(IMove strategy)
    {
        movableStrategy = strategy;
    }

    public void SetMovableStrategy(IMove strategy)
    {
        movableStrategy = strategy;
    }

    public void Go()
    {
        movableStrategy.Move();
    }
}


class Strategey
{
    static void Main(string[] args)
    {
        Bike bike = new Bike();
        Car car = new Car();

        Vehicle vehicle = new Vehicle(bike);
        vehicle.Go();

        vehicle.SetMovableStrategy(car);
        vehicle.Go();

    }

}
