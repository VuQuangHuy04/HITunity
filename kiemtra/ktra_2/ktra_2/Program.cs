using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace Bai3
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Character(string name, int health){
            Name = name;
            Health = health;
        }
        public virtual void UseAbility()
        {
        }
    }
    public class Warrior : Character{
        public Warrior(string name, int health): base
        {
        }


        public override void UseAbility()
        {
            Console.WriteLine($"{Name} dung Xoay bua");
        }
    }
    public class Mage : Character
    {
        public Mage(string name, int health) : base
        {

        }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} dung chu ngu");
        }
    }

    class programs
    {
        static void Main(string[] args)
        {
            Warrior a = new Warrior("a", 10);
            Warrior b = new Warrior("b", 10);
            Mage c = new Mage("c", 10);
            a.UseAbility();
            b.UseAbility();
            c.UseAbility();
        }
        }
    }
}
