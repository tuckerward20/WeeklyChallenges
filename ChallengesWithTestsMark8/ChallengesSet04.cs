using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            foreach (int item in numbers)
            {
                if (item % 2 == 1 || item % 2 == -1)
                    sum -= item;
                else
                    sum += item;
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            

            int length = str1.Length;
            string[] words = new string[] { str1, str2, str3, str4 };
            foreach (string word in words)
            {
                if (word.Length <= length)
                    length = word.Length;
            }
            return length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[] { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
                return true;
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double i = 0;

            return double.TryParse(input, out i);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            if (objs.Where(x => x == null).Count()*2 > objs.Count())
                return true;
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            //int[] empty = new int[] { };
            //if (numbers == empty)
            //{
            //    return 0;
            //}
            if (numbers is null)
                return 0;
            if (numbers.Any(x => x % 2 == 0))
                return numbers.Where(x => x % 2 == 0).Average();
            return 0;
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            int sum = 1;
            for (int i = number; i > 0; i--)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
