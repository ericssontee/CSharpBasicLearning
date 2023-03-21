class Program
{
    static void Main(string[] args)
    {
        // No need to use a line like
        // Math myMath = new Math();
        // UsefulTools tools = new UsefulTools();
        Console.WriteLine(Math.Sqrt(144)); // Static method is a method belongs to a class. No need to create a new instance to use it.
        UsefulTools.SayHi("Eric");
    }

}

