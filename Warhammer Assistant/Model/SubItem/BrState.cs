using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer_Assistant.Model.SubItem
{
    public class BrState
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public BrState(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
