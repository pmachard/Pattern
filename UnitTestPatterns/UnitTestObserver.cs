using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Observer;

namespace UnitTestPatterns
{
    [TestClass]
    public class UnitTestObserver
    {
        [TestMethod]
        public void TestMethod_Observer()
        {
            ISubject subject = new Subject();
            Assert.AreEqual("Subject", subject.NotifyObservers());
        }

        [TestMethod]
        public void TestMethod_Observer_A()
        {
            ISubject subject = new Subject();
            subject.RegisterObserver(new ConcreteObserverA());

            Assert.AreEqual("Subject;ConcreteObserverA", subject.NotifyObservers());
        }

        [TestMethod]
        public void TestMethod_Observer_B()
        {
            ISubject subject = new Subject();
            subject.RegisterObserver(new ConcreteObserverB());

            Assert.AreEqual("Subject;ConcreteObserverB", subject.NotifyObservers());
        }

        [TestMethod]
        public void TestMethod_Observer_AB()
        {
            ISubject subject = new Subject();
            subject.RegisterObserver(new ConcreteObserverA());
            subject.RegisterObserver(new ConcreteObserverB());

            Assert.AreEqual("Subject;ConcreteObserverA;ConcreteObserverB", subject.NotifyObservers());
        }
    }
}
