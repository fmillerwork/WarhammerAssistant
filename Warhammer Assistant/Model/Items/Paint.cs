using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer_Assistant.Model.SubItem;

namespace Warhammer_Assistant.Model
{
    public class Paint : Item
    {
        public String FilledLv { get; set; }
        public String Type { get; set; }
        public String Color { get; set; }

        public Paint(String filledLv, String type, String color, float price, long _ref, String label)
        {
            FilledLv = filledLv;
            Type = type;
            Color = color;
            Price = price;
            Ref = _ref;
            Label = label;
        }
    }
}
