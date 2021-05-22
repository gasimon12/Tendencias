using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pepe;
using System;

namespace KataAnagramasTest
{
    [TestClass]
    public class UnitTest1
    {
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
        //[TestMethod]
        public void SanitizeArraySort()
        {
            Temp temp = new();
            Assert.AreEqual(temp.Sort("@Perro"), temp.Sort("oRe@rp"));
        }
        #endregion
        [TestMethod]
        public void SanitizeLINQ()
        {
            /*string[] words = {"abed",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut", 
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races", 
            "scare", "actors", "costar", "castor", "actress", "casters", "recasts", "airmen", "marine", "remain" };*/
            Temp temp = new();
            string[] words = {"abed",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "caeryrdfdme", "mace", "acre", "care", "race", "acres", "carrt89es", "races",
            "scare", "acdsggdbtors", "costar", "castor", "actress", "casters", "receasts", "aigo0ermen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crasdasdasdases", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recdasdasdasts", "airmen", "marine", "remain@",             "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "aasdasdsadasctress", "casters", "receasts", "airmen", "marine", "remain",
            "bade", "bead", "abet", "bghgeat", "beta", "abets", "baseste", "beqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casdasdasdsters", "recasts", "airmen", "marine", "remain@",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tubssa", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scare", "acasdasdasdtors", "costar", "castor", "actrjiess", "casters", "receasdasdaasts", "airmen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtasdasdas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
                        "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beasdasdasdqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "aasdctress", "casters", "recasts", "airmen", "marine", "remain@",
            "bade", "bead", "abet", "asdasdabeat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            "bade", "beawerd", "abweweret", "beat", "beta", "abets", "buioaste", "beqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdc456re", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",             "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "mace", "acre", "care", "race", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "actress", "casters", "reuiykyuiceasts", "airmeeryrtyn", "marine", "remain",
            "bade", "bead", "abet", "beat", "bedfgdfgta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "ca896re", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "betas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "mace", "acre", "cafghre", "race", "acres", "cares", "races",
            "scare", "actors", "costar", "castor", "actress", "casters", "receasts", "airmen", "marine", "remain",
            "bade", "bead", "abet", "beat", "beta", "abets", "baste", "beqtas", "beast", "beats", "abut",
            "tabu", "tuba", "acme", "came", "m45ace", "aasdcre", "care", "raqw44ce", "a3434crses", "cares", "races",
            "scare", "actors", "costar", "cas6776tor", "actress", "casters", "recasts", "airmen", "marine", "remain@"};
            for (int i = 0; i < words.Length - 1; i++)
            {
                Assert.IsNotNull(temp.Sort(words[i]));
            }
        }
        //[TestMethod]
        public void Compare()
        {
            Temp temp = new();
            //Assert.That(temp.Compare());
        }
    }
}
