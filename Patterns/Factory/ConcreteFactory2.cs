using System;

namespace Patterns.Factory
{
    public class ConcreteFactory2 : IAbsFactory
    {
        public IAbsProduitA CreateProduitA()
        {
            return new ConcreteProduitA2();
        }

        public IAbsProduitB CreateProduitB()
        {
            return new ConcreteProduitB2();
        }
    }
}
