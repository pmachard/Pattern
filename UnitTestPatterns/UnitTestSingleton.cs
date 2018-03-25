using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Singleton;

namespace UnitTestPatterns
{
    [TestClass]
    public class UnitTestSingleton
    {
        [TestMethod]
        public void TestMethodFctA()
        {
            Singleton.Instance.FctA();
        }

        [TestMethod]
        public void TestMethodFctB()
        {
            Singleton.Instance.FctB();
        }
    }
}
