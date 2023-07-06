namespace HomeTask1.Calculator.Calculation;

public class Calculations
{
    public static float PerformCalculations(float a, char b, float c)
    {
        var result = b switch
        {
            '+' => a + c,
            '-' => a - c,
            '/' => a / c,
            '*' => a * c,
            _ => 0
        };
        return result;
    }
}
