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
        [Theory]
        [InlineData(21, 1, 22, "+", "\r\n21 + 1 = 22")]        
        [InlineData(1, 1, 1, "*", "\r\n1 * 1 = 1")]            
        [InlineData(1, 3, 4, "+", "\r\n1 + 3 = 4")]            
        
        public void ShowPreviousCalculations_PrintsCorrectCalculations(double num1, double num2, double result, string operation, string expectedOutput)
        {
            // Arrange
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            CalculationHistory.ShowPreviousCalculations();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }
    }    
    
}
