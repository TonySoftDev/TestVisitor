using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVisitor
{
    public class ItemSoldInWeight : Item, IVisitable
    {
        public double UnitPrice { get; set; }
        public double Weight { get; set; }

        public ItemSoldInWeight(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
