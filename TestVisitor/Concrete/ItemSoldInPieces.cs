using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVisitor.Base;

namespace TestVisitor.Concrete
{
    public class ItemSoldInPieces : Item, IVisitable
    {
        public double UnitPrice { get; set; }
        public int NumberOfPieces { get; set; }

        public ItemSoldInPieces(string code, string descriprion)
        {
            Code = code;
            Description = descriprion;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }


    }
}
