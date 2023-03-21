class ItalianChef : Chef //class ItalianChef will inherit functions from class Chef
{
    // Even though there's no function written here, this class can call functions from class Chef

    public override void MakeSpecialDish() //Subclass can override a function from a parent class with override.
    {
        Console.Write("The Chef makes Chicken Parmesan");
    }

    public void MakePasta()
    {
        Console.Write("The Chef makes pasta");
    }
}