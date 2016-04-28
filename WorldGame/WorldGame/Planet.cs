using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGame
{
    public class Planet
    {

       private String planetSize;
     private   bool breathable;
       private bool water;
       private String planetName;
        

        public Planet(String x)
        {
            this.water = true;
            this.breathable = true;
            this.planetSize = "small";
            this.planetName = x;
        }

    }
}
