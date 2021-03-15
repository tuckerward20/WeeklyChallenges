using System;
using System.Collections.Generic;
using System.Linq;

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
            if (vals == null)
                return false;
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
            //double min = 0;
            //double max = 0;
            /*
            var numbersList = new List<double>();
            numbersList.Add(numbers);
            */
            /*
            foreach (double num in numbers)
            {
                for (int i = 0; i < numbers.; i++)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }
            */
            
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            
            double min = 100000;
            double max = 0;

            foreach (var num in numbers)
            {
                
                /*
                for (int i = 0; i < IEnumerable.Count; i++)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                    if (num > max)
                    {
                        max = num;
                    }
                }
                */
                if (num <= min)
                {
                    min = num;
                }
                if (num >= max)
                {
                    max = num;
                }
            }
            return max + min;
            /* --- Solution ---
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
            */
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
            if (numbers == null)
                return 0;
            int sum = 0;
            foreach (int count in numbers)
            {
                sum += count;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
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
            if (numbers == null)
                return false;
            bool success = false;
            int sum = 0;
            foreach (int count in numbers)
            {
                sum += count;
            }
            if (sum % 2 == 1 || sum % 2 == -1)
            {
                success = true;
            }
            return success;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //int countDownNumber = Convert.ToInt32(number);
            long countDownNumber = number;
            int counter = 0;
            for (long i = (countDownNumber - 1); i > 0; i--)
            {
                if (i % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
