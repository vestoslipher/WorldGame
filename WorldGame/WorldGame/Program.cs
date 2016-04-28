using System;
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
            Console.WriteLine("Hello! You must build industries and do science to get further out in space and find new planets.");
            Console.WriteLine("Do you wish to continue?");

           if (string.Equals(Console.ReadLine(), "yes", System.StringComparison.OrdinalIgnoreCase) || string.Equals(Console.ReadLine(), "y", System.StringComparison.OrdinalIgnoreCase))
            {
            Console.WriteLine("Good. ");
            }

        }
    }

