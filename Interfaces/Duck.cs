class Duck : Bird, IFly, ISwim
{
    public int AirSpeed { get; set; } = 10;
    public int NauticalSpeed { get; set; } = 5;

    public Duck(string name):base(name){}

    public void Fly()
    {
        Console.WriteLine($"{Name} takes to the sky at {AirSpeed} mph");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} swim away at {NauticalSpeed} mph");
    }
}