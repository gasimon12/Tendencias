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
        public Range(string input)
        {
            Regex regex = new Regex(@"[0-9]+");
            var matches = regex.Matches(input);
            lowerLimit = int.Parse(matches[0].Value);
            upperLimit = int.Parse(matches[1].Value);
        }
        static void Main()
        {

        }
    }
}
