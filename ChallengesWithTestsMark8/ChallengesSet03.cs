using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var place = new List<int>();
            if (numbers == null)
            {
                return false;
            }
            else
            {
                foreach (var item in numbers)
                {
                    if (item % 2 != 0)
                    {
                        place.Add(item);
                    }
                }
                if (place.Sum() % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            var truthlist = new bool[] { false, false, false };
            if (password.Any(char.IsUpper))
            {
                truthlist[0] = true;
            }
            if (password.Any(char.IsLower))
            {
                truthlist[1] = true;
            }
            if (password.Any(char.IsNumber))
            {
                truthlist[2] = true;
            }
            if (truthlist.Contains(false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];

        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddsList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsList.Add(i);
                }
            }
            return oddsList.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}