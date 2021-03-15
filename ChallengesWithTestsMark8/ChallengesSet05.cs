using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int ans = 0;
            return ans = (startNumber - (startNumber % n)) + n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers is null)
                return 0;
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                if ((numbers[i] % 2) == 0)
                {
                    sum += numbers[i + 1];
                }

            }
            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null)
                return "";

            var sentence = "";
            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                    sentence += (word.Trim() + " ");
            }

            if (sentence.Length == 0)
                return "";

            sentence = sentence.Substring(0, sentence.Length - 1);
            return sentence + ".";

            //return String.Join(" ", words.Where(x => x != " " && x != "").ToString()) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements is null)
                return Array.Empty<double>();
            var solution = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % 4 == 0)
                {
                    solution.Add(elements[i]);
                }
            }
            return solution.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            //foreach (var item in nums)
            //{
            //    if (nums.Any(x => x + item == targetNumber))
            //        return true;
            //}
            //return false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                    if(i != j)
                    {
                        if (nums[i] + nums[j] == targetNumber)
                            return true;
                    }
            }
            return false;
        }
    }
}
