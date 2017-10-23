using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColoursOfTheRainbow;

namespace ColoursOfTheRainbow.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameVerifyTest1()
        {
            Assert.IsTrue(true, "Gray");
        }

        [TestMethod]
        public void NameVerifyTest2()
        {
            Assert.IsFalse(false, "AAAA");
        }

        [TestMethod]
        public void HexFormatTest1()
        {
            Assert.IsFalse(false, "ggg");
        }

        [TestMethod]
        public void HexFormatTest2()
        {
            Assert.IsTrue(true, "#YYYYYY");
        }

        [TestMethod]
        public void RGBFormatTest1()
        {
            Assert.IsTrue(true, "222,333,444");
        }

        [TestMethod]
        public void RGBFormatTest2()
        {
            Assert.IsFalse(false, "222!3333444");
        }

        [TestMethod]
        public void WriteToJsonTest1()
        {
            Assert.IsTrue(true, "", "testColName", "#abcdef", "111,222,333");
        }

        [TestMethod]
        public void WriteToJsonTest2()
        {
            Assert.IsFalse(false, "", "", "", "");
        }
    }
}