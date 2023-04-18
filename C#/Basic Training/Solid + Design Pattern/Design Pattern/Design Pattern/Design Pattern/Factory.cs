interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("File logger: " + message);
    }
}

class StdLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Std logger: " + message);
    }
}

class LoggerManager
{
    public ILogger GetLog(string type)
    {
        switch (type)
        {
            case "file":
                return new FileLogger();
            case "std":
                return new StdLogger();
            default:
                throw new Exception("Invalid log");
        }
    }
}

class Factory
{
    static void Main(string[] args)
    {
        string outputMsg = "This is an error message";
        LoggerManager loggerManager = new LoggerManager();

        ILogger logger = loggerManager.GetLog("file");
        logger.Log(outputMsg);

        logger = loggerManager.GetLog("std");
        logger.Log(outputMsg);
    }
}
