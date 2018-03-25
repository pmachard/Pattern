using System;

namespace Patterns.Factory
{
    public class ConcreteClientFactory : IClientFactory
    {
        private IAbsFactory _factory;

        public ConcreteClientFactory(IAbsFactory factory)
        {
            Factory = factory;
        }

        public IAbsFactory Factory
        {
            set { _factory = value; }
        }

        public IAbsProduitA CreateProduitA()
        {
            return _factory.CreateProduitA();
        }

        public IAbsProduitB CreateProduitB()
        {
            return _factory.CreateProduitB();
        }
    }
}
