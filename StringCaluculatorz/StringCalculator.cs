using System;

namespace StringCaluculatorz
{
    public class StringCalculator
    {
        public int Calculator(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            var result = 0;
            var numbers = input.Split(',', '\n');
            foreach (var singleNumber in numbers)
            {
                var singleParsedNumber = int.Parse(singleNumber);
                if (singleParsedNumber < 0)
                    throw new FormatException();
                if (singleParsedNumber < 1001)
                    result += singleParsedNumber;
            }
            return result;
        }
    }
}