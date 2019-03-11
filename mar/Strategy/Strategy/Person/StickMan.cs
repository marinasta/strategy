using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Person
{
    class StickMan : Person
    {
        public StickMan(string name)
            : base(name)
        {
            this.name = name;
            this.typePerson = "StickMan";
            this.weapon = new WStick();
        }
    }
}
