using System;
using Api.Controllers;

namespace ApiXUnit.Model
{
 public class SuperHeavyWeightFixture : IDisposable
{
    public SuperHeavyWeight Sut { get; private set; }

    public SuperHeavyWeightFixture()
    {
        Sut = new SuperHeavyWeight();
    }

    public void Dispose()
    {
        Sut.Dispose();
    }
}
}