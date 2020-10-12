using System.Linq;

namespace Api.Model
{
    public class Calculator
    {
    public int Sum(int n1, int n2)
        {
            //return n1/n2;
            return n1+n2;
        }

         public int Sub(int n1, int n2)
        {
            return n1-n2;
        }

               public int Division(int n1, int n2)
        {
            return n1/n2;
        }

           public int Multiplication(int n1, int n2)
        {
            return n1*n2;
        } 

      public bool IsPrime(int n)
    {
        if (n > 1)
        {
            return Enumerable.Range(1, n).Where(x => n%x == 0)
                             .SequenceEqual(new[] {1, n});
        }

        return false;
    }

 public bool isOdd(int number){
            return (number % 2 !=0 );
        }

    }

 
}