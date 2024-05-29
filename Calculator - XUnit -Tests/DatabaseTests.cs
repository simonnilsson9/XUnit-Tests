using Labb_6___XUnit;
using Labb_6___XUnit.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator___XUnit__Tests
{
    public class DatabaseTests
    {
        
        [Fact]
        public void ShowPreviousCalculations_ShouldDisplayCalculations()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new AppDbContext(options))
            {
                context.CalculationHistory.AddRange(new List<CalculationHistory>
                {
                    new CalculationHistory { Number1 = 1, MathOperation = "+", Number2 = 1, Result = 2, DateOfCalculation = DateTime.Now },
                    new CalculationHistory { Number1 = 2, MathOperation = "-", Number2 = 1, Result = 1, DateOfCalculation = DateTime.Now }
                });
                context.SaveChanges();
            }
            
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            CalculationHistory.ShowPreviousCalculations();

            // Assert
            var expectedOutput =
                "Earlier calculations: \r\n" +
                "1 + 1 = 2 (Date of Calculation: " + DateTime.Now.ToShortDateString() + ")\r\n" +
                "2 - 1 = 1 (Date of Calculation: " + DateTime.Now.ToShortDateString() + ")\r\n";
            Assert.Contains("Earlier calculations: \r\n1 + 1 = 2", consoleOutput.ToString());
            Assert.Contains("2 - 1 = 1", consoleOutput.ToString());
        }

        [Fact]
        public void SaveCalculations_ShouldSaveToDatabase()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Act
            CalculationHistory.SaveCalculations(3, 4, 7, "+");

            // Assert
            using (var context = new AppDbContext(options))
            {
                var calculation = context.CalculationHistory.FirstOrDefault();
                Assert.NotNull(calculation);
                Assert.Equal(3, calculation.Number1);
                Assert.Equal(4, calculation.Number2);
                Assert.Equal(7, calculation.Result);
                Assert.Equal("+", calculation.MathOperation);
            }
        }
    }    
    
}
