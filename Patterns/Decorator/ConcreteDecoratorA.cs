using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class ConcreteDecoratorA : ConcreteDecorator
    {
        public override string Method()
        {
            return "ConcreteDecoratorA";
        }
    }
}
