using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataRange
{    
    public class Range
    {
        public int lowerLimit { get; private set; }
        public int upperLimit { get; private set; }
        public bool lowerInclusive { get; private set; }
        public bool upperInclusive { get; private set; }
        public Range(string input)
        {
            Regex regex = new Regex(@"[0-9]+");
            var matches = regex.Matches(input);
            lowerLimit = int.Parse(matches[0].Value);
            upperLimit = int.Parse(matches[1].Value);
            lowerInclusive = input[0] == '[' ? true : false;
            upperInclusive = input[^1] == ']' ? true : false;
        }
        public int[] GetMidPoints()
        {
            int lower, upper, count, parity, distance;
            lower = lowerLimit;
            upper = upperLimit;
            if (lowerInclusive == false)
            {
                lower = lowerLimit + 1;
            }
            if (upperInclusive == false)
            {
                upper = upperLimit - 1;
            }
            count = upper - lower;
            parity = (count + 1) % 2;
            if (parity == 0)
            {
                distance = count / 2;
                return new int[] {lower + distance, lower + distance + 1};
            }
            else
            {
                distance = (count + 1) / 2;
                return new int[] { lower + distance };
            }
        }
        static void Main()
        {

        }
    }
}
