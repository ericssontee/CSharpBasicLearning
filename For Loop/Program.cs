﻿namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int [] luckyNumbers = {4, 8, 15, 16, 23, 42};
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }


            //Console.ReadLine();

        }

    }
}