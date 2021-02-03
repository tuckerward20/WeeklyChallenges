using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            char[] characters = "abcdefghijklmnopqrstuvwxyzZXCVBNMLKJHGFDSAQWERTYUIOP".ToCharArray();
            bool success = false;
            foreach (char letter in characters)

                if (letter == c)
                {
                    success = true;
                }
            return success;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int isEven = vals.Length;
            if (isEven % 2 == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 1)
                return true;
            else if (num % 2 == -1)
                return true;
            else
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double min = 0;
            double max = 0;
            foreach (double num in numbers)
            {
                for (int i = 0; i < numbers.; i++)
                {
                    if (num > numbers[i])
                    {
                        max = num;
                    }
                }
            }
            foreach (double num in numbers)
            {
                for (int i = 0; i < IEnumerable.Count; i++)
                {
                    if (num < numbers[i])
                    {
                        min = num;
                    }
                }
            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();
            int num1 = array1.Length;
            int num2 = array2.Length;
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int count in numbers)
            {
                sum += count;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            foreach (int count in numbers)
            {
                if (count % 2 == 0)
                {
                    sum += count;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            bool success = false;
            int sum = 0;
            foreach (int count in numbers)
            {
                sum += count;
            }
            if (sum % 2 == 1)
            {
                success = true;
            }
            return success;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int countDownNumber = Convert.ToInt32(number);
            int counter = 0;
            for (long i = countDownNumber; i >= 1; i--)
            {
                if (countDownNumber % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
