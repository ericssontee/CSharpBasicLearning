//try catch block can be use for exception

/*
try
{
    Console.Write("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine()); //5
    Console.Write("Enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine()); //0

    Console.WriteLine(num1 / num2); // Unhandled exception. 

}
catch(Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}
*/

try
{
    Console.Write("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine()); //5
    Console.Write("Enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine()); //0

    Console.WriteLine(num1 / num2); // Unhandled exception. 

}
catch(DivideByZeroException e) // Will only except errors by divide by zero
{
    Console.WriteLine("Error: " + e.Message);
}
catch(FormatException e) 
{
    Console.WriteLine( e.Message);
}

Console.ReadLine();