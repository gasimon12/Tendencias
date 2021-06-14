using KataRange;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKataRange
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_Lower_Limit()
        {
            Range range = new Range("(2,22)");
            Assert.AreEqual(2, range.lowerLimit);
        }
        [TestMethod]
        public void Constructor_Upper_Limit()
        {
            Range range = new Range("(2,22)");
            Assert.AreEqual(22, range.upperLimit);
        }
    }
}
