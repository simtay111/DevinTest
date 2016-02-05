using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCaluculatorz
{
    public class StringCalculator
    {
        public int Calculate(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            var result = 0;
            var numbers = input.Split(',', '\n').ToList();
            foreach (var singleNumber in numbers)
            {
                var parsedSingleNumber = int.Parse(singleNumber);
                if (parsedSingleNumber < 1001)
                    result += parsedSingleNumber;
                if (parsedSingleNumber < 0)
                    throw new FormatException();
            }
            return result;
        }
    }
}
