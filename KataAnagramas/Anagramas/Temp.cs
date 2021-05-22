using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //Console.WriteLine(temp.Sort("oHla"));
            //Console.WriteLine(temp.Sort("eRROp"));
            #region Arreglo
            //string[] words = {"abed",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            //"scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            //"scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "caeryrdfdme", "mace", "acre", "care", "race", "acres", "carrt89es", "races",
            //"scare", "acdsggdbtors", "costar", "castor", "actress", "casters", "receasts", "aigo0ermen", "marine", "remain",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crasdasdasdases", "cares", "races",
            //"scare", "actors", "costar", "cas6776tor", "actress", "casters", "recdasdasdasts", "airmen", "marine", "remain@",             "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            //"scare", "actors", "costar", "castor", "aasdasdsadasctress", "casters", "receasts", "airmen", "marine", "remain",
            //"bade", "bead", "abet", "bghgeat", "beta", "abets", "baseste", "beqtas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            //"scare", "actors", "costar", "cas6776tor", "actress", "casdasdasdsters", "recasts", "airmen", "marine", "remain@",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            //"tabu", "tubssa", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            //"scare", "acasdasdasdtors", "costar", "castor", "actrjiess", "casters", "receasdasdaasts", "airmen", "marine", "remain",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtasdasdas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            //"scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            //            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            //"scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "beasdasdasdqtas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            //"scare", "actors", "costar", "cas6776tor", "aasdctress", "casters", "recasts", "airmen", "marine", "remain@",
            //"bade", "bead", "abet", "asdasdabeat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            //"scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            //"bade", "beawerd", "abweweret", "beat", "beta", "abets", "buioaste", "beqtas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "m45ace", "aasdc456re", "care", "raqw44ce", "a3434crses", "cares", "races",
            //"scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",             "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            //"scare", "actors", "costar", "castor", "actress", "casters", "reuiykyuiceasts", "airmeeryrtyn", "marine", "remain",
            //"bade", "bead", "abet", "beat", "bedfgdfgta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "ca896re", "raqw44ce", "a3434crses", "cares", "races",
            //"scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "mace", "acre", "cafghre", "race", "acres", "cares", "races",
            //"scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            //"bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            //"tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            //"scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@"}; 
            #endregion
            StreamReader sr = new StreamReader(@"C:\Users\gasim\Downloads\wordlist.txt");
            string line;
            var s1 = Stopwatch.StartNew();
            while ((line = sr.ReadLine()) != null)
            {
                temp.LINQSort(line);
            }
            s1.Stop();
            StreamReader sr2 = new StreamReader(@"C:\Users\gasim\Downloads\wordlist.txt");
            var s2 = Stopwatch.StartNew();
            while ((line = sr2.ReadLine()) != null)
            {
                temp.Sort(line);
            }
            s2.Stop();
            Console.WriteLine("Algoritmo con LINQ: " + s1.Elapsed.TotalMilliseconds + "ms");
            Console.WriteLine("Algoritmo con ArraySort: " + s2.Elapsed.TotalMilliseconds + "ms");
        }
        public int Empty(string input)
        {
            return 1;
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
        #endregion
        public string Sort(string input)
        {
            char[] now = input.ToLower().ToCharArray();
            Array.Sort(now);
            return new string(now);
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
    }
}
