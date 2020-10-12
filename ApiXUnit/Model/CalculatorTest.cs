using System.ComponentModel;
using Api.Model;
using Xunit;

namespace ApiXUnit.Model
{
    public class CalculatorTest
    {

        [Fact]
        [Trait("Category","BaseAction")]
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


        [Fact]
         [Trait("Category","BaseAction")]
        public void Calculator_Test_Division()
        {
            //Arrange
            var _calculator = new Calculator();
            int n1, n2, result;
            n1 =50;
            n2 =10;
            result = 5;
            //Act
            int resultDivision = _calculator.Division(n1, n2);

            //Assert
            Assert.Equal(resultDivision, result);
        }

     [Fact]
      [Trait("Category","BaseAction")]
        public void Calculator_Test_Multiplication()
        {
            //Arrange
            var _calculator = new Calculator();
            int n1, n2, result;
            n1 =5;
            n2 =10;
            result = 50;
            //Act
            int resultMultiplication= _calculator.Multiplication(n1, n2);

            //Assert
            Assert.Equal(resultMultiplication, result);
        }


        [Theory]
        [InlineData(5, 4, 9)]
        [InlineData(9, 4, 13)]
        [InlineData(5, 8, 13)]
         [Trait("Category","BaseAction")]
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
          [Trait("Category","BaseAction")]
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


    [Fact]
 
        public void Calculator_Test_IsPrime()
        {
            //Arrange
            var _calculator = new Calculator();
            int n=18;
            //Act
            bool resultIsPrime= _calculator.IsPrime(n);
            //Assert
            Assert.False(resultIsPrime);
        }
   [Fact]
 
        public void Calculator_Test_isOdd()
        {
            //Arrange
            var _calculator = new Calculator();
            int n=8;
            //Act
            bool resultIsisOdd= _calculator.IsPrime(n);

            //Assert
            Assert.False(resultIsisOdd);
        }
    }
}