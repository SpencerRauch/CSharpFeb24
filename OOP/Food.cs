class Food
{
    // private string _Name;
    // public string Name {get {return _Name;} set{_Name=value;}}
    public string Name { get;set; } //anonymously backed
    public bool Delicious;
    private int Calories;
    private double _Price;
    public double Price {get {return _Price;} set{if (value >= 0.01) _Price = value;}}

    public Food(string name, bool delicious, int calories, double price)
    {
        Name = name;
        Delicious = delicious;
        Calories = calories;
        Price = price;
    }

    public Food(string name, bool delicious, int calories)
    {
        Name = name;
        Delicious = delicious;
        Calories = calories;
        Price = 0.0;
    }

    public Food()
    {
        Name = "Generic Food";
        Delicious = false;
        Calories = 0;
        Price = 0.00;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine($"Delicious: {Delicious}");
        Console.WriteLine($"Calories: {Calories}");
        Console.WriteLine($"Price: ${Price}");

    }

    public virtual void PrintInfo(int times)
    {
        for (int i = 0; i < times; i++)
        {
            PrintInfo();
        }

    }

}