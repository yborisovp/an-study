// See https://aka.ms/new-console-template for more information

using HomeTask1.Calculator.Calculations;

var firstNumber = ConsoleInput.GetFirstNumberFromConsole();
UserMessages.ShowOperationHints();
var operation = ConsoleInput.GetCharFromConsole();
var secondNumber = ConsoleInput.GetSecondNumberFromConsole();
var result = Calculations.PerformCalculations(firstNumber, operation, secondNumber);
UserMessages.TheResultMassage(result);
UserMessages.EndTheInteractionMessage();
Environment.Exit(0);
Console.Clear();