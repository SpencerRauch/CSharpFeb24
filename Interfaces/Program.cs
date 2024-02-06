// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Hawk Redtail = new("Raymond");
Ostrich Ostrich = new("Ozzy");
Duck Daffy = new("Daffy");

Redtail.Fly();

List<Bird> AllBirds = [Redtail, Ostrich, Daffy];

foreach (Bird bird in AllBirds)
{
    if (bird is IFly f)
    {
        f.Fly();
    }
    if (bird is ISwim s)
    {
        s.Swim();
    }
    if (bird is IRun r)
    {
        r.Run();
    }
}