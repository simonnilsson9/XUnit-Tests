using Labb_6___XUnit.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___XUnit
{
    public class CalculationHistory
    {
        public int ID { get; set; }
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string MathOperation { get; set; }
        public double Result { get; set; }
        public DateTime DateOfCalculation { get; set; }

        public static void SaveCalculations(double num1, double num2, double result, string operation)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    CalculationHistory calcHistory = new CalculationHistory()
                    {
                        Number1 = num1,
                        Number2 = num2,
                        Result = result,
                        MathOperation = operation,
                        DateOfCalculation = DateTime.Now
                    };

                    context.CalculationHistory.Add(calcHistory);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        } 
        public static void ShowPreviousCalculations()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var calculations = context.CalculationHistory.ToList();

                    Console.WriteLine("Earlier calculations: ");
                    foreach (var calculation in calculations)
                    {
                        Console.WriteLine($"{calculation.Number1} {calculation.MathOperation} {calculation.Number2} " +
                            $"= {calculation.Result} (Date of Calculation: {calculation.DateOfCalculation})");
                        
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }    
}
