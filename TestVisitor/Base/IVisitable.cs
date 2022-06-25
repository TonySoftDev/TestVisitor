using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVisitor.Concrete;

namespace TestVisitor.Base
{
    public interface IVisitable
    {
        double Accept(IVisitor visitor);
    }
}
