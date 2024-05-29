using Labb_6___XUnit.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___XUnit
{
    public class Methods
    {
        public static void Run()
        {
            bool continueCalculating = true;
            while (continueCalculating)
            {
                MenuOptions();
                string input = Console.ReadLine();
                continueCalculating = HandleUserChoice(input);                
            }
        }

        public static void MenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Select an option below:");
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplikation");
            Console.WriteLine("[4] Division");
            Console.WriteLine("[5] Show earlier calculations");
            Console.WriteLine("[6] Exit");
            Console.Write("Your choice: ");
        }

        public static bool HandleUserChoice(string input)
        {
            switch (input)
            {
                case "1":
                    PerformCalculation("addition", "+");
                    return true;
                case "2":
                    PerformCalculation("subtraktion", "-");
                    return true;
                case "3":
                    PerformCalculation("multiplikation", "*");
                    return true;
                case "4":
                    PerformCalculation("division", "/");
                    return true;
                case "5":
                    CalculationHistory.ShowPreviousCalculations();
                    Console.ReadKey();
                    return true;
                case "6":
                    return false;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    return true;
            }
            
        }

        public static void InputFromUser(out double num1, out double num2)
        {
            Console.Write("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());
        }
        
        public static void PerformCalculation(string operation, string symbol)
        {
            double num1, num2;
            InputFromUser(out num1, out num2);
            double result = 0;

            var calculator = new Calculator();

            try
            {
                result = operation switch
                {
                    "addition" => calculator.Addition(num1, num2),
                    "subtraktion" => calculator.Subtract(num1, num2),
                    "multiplikation" => calculator.Multiplikation(num1, num2),
                    "division" => calculator.Divide(num1, num2),
                    _ => throw new InvalidOperationException("Ogiltig operation")
                };
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }

            ShowResult(num1,num2,result,symbol);            
            CalculationHistory.SaveCalculations(num1, num2, result, symbol);

        }

        public static void ShowResult(double num1, double num2, double result, string symbol)
        {
            Console.WriteLine($"Result: {num1} {symbol} {num2} = {result}");
            Console.ReadKey();
        }

        
    }
}
