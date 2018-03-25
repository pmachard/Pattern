using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Factory;

namespace UnitTestPatterns
{
    [TestClass]
    public class UnitTestAbsFactory
    {
        [TestMethod]
        public void TestMethodFctA()
        {
            var factory = new ConcreteFactory1();
            Assert.IsTrue(factory.CreateProduitA() is ConcreteProduitA1);
            Assert.IsTrue(factory.CreateProduitB() is ConcreteProduitB1);
        }

        [TestMethod]
        public void TestMethodFctB()
        {
            var factory = new ConcreteFactory2();
            Assert.IsTrue(factory.CreateProduitA() is ConcreteProduitA2);
            Assert.IsTrue(factory.CreateProduitB() is ConcreteProduitB2);
        }

        [TestMethod]
        public void TestMethodClientFactory()
        {
            var client = new ConcreteClientFactory(new ConcreteFactory1());

            Assert.IsTrue(client.CreateProduitA() is ConcreteProduitA1);
            Assert.IsTrue(client.CreateProduitB() is ConcreteProduitB1);
        }

        
    }
}
