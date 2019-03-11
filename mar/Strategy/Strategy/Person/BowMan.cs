using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Person
{
    class BowMan : Person
    {
        public BowMan(string name)
            : base(name)
        {
            this.name = name;
            this.typePerson = "BowMan";
            this.weapon = new WBow();
        }
    }
}
