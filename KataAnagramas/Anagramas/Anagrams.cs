using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramas
{
    public class Anagrams
    {
        private Dictionary<string, string> record;
        //TODO: PROBAR CON LINKEDLIST COMO VALOR
        static void Main()
        {

        }
        #region Material
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
        public string LINQSort(string input)
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
        #endregion
        public string Sort(string input)
        {
            char[] now = input.ToLower().ToCharArray();
            Array.Sort(now);
            return new string(now);
        }
    }
}
