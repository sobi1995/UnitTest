using System.Collections.Generic;

namespace ApiXUnit.Model
{
    public   class CalculatorData
    {
        // Sum = 0,
        // Sub = 1,
        // Division = 2,
        // Multiplication = 3
        public static IEnumerable<object[]> GetNumbers()
        {
            yield return new object[] { 5, 5, 1, 100 };
            yield return new object[] { 5, 4, 3, 20 };
            yield return new object[] { 50, 10, 2, 5 };
            yield return new object[] { 70, 50, 0, 20 };
        }

       
        public static IEnumerable<object[]> GetNumbersّFromTxtFile()
        {
            yield return new object[] { 5, 5, 1, 100 };
            yield return new object[] { 5, 4, 3, 20 };
            yield return new object[] { 50, 10, 2, 5 };
            yield return new object[] { 70, 50, 0, 20 };
        } 
    }
}