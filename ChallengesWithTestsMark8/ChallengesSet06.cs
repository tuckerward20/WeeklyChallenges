using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words is null || word is null)
            {
                return false;
            }

            else if (ignoreCase)
            {
                foreach (var item in words)
                {
                    if (item == null)
                    {

                    }

                    else if (word.ToLower() == item.ToLower())
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                if (words.Contains(word))
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public bool IsPrimeNumber(int num)
        {

            if (num <= 1)
                return false;
            for (int i = 2; i < Math.Sqrt(num)*2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var seen = new List<char>();
            foreach (var letter in str)
            {
                if (seen.Contains(letter))
                {
                }
                else
                {
                    seen.Add(letter);
                }
            }
            return seen.Count() - 1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            int index = 0;
            int solution = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] + 1 == numbers[i + 1])
                {
                    count += 1;
                    index = i + 2;
                    if (count > solution)
                    {
                        solution = count;
                    }
                }
                else
                {
                    count = 0;
                    i = index;
                }
            }
            return solution;


        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var solution = new List<double>();
            if (n <= elements.Count())
            {
                for (int i = (n - 1); i < elements.Count(); i += n)
                {
                    solution.Add(elements[i]);
                }
            }
            return solution.ToArray();
        }
    }
}
