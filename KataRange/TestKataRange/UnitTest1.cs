using KataRange;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKataRange
{
    [TestClass]
    public class UnitTest1
    {
        #region Constructor
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
        [TestMethod]
        public void Constructor_Lower_Limit_NotInclusive()
        {
            Range range = new Range("(2,22]");
            Assert.AreEqual(false, range.lowerInclusive);
        }
        [TestMethod]
        public void Constructor_Upper_Limit_Inclusive()
        {
            Range range = new Range("(2,22]");
            Assert.AreEqual(true, range.upperInclusive);
        } 
        #endregion
        [TestMethod]
        public void Even_NotInclusive()
        {
            Range range = new Range("(20,30)");
            Assert.AreEqual(25, range.GetMidPoints()[0]);
        }
        [TestMethod]
        public void Odd_NotInclusive()
        {
            Range range = new Range("(1,9)");
            Assert.AreEqual(5, range.GetMidPoints()[0]);
        }
    }
}
