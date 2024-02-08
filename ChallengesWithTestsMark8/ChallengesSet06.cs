using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;
            

            if (ignoreCase)
            {
                foreach (var w in words)
                    if (w != null && (w.ToUpper()).Equals(word.ToUpper()))
                        return true;
            }
            else
            {
                foreach (var w in words)
                    if (w != null && w.Equals(word))
                        return true;
            }
            return false;
            
        }

        public bool IsPrimeNumber(int num)
        {
            // Base cases
            if (num <= 1)
                return false;
            if (num <= 3)
                return true;
           
            for (int i = 2; i < num; i++)
                if ((num % i) == 0)
                    return false;
            return true;
          
        }


        public int IndexOfLastUniqueLetter(string str)
        {
            int[] letters = new int[26];
            int last, i = 0;
           
            for (i = 0; i < letters.Length; i++)
                letters[i] = -1;
            str = str.ToUpper();
            
            for (i = 0; i < str.Length; i++)
                if (letters[(str[i] - 65)] == -1)
                    letters[(str[i] - 65)] = i;
                else if (letters[(str[i] - 65)] == i - 1)
                    letters[(str[i] - 65)] = -2;
            last = -1;
            
            for (i = 0; i < letters.Length; i++)
                if (letters[i] > last)
                    last = letters[i];
            return last;
           
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
         
            int? prev = null;
            int i = 0;
            int j = 0;
            int maxcount = 0;
           
            if (numbers == null || numbers.Length == 0)
                return 0;

            foreach (var n in numbers)
            {
                if (n == prev)
                    j++;
                else
                    j = 1;
                prev = n;
                if (j > maxcount)
                    maxcount = j;
            }
            return maxcount;

           
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            int i = 0;

            var ar = new List<double>();
           
            if (elements == null || n <= 0)
                return ar.ToArray();
            if (n == 1)
                return elements.ToArray();

           
            foreach (double e in elements)
            {
                i++;
                if ((i % n) == 0)
                    ar.Add(e);
            }
            
            return ar.ToArray(); 
            
        }
    }
}