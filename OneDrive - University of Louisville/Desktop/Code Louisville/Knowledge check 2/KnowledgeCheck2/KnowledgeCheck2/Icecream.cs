using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Icecream
    {
        public string name;
        public Flavor flavor;
        
        public string price;
        public string review;
    }

    public class Flavor
    {
        public string name;
        public Flavor(string name) { this.name = name; }
    }
}
