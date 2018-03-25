using System;

namespace Patterns.Factory
{
    public interface IAbsFactory
    {
        IAbsProduitA CreateProduitA();
        IAbsProduitB CreateProduitB();
    }
}
