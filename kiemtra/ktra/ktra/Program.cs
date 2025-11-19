using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace Bai1
{
    public class Wizard
    {
        public string Name {  get; set; }
        public int Damage {  get; set; }
        public int Mana {  get; set; }
        public Wizard(string name,int damage, int mana) {
        this.Name = name;
        this.Damage = damage;
        this.Mana = mana;
        }
        public string CastSpell()
        {
            return $"tung chưởng {Name} gây {Damage} sát thương với {Mana} Mana";
        }
    }
   class Controller
    {
        static void Main(string[] args)
        {
            Wizard w = new Wizard("Fireball", 30, 50);
            Console.Write("Thay phap huy"); Console.WriteLine(w.CastSpell());
        }
    }
}
