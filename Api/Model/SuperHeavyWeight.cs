using System;
using System.Threading;

namespace Api.Model
{
   public class SuperHeavyWeight : IDisposable
{
    public SuperHeavyWeight()
    {
        //We simulate an operation take take a long time and cause the object creation to be slow
        Thread.Sleep(TimeSpan.FromSeconds(2));
    }

    public double CalculationOne(int number)
    {
        return number * Math.PI;
    }

    public double CalculationTwo(int number)
    {
        return number * Math.PI;
    }

    public double CalculationThree(int number)
    {
        return number * Math.PI;
    }

    public void Dispose() { }
}
}