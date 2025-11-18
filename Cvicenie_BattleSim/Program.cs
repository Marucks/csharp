using System.Collections.Concurrent;

namespace Cvicenie_BattleSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ourHero = new Hero();
            Monster monster1 = new Monster("Goblin",20,5);
            
            while (true)
            {
                monster1.MonsterAttack(ourHero);
                bool wasAttack = ourHero.HeroAttack(monster1);
                
                Console.WriteLine("Hero HP:" + ourHero.HP);
                Console.WriteLine("Monster HP:" + monster1.HP);
                Console.WriteLine(monster1);
            
                if (ourHero.HP <= 0)
                {
                    Console.WriteLine("Hero has died...");
                    break;
                }
                if (monster1.HP <= 0)
                {
                    Console.WriteLine("Monster has died!");
                    break;
                }
            
            
            
            
            }

        }
    }
}
