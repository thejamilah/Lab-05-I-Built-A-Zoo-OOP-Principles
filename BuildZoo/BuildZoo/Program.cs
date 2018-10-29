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

            Console.WriteLine("Snakes are ");
            Console.WriteLine(" ");
            Console.WriteLine("Puppies are ");
            Console.WriteLine(" ");
            Console.WriteLine("Ducks are ");
            Console.WriteLine(" ");
            Console.WriteLine("Worms are ");
            Console.WriteLine(" ");
            Console.WriteLine("Lobsters: ");
            Console.WriteLine(" ");
            LobbieLobster();

            Console.WriteLine("==========");

        }

        public static void LobbieLobster()
        {
            Lobster theLobster = new Lobster();
            Console.WriteLine(theLobster.Eat());
            Console.WriteLine(theLobster.Are());
        }
        

    }
}
