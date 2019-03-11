using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Person
{
    class SwordMan : Person
    {
        public SwordMan(string name)
            : base(name)
        {
            this.name = name;
            this.typePerson = "SwordMan";
            this.weapon = new WSword();
        }
    }
}
