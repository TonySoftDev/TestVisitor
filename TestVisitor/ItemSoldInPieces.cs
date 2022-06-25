using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVisitor
{
    public class ItemSoldInPieces : Item, IVisitable
    {
        public double UnitPrice { get; set; }
        public int NumberOfPieces { get; set; }

        public ItemSoldInPieces(string code, string descriprion)
        {
            this.Code = code;
            this.Description = descriprion;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }


    }
}
