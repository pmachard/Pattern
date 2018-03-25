using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class ConcreteDecorator : Decorator
    {
        public override string Method()
        {
            return "ConcreteDecorator";
        }
    }
}
