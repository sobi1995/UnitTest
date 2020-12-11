using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsole
{
    public class Calculator : IDisposable
    {
        public int Sum(int n1, int n2)
        {
            //return n1/n2;
            return n1 + n2;
        }

        public int Sub(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Division(int n1, int n2)
        {
            return n1 / n2;
        }

        public int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }

        public bool IsPrime(int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0)
                                 .SequenceEqual(new[] { 1, n });
            }

            return false;
        }

        public bool isOdd(int number)
        {
            return (number % 2 != 0);
        }
        public int Calculate(int n1, int n2, Action action)
        {
            int result = 0;
            if (action == Action.Division)
                result = n1 / n2;
            else if (action == Action.Multiplication)
                result = n1 * n2;
            else if (action == Action.Sub)
                result = n1 - n2;
            else if (action == Action.Sum)
                result = n1 + n2;
            return result;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public enum Action
    {
        Sum = 0,
        Sub = 1,
        Division = 2,
        Multiplication = 3

    }
}
