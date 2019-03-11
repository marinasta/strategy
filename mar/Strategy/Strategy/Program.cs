using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = Person.CreatePlayer();

            person.Attack();
            person.ChangeWeapon();
            person.Attack();

            Console.ReadKey();
        }
    }
}
