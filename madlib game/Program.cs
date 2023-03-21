using System;


namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebirty;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebirty = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine( pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebirty );

            Console.ReadLine();
        }
    }

}