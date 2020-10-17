using System.Collections.Generic;
using System.Linq;

namespace ApiXUnit.Model
{
    public class CalculatorData
    {
        // Sum = 0,
        // Sub = 1,
        // Division = 2,
        // Multiplication = 3
        public static IEnumerable<object[]> GetNumbers
        {
            get
            {
                yield return new object[] { 5, 5, 1, 100 };
                yield return new object[] { 5, 4, 3, 20 };
                yield return new object[] { 50, 10, 2, 5 };
                yield return new object[] { 70, 50, 0, 20 };
            }
        }


        public static IEnumerable<object[]> GetNumbersFromTxtFile
        {
            get
            {
                var allLine = System.IO.File.ReadAllLines("./data.txt");
                return allLine.Select(x =>
                {
                    var lineSplit = x.Split(",");
                    return new object[] { int.Parse(lineSplit[0]), int.Parse(lineSplit[1]), int.Parse(lineSplit[2]), int.Parse(lineSplit[3]) };

                });

            }
        }
    }
}