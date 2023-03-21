using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Eric", 26);
            SayHi("Ericsson", 27);
            SayHi("Ric", 23);
            SayHi("Tak", 19);
            Console.ReadLine();
        }

        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello User " + name + " you are " + age);
        }
    }
}