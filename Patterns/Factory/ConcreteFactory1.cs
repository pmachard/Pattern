using System;

namespace Patterns.Factory
{
    public class ConcreteFactory1 : IAbsFactory
    {
        public IAbsProduitA CreateProduitA()
        {
            return new ConcreteProduitA1();
        }

        public IAbsProduitB CreateProduitB()
        {
            return new ConcreteProduitB1();
        }
    }
}
