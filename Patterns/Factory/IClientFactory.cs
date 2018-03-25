using System;

namespace Patterns.Factory
{
    public interface IClientFactory
    {
        IAbsFactory Factory { set; }
        IAbsProduitA CreateProduitA();
        IAbsProduitB CreateProduitB();
    }
}
