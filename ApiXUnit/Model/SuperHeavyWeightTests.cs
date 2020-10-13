using System;
using System.Threading;
using Api.Controllers;
using Xunit;

namespace ApiXUnit.Model
{
 public class SuperHeavyWeightTests
{
    private readonly SuperHeavyWeight _sut;

    public SuperHeavyWeightTests()
    {
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