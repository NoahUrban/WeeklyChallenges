using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            return difference;
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        public long Multiply(long factor1, long factor2)
        {
            long quotient = factor1 * factor2;
            return quotient;
        }

        public string GetGreeting(string nameOfPerson)
        {
            String greeting = $"Hello, {nameOfPerson}!";

            if (string.IsNullOrEmpty(nameOfPerson))
            {
                return "Hello!";
            }
            else
            {
                return greeting;
            }
        }

        public string GetHey()
        {
            return "HEY!";                  
        }
    }
}
