using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = numbers.Where(n => n % 2 == 0).Sum();
            var odds = numbers.Where(m => m % 2 != 0).Sum();
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return strings.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new List<int> { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            double number;
            return double.TryParse(input, out number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(ob => ob == null).Count() > (objs.Count() / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }

            var evens = numbers.Where(n => n % 2 == 0);
            if (evens.Count() == 0)
            {
                return 0;
            }
            else
                return evens.Average();


        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
