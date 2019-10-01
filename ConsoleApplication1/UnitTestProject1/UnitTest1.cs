using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOdd()
        {
            bool result1 = Program.IsOdd(2);
            Assert.AreEqual(false, result1);

            bool result2 = Program.IsOdd(3);
            Assert.AreEqual(true, result2);
        }

        [TestMethod]
        public void TestEven()
        {

            bool result3 = Program.IsEven(4);
            Assert.AreEqual(true, result3);
            bool result4 = Program.IsEven(5);
            Assert.AreEqual(false, result4);
        }
    }
}
