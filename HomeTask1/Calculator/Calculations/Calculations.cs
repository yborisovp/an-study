namespace HomeTask1.Calculator.Calculations;

public class Calculations
{
    public static float PerformCalculations(float a, char b, float c)
    {
        float result = 0;

        switch (b)
        {
            case '+':
                result = a + c;
                break;
            case '-':
                result = a - c;
                break;
            case '/':
                if (c == 0)
                {
                    Console.WriteLine("Not a valid data. Number_1 can't divide by 0");
                    ConsoleInput.GetSecondNumberFromConsole();
                }
                else 
                result = a / c;
                break;
            case '*':
                result = a * c;
                break;
        }

        return result;
    }
}