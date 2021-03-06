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
        [TestMethod]
        public void Even_Inclusive()
        {
            Range range = new Range("(20,30]");
            Assert.AreEqual(25, range.GetMidPoints()[0]);
            Assert.AreEqual(26, range.GetMidPoints()[1]);
        }
        [TestMethod]
        public void Odd_Inclusive()
        {
            Range range = new Range("[40,51)");
            Assert.AreEqual(45, range.GetMidPoints()[0]);            
        }
        [TestMethod]
        public void Four_NotInclusive()
        {
            Range range = new Range("(40,43)");
            Assert.AreEqual(41, range.GetMidPoints()[0]);
            Assert.AreEqual(42, range.GetMidPoints()[1]);
        }
        [TestMethod]
        public void Four_Inclusive()
        {
            Range range = new Range("[40,43]");
            Assert.AreEqual(41, range.GetMidPoints()[0]);
            Assert.AreEqual(42, range.GetMidPoints()[1]);
        }
        [TestMethod]
        public void Three_Inclusive()
        {
            Range range = new Range("[23,25]");
            Assert.AreEqual(24, range.GetMidPoints()[0]);
        }
        [TestMethod]
        public void Three_NotInclusive()
        {
            Range range = new Range("(23,25)");
            Assert.AreEqual(24, range.GetMidPoints()[0]);
        }
        [TestMethod]
        public void Two_Inclusive()
        {
            Range range = new Range("[23,24]");
            Assert.AreEqual(23, range.GetMidPoints()[0]);
            Assert.AreEqual(24, range.GetMidPoints()[1]);
        }
        [TestMethod]
        public void Two_NotInclusive()
        {
            Range range = new Range("(23,24)");
            Assert.AreEqual(null, range.GetMidPoints());           
        }
    }
}
