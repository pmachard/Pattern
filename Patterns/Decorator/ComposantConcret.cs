using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class ConcreteComposant : Composant
    {
        public override string Method()
        {
            return "ConcreteComposant";
        }
    }
}
