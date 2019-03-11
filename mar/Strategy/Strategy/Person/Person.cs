using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Person
{
    abstract class Person
    {
        protected string name; //имя игрока
        protected string typePerson; // тип персонажа

        protected Iweapon weapon; // оружие

        public Person(string name) //конструктор нашего класса 
        {
            this.name = name;
            //this.weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine("Имя игрока: {0} \nТип персонажа: {1}  \nТип оружия: {2} \nНанесенный урон: {3}", name, typePerson, weapon.type(), weapon.damage());
        }

        public static Person CreatePlayer() // создание игрока
        {
            Console.WriteLine("Введите имя игрока");
            string name = Convert.ToString(Console.ReadLine());
            List<Person> persons = new List<Person> { new BowMan(name), new SwordMan(name), new StickMan(name) };
            Console.WriteLine("Выберите тип персонажа");

            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine("{0}.{1}", (i + 1), persons[i].typePerson);
            }

            int num = Convert.ToInt16(Console.ReadLine()) - 1;
            Console.WriteLine("Вы выбрали: {0}", persons[num].typePerson);

            return persons[num];
        }

        public void ChangeWeapon() // смена оружия
        {
            List<Iweapon> weapons = new List<Iweapon> { new WBow(), new WSword(), new WStick() };
            Console.WriteLine("Выберите тип оружия");

            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine("{0}.{1}", (i + 1), weapons[i].type());
            }

            int num = Convert.ToInt16(Console.ReadLine()) - 1;
            Console.WriteLine("Вы выбрали: {0}", weapons[num].type());
            this.weapon = weapons[num];
        }
    }
}
