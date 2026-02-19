namespace HealthClinicApp.Utilities;

public static class Logger
{
    public static void LogInfo(string message)
    {
        Console.WriteLine($"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
    }

    public static void LogError(string message, Exception? ex = null)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        if (ex != null)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        Console.ResetColor();
    }

    public static void LogSuccess(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[SUCCESS] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        Console.ResetColor();
    }

    public static void LogWarning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[WARNING] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        Console.ResetColor();
    }
}

