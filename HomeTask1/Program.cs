// See https://aka.ms/new-console-template for more information

using HomeTask1.Calculator.Calculation;

var firstNumber = ConsoleInput.GetFirstNumberFromConsole();
UserMessages.ShowOperationHints();
var operation = ConsoleInput.GetCharFromConsole();
var secondNumber = ConsoleInput.GetSecondNumberFromConsole(operation);
var result = Calculations.PerformCalculations(firstNumber, operation, secondNumber);
UserMessages.ReturnTheResult(result);
UserMessages.EndTheConsoleInteraction();
Console.Clear();