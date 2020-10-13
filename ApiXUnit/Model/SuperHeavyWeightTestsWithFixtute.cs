using System;
using Xunit;

namespace ApiXUnit.Model
{
    public class SuperHeavyWeightTestsWithFixtute : IClassFixture<SuperHeavyWeightFixture>
    {
        private readonly SuperHeavyWeightFixture _fixture;

        public SuperHeavyWeightTestsWithFixtute(SuperHeavyWeightFixture fixture)
        {
            _fixture = fixture;
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