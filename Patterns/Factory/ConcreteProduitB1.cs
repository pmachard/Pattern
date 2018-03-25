using System;

namespace Patterns.Factory
{
    public class ConcreteProduitB1 : IAbsProduitB
    {
        public void RunB()
        {
            Console.WriteLine("ConcreteProduitB1.RunB");
        }
    }
}
