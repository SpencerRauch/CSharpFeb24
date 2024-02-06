class Fruit : Food
{
    public bool Ripe { get;set; }

    public Fruit(string name, bool delicious, int calories, double price, bool ripe) : base(name, delicious, calories, price)
    {
        Ripe = ripe;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Ripe: {Ripe}");
    }
}