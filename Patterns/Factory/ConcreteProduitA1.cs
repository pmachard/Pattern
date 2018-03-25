using System;

namespace Patterns.Factory
{
    public class ConcreteProduitA1 : IAbsProduitA
    {
        public void RunA()
        {
            Console.WriteLine("ConcreteProduitA1.RunA");
        }
    }
}
