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
        
    }
}
