public class Logger
{
    private static Logger instance = null;

    private Logger()
    {
     
    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class Singtelon {
    static void Main(string[] args)
    {
        Logger logger = Logger.Instance;
        logger.Log("A");

    }

}



