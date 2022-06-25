using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVisitor.Base;

namespace TestVisitor.Concrete
{
    public class ShoppingVisitor : IVisitor<Item>
    {
        public double Visit(Item item)
        {
            double ret = 0.0;

            if(item.GetType() == typeof(ItemSoldInWeight))
            {
                ret = ((ItemSoldInWeight)item).Weight * ((ItemSoldInWeight)item).UnitPrice;
            }

            if (item.GetType() == typeof(ItemSoldInPieces))
            {
                ret = ((ItemSoldInPieces)item).NumberOfPieces * ((ItemSoldInPieces)item).UnitPrice;
            }

            return ret;
        }
    }
}
