using BuildZoo.Classes;
using System;

namespace BuildZoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zootopia");
            Console.WriteLine(" ");
            Console.WriteLine("==================");
            Console.WriteLine(" ");
            //5 concreate animals from base classes

            Console.WriteLine("Snakes:");
            SneakySnake();
            Console.WriteLine(" ");
            Console.WriteLine("Puppies:");
            PuppyPower();
            Console.WriteLine(" ");
            Console.WriteLine("Lobsters: ");
            LobbieLobster();
            Console.WriteLine(" ");
            Console.WriteLine("==========");

        }

        public static void LobbieLobster()
        {
            Lobster theLobster = new Lobster();
            Console.WriteLine(theLobster.Eat());
            Console.WriteLine(theLobster.Are());
        }

        public static void SneakySnake()
        {
            Snake theSnake = new Snake();
            Console.WriteLine(theSnake.Are());
        }

        public static void PuppyPower()
        {
            Puppy theCutest = new Puppy();
            Console.WriteLine(theCutest.Have());
            Console.WriteLine(theCutest.HaveVocalChords());
            Console.WriteLine(theCutest.Eat());
            Console.WriteLine(theCutest.Chew());
            Console.WriteLine(theCutest.Are());
        }
        

    }
}
