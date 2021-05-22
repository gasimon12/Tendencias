using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepe
{
    public class Temp
    {
        static void Main()
        {

        }
        public int Empty(string input)
        {
            return 1;
        }
        public int InternalSum(string input)
        {
            int intSum = 0;
            foreach (char unit in input)
            {
                foreach (byte num in BitConverter.GetBytes(unit))
                {
                    intSum += num;                
                }
            }
            return intSum;
        }
        public string Sanitize(string input)
        {
            var temp = from unit in input
                        orderby unit
                        select unit;
            return temp.ToString();
        }
    }
}
