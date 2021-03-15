using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool item in vals)
            {
                if (item == false)
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            int sum = 0;
            foreach (int item in numbers)
            {
                if (item % 2 == 1 || item % 2 == -1)
                    sum += item;
            }
            if (sum % 2 == 1 || sum % 2 == -1)
                return true;
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsLower(x)) && password.Any(x => char.IsNumber(x));
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            else
                return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var oddsBelow100 = Enumerable.Range(1, 100).Where(x => x % 2 == 1).ToArray();
            return oddsBelow100;
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            //words = words.Select(x => x = x.ToUpper().ToString()).ToArray();
            //words = words.Select(x => x = x.Select(y => y = char.ToUpper(y)).ToString()).ToArray();
            words = words.Select(x => x.ToUpper()).ToArray();
            return words;
        }
    }
}
