using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer_Assistant.Model.SubItem
{
    public class BrName
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public BrName(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
