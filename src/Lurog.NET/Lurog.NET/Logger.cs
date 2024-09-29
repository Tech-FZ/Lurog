namespace Lurog.NET
{
    public class Logger : ILogger
    {
        /*
         * This is a basic console log method which can be overridden by deriving classes.
         * Deriving classes may include, but aren't limited to: File Loggers, DB Loggers, message box loggers.
         */

        public void Log(object sender, ErrorRaisedEventArgs e, string[,] addargs)
        {
            Console.WriteLine($"Error Code: {e.ErrorCode}");
            Console.WriteLine($"Severity: {e.Severity}");
            Console.WriteLine($"Date & Time of occurence: {e.TimeOccurence}");
            Console.WriteLine($"Message: {e.Message}\n");
        }
    }
}
