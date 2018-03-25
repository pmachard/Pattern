using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Decorator;

namespace UnitTestPatterns
{
    [TestClass]
    public class UnitTestDecorator
    {
        [TestMethod]
        public void TestMethod_ComposantConcret()
        {
            var composant = new ConcreteComposant();
            Assert.AreEqual("ConcreteComposant", composant.Method());
        }

        [TestMethod]
        public void TestMethod_DecoratorConcret()
        {
            var composant = new ConcreteDecorator();
            Assert.AreEqual("ConcreteDecorator", composant.Method());
        }

        [TestMethod]
        public void TestMethod_DecoratorConcretA()
        {
            var composant = new ConcreteDecoratorA();
            Assert.AreEqual("ConcreteDecoratorA", composant.Method());
        }

        [TestMethod]
        public void TestMethod_DecoratorConcretB()
        {
            var composant = new ConcreteDecoratorB();
            Assert.AreEqual("ConcreteDecoratorB", composant.Method());
        }

        [TestMethod]
        public void TestMethod_Decorator()
        {
            var composant = new Decorator();
            Assert.AreEqual("Decorator", composant.Method());
        }

        [TestMethod]
        public void TestMethod_Decorator_1()
        {
            var composant = new Decorator();
            composant.AddComposant(new ConcreteComposant());

            Assert.AreEqual("Decorator;ConcreteComposant", composant.Method());
        }

        [TestMethod]
        public void TestMethod_Decorator_2()
        {
            var composant = new Decorator();
            composant.AddComposant(new ConcreteDecoratorA());
            composant.AddComposant(new ConcreteDecoratorB());

            Assert.AreEqual("Decorator;ConcreteDecoratorA;ConcreteDecoratorB", composant.Method());
        }

    }
}
