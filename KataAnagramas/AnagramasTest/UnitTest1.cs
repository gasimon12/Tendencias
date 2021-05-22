using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pepe;
using System;

namespace KataAnagramasTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string[] words = { "hola", "aloh", "olalah", "piper", "repip", "crust" };
            Temp temp = new();
            Assert.AreEqual(temp.InternalSum("hola"), temp.InternalSum("alAoh"));            
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Assert.AreEqual(anagrams.InternalSum(words[i].ToCharArray()[i].), 2));
            //}
        }
        [TestMethod]
        public void TestMethod2()
        {
            string[] words = { "abed", "bade", "bead", "abet", "beat", "beta"};

            Temp temp = new();
            int count = 0;
            for (int i = 0; i < words.Length-1; i++)
            {
                if (temp.Hash(words[i]) == temp.Hash(words[i + 1]))
                {
                    count++;
                }     
            }
            Assert.AreEqual(count, 4);

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Assert.AreEqual(anagrams.InternalSum(words[i].ToCharArray()[i].), 2));
            //}
        }
    }
}
