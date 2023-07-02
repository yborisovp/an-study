namespace example_an;

public static class CharacterExample
{
    public static void GetCharFromConsole()
    {
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine("\nInput character is {0}", ch);
    }
    
    public static void GetCharFromConsoleV2()
    {
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine("\nInput character is {0}", ch);
    }
}
