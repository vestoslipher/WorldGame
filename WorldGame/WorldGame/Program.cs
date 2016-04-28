using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGame
{

    public class View //for GUI
    {
        public  View() 
        {
            
        }

    }

    public class Model //for functions
    {

        public Model()
        {
            
            public 
        }

    }

    public class program //main app
    {
        static void Main(string[] args)
        {
            bool check = true;

            Console.WriteLine("Hello! You are the only surivor of a spaceship crash on an unknown planet. To survive you must do science and invent new things.");
            Console.WriteLine("Do you wish to continue?");

            
            Console.ReadKey();
            if(Console.ReadLine() == "no")
            {
                Console.WriteLine("fuck you then");
            } else
            {
                Console.WriteLine("good for you");
            }

            Console.WriteLine("What is your name?");









            Console.ReadKey();
        }
    }
}
