using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer_Assistant.Model.SubItem
{
    public class PaType
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public PaType(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
