using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer_Assistant.Model
{
    public abstract class Item
    {
        public String Label { get; set; }
        public long Ref { get; set; }
        public float Price { get; set; }
        
    }
}
