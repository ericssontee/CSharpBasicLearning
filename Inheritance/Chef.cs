class Chef
{
    public void MakeChicken()
    {
        Console.WriteLine("The Chef makes chicken");
    }

    public void MakeSalad()
    {
        Console.WriteLine("The Chef makes salad.");
    }

    public virtual void MakeSpecialDish() // This can be overwritten to all subclasses with virtual syntax
    {
        Console.WriteLine("The Chef makes bbq ribs");
    }
}