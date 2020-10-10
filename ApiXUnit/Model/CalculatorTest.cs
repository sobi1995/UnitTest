using Api.Model;
using Xunit;

namespace ApiXUnit.Model
{
    public class CalculatorTest
    {

        [Fact]
        public void Calculator_Test_Sum()
        {
            //Arrange
            var _calculator = new Calculator();
            int n1, n2, result;
            n1 = 5;
            n2 = 6;
            result = 11;

            //Act
            int resultSum = _calculator.Sum(n1, n2);

            //Assert
            Assert.Equal(resultSum, result);
        }


     [Theory]
        [InlineData(5, 4, 9)]
         [InlineData(9, 4, 13)]
        [InlineData(5, 8, 9)]
        public void Calculator_Test_Sum_By_InlineData(int n1 ,int n2,int result)
        {
            //Arrange
            var _calculator = new Calculator();
          

            //Act
            int resultSum = _calculator.Sum(n1, n2);

            //Assert
            Assert.Equal(resultSum, result);
        }




         [Fact]
        public void Calculator_Test_Sub()
        {
            //Arrange
            var _calculator = new Calculator();
            int n1, n2, result;
            n1 = 20;
            n2 = 5;
            result = 15;

            //Act
            int resultSub = _calculator.Sub(n1, n2);

            //Assert
            Assert.Equal(resultSub, result);
        }


    }
}