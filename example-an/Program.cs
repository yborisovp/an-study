// See https://aka.ms/new-console-template for more information

using example_an;

var aExample = new Example();
aExample.PrintB();

IntegerExamples.PrintC();

aExample.B = 4;
aExample.PrintB();

IntegerExamples.C = 5;
IntegerExamples.PrintC();

// Console.WriteLine("Input value:");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Your value {a}");

// char ch;
//             
//$"Your value {a}" => "Your value " + a + " "
// //input character 
// Console.Write("Enter a character: ");
// ch = Console.ReadKey().KeyChar;
//
// Console.WriteLine("\nInput character is {0}", ch);
//
// Console.ReadLine();