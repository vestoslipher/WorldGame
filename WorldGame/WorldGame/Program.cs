using System;

   

    public class planet
    {

    String planetSize;
    bool breathable;
    bool water;
    String planetName;

        public planet(String x)
{
        this.water = true;
        this.breathable = true;
        this.planetSize = "small";
        this.planetName = x;
}    




    }


    public class Model //for functions
    { 
        public Model()
        {
            
        }

    }

    public class program //main app
    {
        static void Main(string[] args)
        {

        bool check = true;
        String userName;
        String planetName;

        Console.WriteLine("Hello! You are the only surivor of a spaceship crash on an unknown planet. To survive you must do science and invent new things.");
        Console.WriteLine("Do you wish to continue?");

        if (string.Equals(Console.ReadLine(), "no", System.StringComparison.OrdinalIgnoreCase) || string.Equals(Console.ReadLine(), "y", System.StringComparison.OrdinalIgnoreCase))
            {
            Console.WriteLine("fuck you then");
        }
        else
        {
            Console.WriteLine("good");
        }

        Console.WriteLine("What is your name?");

        userName = Console.ReadLine();

        Console.WriteLine("'" + userName + "'" +  " ha thats a funny name");

        Console.WriteLine("What would you like to name this planet?");

        planetName = Console.ReadLine();
        planet planet = new planet(planetName);

        Console.WriteLine(planetName + " giggle..");
        Console.WriteLine("...");

        Console.WriteLine("To survive you need 4 things:");
        Console.WriteLine("- Shelter");
        Console.WriteLine("- Food");
        Console.WriteLine("- Breathable air");
        Console.WriteLine("And water. You need water.");
        Console.WriteLine("...");
        Console.WriteLine("Luckily for you, the planet you're on currently on has all this. For now.");


        Console.ReadKey();

    }
}
