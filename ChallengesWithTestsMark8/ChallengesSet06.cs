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
            if (num == 2 || num == 3)
                return true;
            for (int i = 2; i <= Math.Sqrt(num)*2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //var seen = new List<int>();
            //foreach (var letter in str)
            //{
            //    if (seen.IsDistinct(letter))
            //    {
            //    }
            //    else if 
            //    {
            //        seen.Add(str.IndexOf(letter));
            //    }
            //}
            //if (seen.Count() < 1)
            //    return -1;
            //return seen.Last();

            var distinct = str.Distinct().ToList();
            if (str.Length < 1)
                return -1;

            for (int i = (distinct.Count() - 1); i >= 0; i--)
            {
                if (str.Where(x => x == distinct[i]).Count() == 1)
                {
                    return str.IndexOf(distinct[i]);
                }
                
            } 
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 1;
            int index = 0;
            int solution = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
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
                    count = 1;
                }

            }
            return solution;


        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var solution = new List<double>();
            if (elements is null || n < 1)
                return solution.ToArray();
            
            if (n <= elements.Count())
            {
                for (int i = (n -1); i < elements.Count(); i += n)
                {
                    if (i < 0)
                        i = 0;
                    
                    solution.Add(elements[i]);
                }
            }
            return solution.ToArray();
        }
    }
}
