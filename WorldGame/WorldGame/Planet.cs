using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGame
{
    public class planet
    {

       private String planetSize;
     private   bool breathable;
       private bool water;
       private String planetName;

        public planet(String x)
        {
            this.water = true;
            this.breathable = true;
            this.planetSize = "small";
            this.planetName = x;
        }

    }
}
