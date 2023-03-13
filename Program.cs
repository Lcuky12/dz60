using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minHeroHealth = 200;
            int maxHeroHealth = 350;
            float heroHealthRandom = random.Next(minHeroHealth, maxHeroHealth + 1);
            int minHeroArmor = 25;
            int maxHeroArmor = 50;
            int heroArmorRandom = random.Next(minHeroArmor, maxHeroArmor + 1);
            int minHeroDamage = 100;
            int maxHeroDamage = 150;
            int heroDamageRandom = random.Next(minHeroDamage, maxHeroDamage + 1);
            int minBossHealth = 750;
            int maxBossHealth = 1000;
            float bossHealthRandom  = random.Next(minBossHealth, maxBossHealth + 1);
            int minBossArmor = 25;
            int maxBossArmor = 75;
            int bossArmorRandom = random.Next(minBossArmor, maxBossArmor + 1);
            int minBossDamage = 75;
            int maxBossDamage = 100;
            int bossDamageRandom = random.Next(minBossDamage, maxBossDamage + 1);
            int lightningWrath = 125;
            int heroHealthRecovery = 75;
            int meteor = 150;
            int antiTarget;
            int number = 100;
            int number2 = 0;

            Console.WriteLine(" Герой - " + heroHealthRandom + " хп, " + heroDamageRandom + " урон, " + heroArmorRandom + " броня ");
            Console.WriteLine(" Босс - " + bossHealthRandom + " хп, " + bossDamageRandom + " урон, " + bossArmorRandom + " броня ");
        
            while (heroHealthRandom > number2 && bossHealthRandom > number2)
            {
                heroHealthRandom -= bossDamageRandom / number * heroArmorRandom;
                bossHealthRandom -= heroDamageRandom / number * bossArmorRandom;
                Console.WriteLine(" Герой -  " + heroHealthRandom + " . ");
                Console.WriteLine(" Босс  - " + bossHealthRandom + " . ");
            }
            if (heroHealthRandom <= number2 && bossHealthRandom <= number2)
            {
                Console.WriteLine(" Ничья ");
            }
            else if ( heroHealthRandom <= number2 )
            {
                Console.WriteLine(" Герой пал ");
            }
            else if ( bossHealthRandom <= number2)
            {
                Console.WriteLine(" Босс пал ");
            }
        }
    }
}
