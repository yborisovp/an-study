namespace HomeTask1.Calculator.Calculations;

public class ConsoleInput
{
    public static float GetFirstNumberFromConsole()
    {
        Console.WriteLine("Enter number_1: ");
        var number_1 = Console.ReadLine();
        float parsed_number_1;
        while (!float.TryParse(number_1, out parsed_number_1))
        {
            Console.WriteLine("Not a valid data. Please, enter the number");
            number_1 = Console.ReadLine();
        }

        return parsed_number_1;
    }

    public static float GetSecondNumberFromConsole()
    {
        Console.WriteLine("\nEnter number_2: ");

        var number_2 = Console.ReadLine();
        float parsed_number_2;
        while (!float.TryParse(number_2, out parsed_number_2))
        {
            Console.WriteLine("Not a valid data. Please, enter the number");
            number_2 = Console.ReadLine();
        }

        return parsed_number_2;
    }

    public static char GetCharFromConsole()
    {
        Console.WriteLine("Enter the operation: ");
        var ch = Console.ReadKey().KeyChar;
        char[] operations = { Convert.ToChar("-"), Convert.ToChar("+"), Convert.ToChar("/"), Convert.ToChar("*") };
        while (!operations.Contains(ch))
        {
            Console.WriteLine("Not a valid data. Please, enter the operation character");
            ch = Console.ReadKey().KeyChar;
        }

        return ch;
    }
}