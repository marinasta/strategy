using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface Iweapon //интерфейс оружия
    {
        string type();
        int damage();

        int maxdmg { get; }
        int mindmg { get; }
    }
}
