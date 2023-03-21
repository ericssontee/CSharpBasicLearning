using System;

namespace Arrayy
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Jamie";

            luckyNumbers[1] = 900;

            Console.WriteLine( luckyNumbers[1] +  friends[1]);

            Console.ReadLine();
        }
    }
}