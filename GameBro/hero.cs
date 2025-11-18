
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace game
{
    public class hero
    {
        int energyget = 5;

        public string Name { get; set; }
        public double HP { get; set; } = 100;
        public double Strenght { get; set; } = 1;
        public double Energy { get; set; } = 10;
        public double Armor { get; set; } = 0;
        public double Mana { get; set; } = 100;

        public hero(string HeroName)
        {
            Name = HeroName;
        }


        public void AttPerPoint(Attributes stats)
        {
            HP = HP + 
        }


    }
}
