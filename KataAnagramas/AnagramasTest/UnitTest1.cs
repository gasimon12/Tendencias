using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pepe;
using System;
using System.Diagnostics;

namespace KataAnagramasTest
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        private string[] anagrams = {"abed",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut", 
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races", 
            "scare", "actors", "costar", "castor", "actress", "casters", "recasts", "airmen", "marine", "remain" 
        };
        private string[] longList = {"abed",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            "b5345ade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "caeryrdfdme", "mace", "acre", "care", "race", "acres", "carrt89es", "races",
            "sc43 453are", "acdsggdbtors", "costar", "castor", "actress", "casters", "receasts", "aigo0ermen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            "t34 43abu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crasdasdasdases", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recdasdasdasts", "airmen", "marine", "remain@",
            "basdfy7de", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "ta345bu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scasdxcare", "actors", "costar", "castor", "aasdasdsadasctress", "casters", "receasts", "airmen", "marine", "remain",
            "zrtbade", "bead", "abet", "bghgeat", "beta", "abets", "baseste", "beqtas", "beast", "beats", "abut",
            "ta345bu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casdasdasdsters", "recasts", "airmen", "marine", "remain@",
            "bzzzade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tubssa", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scsdf4are", "acasdasdasdtors", "costar", "castor", "actrjiess", "casters", "receasdasdaasts", "airmen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtasdasdas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scasdf6re", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "ta34534bu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "actress", "csdfdsfasters", "receasts", "airmen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beasdasdasdqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scawery5etre", "ac235tors", "costar", "cas6776tor", "aasdctress", "casters", "recasts", "airmen", "marine", "remain@",
            "bade", "bea233d", "abet", "asdasdabeat", "beta", "abets", "baste", "betas", "beast", "bdfgeats", "abut",
            "tabu", "tu454ba", "acme", "came", "mace", "acre", "care", "raasdce", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            "baderthte", "beawerd", "abweweret", "beat", "beta", "abets", "buioaste", "beqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdc456re", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            "barthadsfde", "bead", "abweret", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scsad6yw5tare", "actors", "costar", "castor", "actress", "casters", "reuiykyuiceasts", "airmeeryrtyn", "marine", "remain",
            "bade", "bead", "abet", "beat", "bedfgdfgta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            "dsfsdtabu", "tu4545ba", "acme", "came", "m45ace", "aasdcre", "ca896re", "raqw44ce", "a3434crses", "cares", "races",
            "ssdfcare", "actors", "coswertar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "xasdsatabu", "tuba", "acme", "came", "mace", "acre", "cafghre", "race", "acres", "cares", "races",
            "szfertcare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            "badertzzzee", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            "tatertzbu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "szzcare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@"
        };
        
        #region Material
        //[TestMethod]
        public void TestMethod1()
        {
            Temp temp = new();
            Assert.AreEqual(temp.InternalSum("hola"), temp.InternalSum("alAoh"));
        }
        //[TestMethod]
        public void TestMethod2()
        {
            string[] words = { "abed", "bade", "bead", "abet", "beat", "beta" };
            Temp temp = new();
            int count = 0;

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (temp.Empty(words[i]) == temp.Empty(words[i + 1]))
                {
                    count++;
                }
            }
            Assert.AreEqual(count, 4);
        }
        #endregion

        [TestMethod]
        public void Time_Measurement()
        {
            Temp temp = new();
            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < longList.Length; i++)
            {
                temp.Sort(longList[i]);
            }
            s1.Stop();
            TestContext.WriteLine(s1.Elapsed.TotalMilliseconds.ToString());
        }
        //[TestMethod]
        public void Compare()
        {
            Temp temp = new();
            //Assert.That(temp.Compare());
        }
    }
}
