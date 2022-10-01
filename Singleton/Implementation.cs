namespace Singleton;

public class Logger
{
    // Lazy<T>
    private static readonly Lazy<Logger> LazyLogger = new(() => new Logger());
    //private static Logger? _instance;

    public static Logger Instance => LazyLogger.Value;
    //get
    //{
        //if (_instance == null)
        //{
        //    _instance = new Logger();
        //}
        //return _instance;
    //}

    protected Logger()
    {
    }

    public void Log(string logMessage)
    {
        Console.WriteLine($"Message to log: {logMessage}");
    }
}
