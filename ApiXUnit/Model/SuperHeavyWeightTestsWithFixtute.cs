using System;
using Xunit;
using Xunit.Abstractions;

namespace ApiXUnit.Model
{
    
    public class SuperHeavyWeightTestsWithFixtute : IClassFixture<SuperHeavyWeightFixture>
    {
        private readonly SuperHeavyWeightFixture _fixture;
        private readonly ITestOutputHelper output;
        public SuperHeavyWeightTestsWithFixtute(SuperHeavyWeightFixture fixture, ITestOutputHelper output)
        {
            _fixture = fixture;
            this.output = output;
            output.WriteLine("run constructor method 2");

        }

        [Fact]
        public void CalculationOne_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _fixture.Sut.CalculationOne(2);

            Assert.Equal(Math.PI * 2, result);
        }

        [Fact]
        public void CalculationTwo_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _fixture.Sut.CalculationOne(5);

            Assert.Equal(Math.PI * 5, result);
        }

        [Fact]
        public void CalculationThree_WhenCalled_ReturnsTheCorrectResult()
        {
            var result = _fixture.Sut.CalculationOne(7);

            Assert.Equal(Math.PI * 7, result);
        }
    }
}