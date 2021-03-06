using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVisitor.Base
{
    public interface IVisitable<T> where T : class
    {
        double Accept(IVisitor<T> visitor);
    }
}
