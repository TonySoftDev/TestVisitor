using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVisitor.Concrete
{
    public interface IVisitor
    {
        double Visit(ItemSoldInWeight item);
        double Visit(ItemSoldInPieces item);
    }

}
