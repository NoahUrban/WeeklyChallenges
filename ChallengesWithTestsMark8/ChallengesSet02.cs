using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            
            if (char.IsLetter(c) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int valCount = vals.Count();

            if (valCount % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            bool evenCheck = (number % 2 == 0) ? true : false;

            return evenCheck;
        }

        public bool IsNumberOdd(int num)
        {
            bool oddCheck = (num % 2 != 0) ? true : false;

            return oddCheck;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0.0;
            }

            double min = numbers.Min();
            double max = numbers.Max();
            double sumOfMinMax = min + max;

            return sumOfMinMax;  
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {

            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            int sum = 0;

            foreach (int num in numbers)  
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum; 
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sumReturn = numbers.Sum();

            if (numbers == null)
            {
                return false;
            }

            if (sumReturn % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }

            long count = 0;

            for (long i = 1; i < number; i++)
            {
                if (i > 0 && i % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}