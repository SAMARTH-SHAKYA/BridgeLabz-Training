namespace HealthClinicApp.Utilities;

public static class ConsoleHelper
{
    public static void PrintHeader(string title)
    {
        Console.Clear();
        Console.WriteLine(new string('=', 60));
        Console.WriteLine($"  {title}");
        Console.WriteLine(new string('=', 60));
        Console.WriteLine();
    }

    public static void PrintSeparator()
    {
        Console.WriteLine(new string('-', 60));
    }

    public static void PressAnyKeyToContinue()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public static string ReadLine(string prompt)
    {
        Console.Write($"{prompt}: ");
        return Console.ReadLine() ?? string.Empty;
    }

    public static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public static decimal ReadDecimal(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid decimal number.");
        }
    }

    public static DateTime ReadDate(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt} (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime value))
                return value;
            Console.WriteLine("Invalid date format. Please use yyyy-MM-dd.");
        }
    }

    public static TimeSpan ReadTime(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt} (HH:mm): ");
            if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan value))
                return value;
            Console.WriteLine("Invalid time format. Please use HH:mm.");
        }
    }
}

