using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzTddExample.src
{
    public class FizzBuzz
    {
        public string GetWord(int number)
        {

            if (number == 0)
            {
                return "0";
            }

            if (IsMultipleByThree(number) && IsMultipleByFive(number))
            {
                return "FizzBuzz";
            }

            if (IsMultipleByThree(number))
            {
                return "Fizz";
            }

            if (IsMultipleByFive(number))
            {
                return "Buzz";
            }
            return number.ToString();
        }

        public List<string> GetWords(int limit)
        {
            List<string> list = new List<string>();

            for (int i = 1; i <= limit; i++)
            {
                list.Add(GetWord(i));
            }

            return list;
        }

        private bool IsMultipleByFive(int number) => number % 5 == 0;
        private bool IsMultipleByThree(int number) => number % 3 == 0;
    }
}