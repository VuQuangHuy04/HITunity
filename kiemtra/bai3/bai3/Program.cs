using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace Bai3
{
    public abstract class GameEntity
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public GameEntity(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }
        public bool isAlive()
        {
            if (Health < 0) { 
                return false;
            }
            return true;
        }
        public virtual void PerformAttack(GameEntity e)
        {
        }
    }
    public class Player : GameEntity
    {
        public Player(string name, int health, int damage) : base(name, health, damage) { }
        public override void PerformAttack(GameEntity e)
        {
            e.TakeDamage(Damage);
            Console.WriteLine($"player tan cong slime {Damage} dmg");
            Console.WriteLine("player có hp "+ Health);
            Console.WriteLine("slayer có hp "+ e.Health);
        }
    }
    public class Enemy : GameEntity
    {
        public Enemy(string name, int health, int damage) : base(name, health, damage) { 
        }
        public override void PerformAttack(GameEntity e)
        {   
            e.TakeDamage(Damage);
            Console.WriteLine($"slime tan cong player {Damage} dmg");
            Console.WriteLine("slime có hp " + Health);
            Console.WriteLine("slayer có hp " + e.Health);
        }
    }
    class CombatSystem()
    {
        public static void StartCombat(Player p,List<Enemy> listEnemies)
        {
            Console.WriteLine("tan cong dau tien trong ds");
        }
    }
    class programs
    {
        static void Main(string[] args)
        {   
            Player a = new Player("slayer", 5, 3);
            Enemy b = new Enemy("Slime", 10, 3);
            Console.WriteLine("player có hp " + 5);
            Console.WriteLine("enemy có hp " + 10);
            while (true) { 
            a.PerformAttack(b);
                b.PerformAttack(a);
                if(a.Health == 0)
                {
                    Console.WriteLine("ket tthuc");
                    Console.WriteLine("slime win");
                    break;
                }
                if (b.Health == 0)
                {
                    Console.WriteLine("ket thuc");
                    Console.WriteLine("slayer win");
                    break;
                }
            }
        }
    }
}
