using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class Decorator : Composant
    {
        private List<Composant> _composants;

        public Decorator()
        {
            _composants = new List<Composant>();
        }

        public void AddComposant(Composant composant)
        {
            _composants.Add(composant);
        }

        public override string Method()
        {
            string result = "Decorator";

            foreach(var item in _composants)
            {
                result += ";"+item.Method();
            }

            return result;
        }
    }
}
