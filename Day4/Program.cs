using System;
using System.Collections.Generic;

//password is 6 digits(done?)
//value is within the range given in puzzle input(done?)
//two adjacent digits are the same(i.e 22, 33, etc.)
//digits never decrease when going left to right(111123 or 135679)(done?)
namespace Day4
{
    public class Day4Application
    {
        static void Main(string[] args)
        {
            string puzzleInput = "128392-643281";
            int numberOfViablePasswords = 0;
            string[] numbers = puzzleInput.Split("-");
            for (int i = int.Parse(numbers[0]); i < int.Parse(numbers[1]); i++)
            {
                string currentNumber = i.ToString();
                //Console.WriteLine(currentNumber);
                if (
                IsIncreasing(currentNumber) &&
                IsSixCharacters(currentNumber) &&
                IsInRange(currentNumber, numbers[0], numbers[1]) &&
                HasADuplicate(currentNumber)
                )
                    numberOfViablePasswords++;
            }
            Console.WriteLine(numberOfViablePasswords);
        }

        public static bool IsIncreasing(string currentNumber)
        {
            for (int j = 1; j < currentNumber.Length; j++)
            {
                if (int.Parse(currentNumber[j].ToString()) < int.Parse(currentNumber[j - 1].ToString()))
                    return false;
            }
            return true;
        }

        public static bool IsSixCharacters(string currentNumber)
        {
            return currentNumber.Length == 6;
        }

        public static bool IsInRange(string currentNumber, string initialNumber, string endingNumber)
        {
            int currentNumberInt = int.Parse(currentNumber);
            int initialNumberInt = int.Parse(initialNumber);
            int endingNumberInt = int.Parse(endingNumber);
            return currentNumberInt >= initialNumberInt && currentNumberInt <= endingNumberInt;
        }

        public static bool HasADuplicate(string currentNumber)
        {
            Dictionary<int, int> duplicates = new Dictionary<int, int>();
            for (int i = 1; i < currentNumber.Length; i++)
            {
                if (currentNumber[i] == currentNumber[i - 1])
                {
                    if (duplicates.ContainsKey(int.Parse(currentNumber[i].ToString())))
                        duplicates[int.Parse(currentNumber[i].ToString())] = duplicates[int.Parse(currentNumber[i].ToString())] + 1;
                    else
                    {
                        duplicates.Add(int.Parse(currentNumber[i].ToString()), 2);
                    }
                }
            }

            foreach (KeyValuePair<int, int> duplicate in duplicates)
            {
                if (duplicate.Value == 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
