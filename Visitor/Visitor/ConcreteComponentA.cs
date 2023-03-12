using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }
        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}
