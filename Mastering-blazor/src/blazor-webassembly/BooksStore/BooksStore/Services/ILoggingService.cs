namespace BooksStore.Services;

public interface ILoggingService
{
   public void Log(string message);
}


public class ConsoleLoggingService : ILoggingService
{
   public void Log(string message)
   {
      Console.WriteLine(message);
   }
}