using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class ConcreteDecoratorB : ConcreteDecorator
    {
        public override string Method()
        {
            return "ConcreteDecoratorB";
        }
    }
}
