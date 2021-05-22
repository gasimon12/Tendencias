using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagramas;
using System.Diagnostics;
using System.IO;

namespace KataAnagramasTest
{
    [TestClass]
    public class UnitTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        private string[] list = {"abed",
                                "bade",
                                "bead",
                                "abet",
                                "Unimaginatively",
                                "beats",
                                "abut",
                                "tabu",
                                "tuba",
                                "acme",
                                "came",
                                "mace",
                                "acre",
                                "care",
                                "race",
                                "acres",
                                "cares",
                                "sesquipedalianism",
                                "races",
                                "scare",
                                "beat",
                                "beta",
                                "abets",
                                "baste",
                                "betas",
                                "beast",
                                "casters",
                                "recasts",
                                "airmen",
                                "marine",
                                "remain",
                                "alert",
                                "alter",
                                "later",
                                "alerted",
                                "altered",
                                "related",
                                "treadle",
                                "ales",
                                "leas",
                                "wean",
                                "angel",
                                "angle",
                                "glean",
                                "antler",
                                "learnt",
                                "sale",
                                "seal",
                                "aligned",
                                "dealing",
                                "leading",
                                "allergy",
                                "era",
                                "arm",
                                "mar",
                                "ram",
                                "arrest",
                                "rarest",
                                "raters",
                                "praised",
                                "asps",
                                "coast",
                                "gallery",
                                "largely",
                                "regally",
                                "amen",
                                "mane",
                                "mean",
                                "name",
                                "actors",
                                "costar",
                                "castor",
                                "actress",
                                "anew",
                                "wane",
                                "rental",
                                "apt",
                                "Antidisestablishmentarianism",
                                "pat",
                                "tap",
                                "arches",
                                "chaser",
                                "search",
                                "are",
                                "ear",
                                "tacos",
                                "asleep",
                                "elapse",
                                "starer",
                                "artist",
                                "strait",
                                "traits",
                                "arts",
                                "rats",
                                "star",
                                "tars",
                                "catered",
                                "created",
                                "reacted",
                                "cider",
                                "cried",
                                "dicer",
                                "claimed",
                                "decimal",
                                "declaim",
                                "medical",
                                "supercalifragilisticexpialidocious",
                                "slightly",
                                "arcs",
                                "cars",
                                "scar",
                                "ascent",
                                "secant",
                                "stance",
                                "ascot",
                                "coats",
                                "Pseudopseudohypoparathyroidism",
                                "asp",
                                "pas",
                                "sap",
                                "spa",
                                "aspired",
                                "asters",
                                "stares",
                                "aster",
                                "rates",
                                "honorificabilitudinitatibus",
                                "stare",
                                "taser",
                                "tears",
                                "ate",
                                "eat",
                                "despair",
                                "diapers",
                                "please",
                                "pass",
                                "saps",
                                "spas",
                                "assert",
                                "eta",
                                "tea",
                                "aridest",
                                "astride",
                                "staider",
                                "bared",
                                "beard",
                                "bread",
                                "debar",
                                "barely",
                                "tardies",
                                "tirades",
                                "auctioned",
                                "cautioned",
                                "education",
                                "awls",
                                "laws",
                                "slaw",
                                "baker",
                                "brake",
                                "break",
                                "Incomprehensibilities",
                                "bard",
                                "brad",
                                "popcorn",
                                "drab",
                                "819",
                                "barley",
                                "bleary",
                                "bats",
                                "stab",
                                "tabs",
                                "begin",
                                "being",
                                "binge",
                                "below",
                                "bowel",
                                "elbow",
                                "bleats",
                                "stable",
                                "tables",
                                "bluest",
                                "bluets",
                                "bustle",
                                "sublet",
                                "subtle",
                                "bores",
                                "robes",
                                "sober",
                                "brag",
                                "garb",
                                "grab",
                                "calipers",
                                "replicas",
                                "spiracle",
                                "caller",
                                "cellar",
                                "recall",
                                "canter",
                                "YouTube",
                                "nectar",
                                "recant",
                                "trance",
                                "canters",
                                "nectars",
                                "recants",
                                "scanter",
                                "trances",
                                "capes",
                                "paces",
                                "space",
                                "caret",
                                "cater",
                                "crate",
                                "trace",
                                "carets",
                                "caters",
                                "caster",
                                "crates",
                                "reacts",
                                "recast",
                                "traces"                              
        };
        
        #region Material
        //[TestMethod]
        //public void TestMethod2()
        //{
        //    string[] words = { "abed", "bade", "bead", "abet", "beat", "beta" };
        //    Anagrams temp = new();
        //    int count = 0;

        //    for (int i = 0; i < words.Length - 1; i++)
        //    {
        //        if (temp.Empty(words[i]) == temp.Empty(words[i + 1]))
        //        {
        //            count++;
        //        }
        //    }
        //    Assert.AreEqual(count, 4);
        //}
        #endregion

        [TestMethod]
        public void Sorting()
        {
            Anagrams anagrams = new();
            Assert.AreEqual(anagrams.Sort("Floccinaucinihilipilification"), anagrams.Sort("liFifINhiAliPIucloCcinICAtion"));
        }
        [TestMethod]
        public void Time_Measurement()
        {
            //TODO: HACER QUE COMPRENDA TODO EL ALGORITMO
            Anagrams anagrams = new();
            var s1 = Stopwatch.StartNew();
            StreamReader sr = new StreamReader(@"C:\Users\gasim\Downloads\wordlist.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                anagrams.Sort(line);
            }
            s1.Stop();
            TestContext.WriteLine(s1.Elapsed.TotalMilliseconds.ToString());
        }
        [TestMethod]
        public void Match()
        {
            Anagrams temp = new();
            //Assert.That(temp.Compare());
        }
    }
}
