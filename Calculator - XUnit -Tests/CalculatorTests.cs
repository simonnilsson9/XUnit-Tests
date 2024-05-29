using Labb_6___XUnit;

namespace Calculator___XUnit__Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(-1,-1,-2)]
        [InlineData(1,-1,0)]
        [InlineData(0,0,0)]
        public void Addition_ShouldReturnCorrectSum(double a, double b, double expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Addition(a,b);
            
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1,1,0)]
        [InlineData(-1,-1,0)]
        [InlineData(2,-1,3)]
        [InlineData(0,0,0)]

        public void Subtract_ShouldReturnCorrectDifference(double a, double b, double expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Subtract(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, -1, 1)]
        [InlineData(0, 1, 0)]

        public void Multiplikation_ShouldReturnCorrectProduct(double a, double b, double expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Multiplikation(a, b);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]        
        [InlineData(1, 1, 1)]
        [InlineData(-1, -1, 1)]
        [InlineData(10, 2, 5)]
        public void Divide_ShouldReturnCorrectQuotient(double a, double b, double expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Divide(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            //Arrange
            var calculator = new Calculator();

            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(1, 0));
        }

    }
}