using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Anagrams;

namespace AnagramsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void First_Argument_Null()
        {
            AnagramsClass anagrams = new AnagramsClass();
            NUnit.Framework.Assert.That(() => anagrams.Check(null, "roma"), Throws.ArgumentNullException);
        }
        [TestMethod]
        public void Second_Argument_Null()
        {
            AnagramsClass anagrams = new AnagramsClass();
            NUnit.Framework.Assert.That(() => anagrams.Check("roma", null), Throws.ArgumentNullException);
        }
        [TestMethod]
        public void Both_Arguments_Null()
        {
            AnagramsClass anagrams = new AnagramsClass();
            NUnit.Framework.Assert.That(() => anagrams.Check(null, null), Throws.ArgumentNullException);
        }
        [TestMethod]
        public void Arguments_Different_Lengths()
        {
            AnagramsClass anagrams = new AnagramsClass();
            NUnit.Framework.Assert.AreEqual(anagrams.Check("rosita", "rosa"), false);
        }
    }
}
