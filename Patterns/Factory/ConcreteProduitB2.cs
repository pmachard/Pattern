using System;

namespace Patterns.Factory
{
    public class ConcreteProduitB2 : IAbsProduitB
    {
        public void RunB()
        {
            Console.WriteLine("ConcreteProduitB2.RunB");
        }
    }
}
