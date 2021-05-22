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
            Temp temp = new();
            Console.WriteLine(temp.LINQ("oHla"));
            Console.WriteLine(temp.LINQ("eRROp"));
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
        public string LINQ(string input)
        {
            string output = "";
            var array = from unit in input.ToLower()
                        orderby unit
                        select unit;
            foreach (var item in array)
            {
                output += item;
            }            
            return output;
        }
        public string? ArraySort(string input)
        {
            char[] now = input.ToLower().ToCharArray();
            Array.Sort(now);
            return new string(now);
        }
    }
}
