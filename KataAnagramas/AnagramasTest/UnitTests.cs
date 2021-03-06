using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagramas;
using System.Diagnostics;
using System.IO;

namespace KataAnagramasTest
{
    [TestClass]
    public class UnitTests
    {
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
        private Anagrams anagrams = new();

        [TestMethod]
        public void Input_Sanitizing()
        {
            string output = anagrams.Sanitize("floccinaucinihilipilification");
            Assert.AreEqual("aaccccffhiiiiiiiiilllnnnooptu", output);
        }
        [TestMethod]
        public void Are_Anagrams()
        {
            anagrams.Check("Floccinaucinihilipilification");
            bool exists = anagrams.Check("liFifinhialipiucloccinication");
            Assert.AreEqual(true, exists);
        }
        [TestMethod]
        public void Counters()
        {            
            foreach (string word in list)
            {
                anagrams.Check(word);
            }
            Assert.AreEqual((60, 210), anagrams.Print());
        }
    }
}
