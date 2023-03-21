using System;

namespace IfStamentContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(2, 11));
            Console.WriteLine(GetMax(20, 14));
            Console.WriteLine(GetMax2(20, 14, 30));
            Console.WriteLine(GetMax2(20, 14, 11));

            Console.ReadLine();
        }

        static int GetMax( int num1, int num2)
        {
            int result;
            // You can use comparison operators
            if(num1 > num2){
                result = num1;
            }
            else {
                result = num2;
            }


            return result;
        }

        // Compare 3 parameters
        static int GetMax2( int num1, int num2, int num3)
        {
            int result;

            if(num1 >= num2 && num1 >= num3){
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else {
                result = num3;
            }


            return result;
        }


    }
}