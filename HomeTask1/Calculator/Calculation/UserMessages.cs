namespace HomeTask1.Calculator.Calculation;

public class UserMessages
{
    public static void ShowOperationHints()
    {
        Console.WriteLine("Available operations for calculation are: + - / *");
    }

    public static void ReturnTheResult(float result)
    {
        Console.WriteLine($"\nCalculation result is: {result}");
    }

    public static void EndTheConsoleInteraction()
    {
        Console.Write("Press any key to close the Calculator console app!");
        Console.ReadKey();
    }
}