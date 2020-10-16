using System;
using System.Threading;
using Api.Controllers;
using Xunit;
using Xunit.Abstractions;

namespace ApiXUnit.Model
{
    public class SuperHeavyWeightTests
    {
        private readonly SuperHeavyWeight _sut;
        private readonly ITestOutputHelper output;
        public SuperHeavyWeightTests(ITestOutputHelper output)
        {
            this.output = output;
            output.WriteLine("run constructor method 1");

            _sut = new SuperHeavyWeight();
        }

        [Fact]
        public void CalculationOne_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _sut.CalculationOne(2);

            Assert.Equal(Math.PI * 2, result);
        }

        [Fact]
        public void CalculationTwo_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _sut.CalculationOne(5);

            Assert.Equal(Math.PI * 5, result);
        }

        [Fact]
        public void CalculationThree_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _sut.CalculationOne(7);

            Assert.Equal(Math.PI * 7, result);
        }
    }
}