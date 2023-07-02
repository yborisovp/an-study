namespace example_an;

public static class IntegerExamples
{
    private static int a;
    public static int C = 2;

    public static void PrintC()
    {
        Console.WriteLine(C);
    }
    
    public static void GetIntFromConsole()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a);
    }
    
    public static void GetIntFromConsoleV2()
    {
        if (int.TryParse(Console.ReadLine(), out int a)) // наружу целочисленный тип а
        {
            Console.WriteLine("Input is: " + a);
        }
        else
        {
            Console.WriteLine("Incorrect input value");
        }
    }
    
    public static void GetIntFromConsoleV3()
    {
        bool flag = true;
        while (flag)
        {
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Input is: " + a);
                flag = false;
            }
            else
            {
                Console.WriteLine("Incorrect input value. Enter integer number");
            }
        }
    }
}
