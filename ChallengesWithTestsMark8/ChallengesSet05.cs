using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
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
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            if (words == null)
            {
                return "";
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim().Length > 0)
                {
                    sentence += words[i].Trim() + " ";
                }
            }
            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim() + ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fourth = new List<double>();

            if (elements == null || elements.Count == 0)
            {
                return fourth.ToArray();
            }

            for (int i = 3; i < elements.Count; i += 4)
            {
                fourth.Add(elements[i]);
            }
            return fourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int h = i + 1; h < nums.Length; h++)
                {
                    if (nums[i] + nums[h] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}