using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pepe;
using System;

namespace KataAnagramasTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void TestMethod1()
        {
            Temp temp = new();
            Assert.AreEqual(temp.InternalSum("hola"), temp.InternalSum("alAoh"));
        }
        //[TestMethod]
        public void TestMethod2()
        {
            string[] words = { "abed", "bade", "bead", "abet", "beat", "beta"};
            Temp temp = new();
            int count = 0;
            
            for (int i = 0; i < words.Length-1; i++)
            {
                if (temp.Empty(words[i]) == temp.Empty(words[i + 1]))
                {
                    count++;
                }     
            }
            Assert.AreEqual(count, 4);
        }
        [TestMethod]
        public void Sanitize()
        {
            Temp temp = new();
            Assert.AreEqual(temp.Sanitize("hola"), temp.Sanitize("Aloh"));
        }
    }
}