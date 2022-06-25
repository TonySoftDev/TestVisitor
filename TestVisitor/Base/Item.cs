using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVisitor.Base
{
    public abstract class Item
    {
        protected string Code { get; set; } = string.Empty;
        protected string Description { get; set; } = string.Empty;
    }
}
