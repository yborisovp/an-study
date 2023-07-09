namespace HomeTask1.Calculator.Calculations;

public class UserMessages
{
    public static void ShowOperationHints()
    {
        Console.WriteLine("Available operations for calculation are: + - / *");
    }

    public static void TheResultMassage(float result)
    {
        Console.WriteLine($"Calculation result is: {result}");
    }

    public static void EndTheInteractionMessage()
    {
        Console.WriteLine("Press any key to end the session!");
        Console.ReadKey();
    }
}