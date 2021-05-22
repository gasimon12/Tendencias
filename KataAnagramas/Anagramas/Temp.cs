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
            //Console.WriteLine(string.Compare("hola", "aloh", StringComparison.InvariantCultureIgnoreCase));
            //string pepe1 = "hola";
            //Temp temp = new Temp();
            //int temp1 = 0;
            //int temp2 = 0;
            //string pepe2 = "@aloh#";
            //Console.WriteLine(pepe1.GetHashCode());
            //Console.WriteLine(temp.InternalSum("hola"));
            //Console.ReadKey();
        }
        public int InternalSum(string input)
        {
            int temp1 = 0;
            foreach (char @char in input)
            {
                var test = BitConverter.GetBytes(@char);
                foreach (byte item in test)
                {
                    temp1 += item;                    
                }
            }
            return temp1;
        }
        public string Hash(string input)
        {
            return String.Concat(input.OrderBy(c => c));
        }
    }
}
