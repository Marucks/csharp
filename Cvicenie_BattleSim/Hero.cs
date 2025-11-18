using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSim
{
    internal class Hero
    {
        public string Name {  get; set; }  = "Fero";
        public int HP { get; set; } = 20;
        public int DMG { get; set; } = 1;
        public int ENG { get; set; } = 5;
        public int DEF { get; set; } = 2;
        public void HeroAttack(Monster monster)
        {
            if (ENG - 1)
                monster.HP = monster.HP - DMG;

        }
    }
}
