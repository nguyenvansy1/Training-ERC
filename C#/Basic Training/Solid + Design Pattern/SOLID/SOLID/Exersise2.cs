
//Interface Segregation Principle
public interface IWorkable
{
    void Work();
}

public interface ISleepable
{
    void Sleep();
}

public class HumanWorker : IWorkable, ISleepable
{
    public void Work()
    {
        Console.WriteLine("works");
    }

    public void Sleep()
    {
        Console.WriteLine("sleep");
    }
}

public class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("works");
    }
}
