namespace HomeTask1.Calculator.Calculation;

public class ConsoleInput
{
    public static float GetFirstNumberFromConsole()
    {
        Console.Write("Enter number_1: ");
        if (float.TryParse(Console.ReadLine(), out var number1)) return number1;
        Console.WriteLine("Not a valid data. Please, enter the number");
        GetFirstNumberFromConsole();

        return number1;
    }

    public static float GetSecondNumberFromConsole(char operation)
    {
        Console.Write("\nEnter number_2: ");
        var nmbr = Console.ReadLine();

        if (operation.Equals('/') && nmbr == "0")
        {
            Console.WriteLine("Not a valid data. Number_1 can't divide by 0");
            GetSecondNumberFromConsole(operation);
        }

        if (float.TryParse(nmbr, out var number2)) return number2;
        Console.WriteLine("Not a valid data. Please, enter the number");
        GetSecondNumberFromConsole(operation);

        return number2;
    }

    public static char GetCharFromConsole()
    {
        Console.Write("Enter the operation: ");
        var ch = Console.ReadKey().KeyChar;
        char[] operations = { Convert.ToChar("-"), Convert.ToChar("+"), Convert.ToChar("/"), Convert.ToChar("*") };
        if (operations.Contains(ch)) return ch;
        Console.WriteLine("\nNot a valid data. Please, enter the operation character");
        GetCharFromConsole();

        return ch;
    }
}