using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGame
{
    class Player
    {
        private string name;
        private int level;
        private double hatBonus;
        private int xp;

        public Player(String name, double hatBonus ) 
        {
            this.name = name;
            this.level = 1;
            this.hatBonus = 1;
            this.xp = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int XP
        {
            get
            {
                return xp;
            }

            set
            {
                xp = value;
            }
        }
        public double HatBonus
        {
            set { this.hatBonus = value; }
            get { return hatBonus; }
        } 
    }
}
