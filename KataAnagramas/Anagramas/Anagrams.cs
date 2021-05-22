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
        private Dictionary<string, LinkedList<string>> dictionary = new Dictionary<string, LinkedList<string>>();
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
        public string Sanitize(string raw)
        {
            char[] temp = raw.ToCharArray();
            Array.Sort(temp);
            return new string(temp);
        }
        public int SetCount()
        {
            int count = 0;
            foreach (var pair in dictionary)
            {
                if (pair.Value.Count > 1)
                {
                    count++;
                }
            }
            return count;
        }
        public bool Check(string raw)
        {
            string key = Sanitize(raw);
            bool match = dictionary.ContainsKey(key);
            if (match == true)
            {
                dictionary.TryGetValue(key, out var list);
                list.AddLast(raw);
            }
            else
            {
                dictionary.Add(key, new LinkedList<string>());
                dictionary.TryGetValue(key, out var list);
                list.AddLast(raw);
            }
            return match;
        }
    }
}
