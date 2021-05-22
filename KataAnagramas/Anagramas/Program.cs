using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramas
{
    public class Anagrams
    {
        static void Main()
        {
            //Console.WriteLine(string.Compare("hola", "aloh", StringComparison.InvariantCultureIgnoreCase));
            string pepe1 = "hola'";
            int temp1 = 0;
            string pepe2 = "aloh";
            for (int i = 0; i < pepe1.Length; i++)
            {
                var test = BitConverter.GetBytes(pepe1[i]);
                for (int j = 0; j < test.Length ; j++)
                {
                    if (test[j] != 00)
                    {                        
                        temp1 += test[j];
                    }                    
                }                
            }
            Console.WriteLine("Total" + temp1);
            
            Console.ReadKey();
        }
        public int InternalSum(string input)
        {

            return 1;
        }
    }
}
