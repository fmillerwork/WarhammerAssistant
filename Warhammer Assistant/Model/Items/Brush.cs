using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer_Assistant.Model.SubItem;

namespace Warhammer_Assistant.Model
{
    public class Brush : Item
    { 
        public String State { get; set; }

        public Brush(string state, float price, long _ref, String label)
        {
            State = state;
            Price = price;
            Ref = _ref;
            Label = label;
        }
    }
}
