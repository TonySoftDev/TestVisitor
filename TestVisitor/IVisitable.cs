using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVisitor
{
    public interface IVisitable
    {
        double Accept(IVisitor visitor);
    }
}
