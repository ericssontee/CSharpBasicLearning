using System;

namespace IfStament
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;

// Basic If Else statement
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }

// With OR operator
            if (isMale || isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }

// Else If
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you ar tall.");
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }

            Console.ReadLine();
        }


    }
}