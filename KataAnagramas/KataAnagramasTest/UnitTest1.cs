using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Anagrams;

namespace KataAnagramasTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] words = { "hola", "aloh", "olalah", "piper", "repip", "crust" };
            AnagramsMachine anagrams = new AnagramsMachine();
            for (int i = 0; i < words.Length; i++)
            {
                Assert.AreEqual(anagrams.InternalSum(words[i].ToCharArray()[i].), 2));
            }
        }
    }
}
