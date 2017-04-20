using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectNetFramwork
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual<string>("StandardLibrary",
                StandardLibrary.Thing.Method1());
        }
    }
}
