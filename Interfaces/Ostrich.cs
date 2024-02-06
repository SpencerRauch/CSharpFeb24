class Ostrich : Bird, IRun
{
    public Ostrich(string name):base(name){}

    public int LandSpeed { get ; set ; } = 20;

    public void Run()
    {
        Console.WriteLine($"{Name} run off at {LandSpeed} mph");
    }
}