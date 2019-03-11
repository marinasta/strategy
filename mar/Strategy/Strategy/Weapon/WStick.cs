using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class WStick : Iweapon
    {
        Random rand = new Random();

        string typeWeapon = "Stick";

        public string type()
        {
            return typeWeapon;
        }

        public int maxdmg
        {
            get { return 20; }
        }

        public int mindmg
        {
            get { return 10; }
        }

        public int damage()
        {
            return rand.Next(mindmg, maxdmg);
        }

    }
}
