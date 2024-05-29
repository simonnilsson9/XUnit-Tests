using Labb_6___XUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator___XUnit__Tests
{
    public class InputTests
    {
        [Fact]
        public void InputFromUser_ShouldReadValidNumbers()
        {
            //Arrange
            var input = "5\n10\n";
            var stringReader = new StringReader(input);

            Console.SetIn(stringReader);

            //Act
            Methods.InputFromUser(out double num1, out double num2);

            //Assert
            Assert.Equal(5, num1);
            Assert.Equal(10, num2);
        }

        [Theory]
        [InlineData(3, 4, 7, "+", "Result: 3 + 4 = 7")]
        [InlineData(5, 2, 3, "-", "Result: 5 - 2 = 3")]
        [InlineData(6, 3, 18, "*", "Result: 6 * 3 = 18")]
        [InlineData(8, 2, 4, "/", "Result: 8 / 2 = 4")]
        public void ShowResult_ShouldDisplayCorrectResult(double num1, double num2, double result, string symbol, string expectedOutput)
        {
            // Arrange
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            var consoleInput = new StringReader("\n");
            Console.SetIn(consoleInput);

            // Act
            Methods.ShowResult(num1, num2, result, symbol);

            // Assert
            Assert.Equal(expectedOutput + Environment.NewLine, consoleOutput.ToString());
        }

    }
}
