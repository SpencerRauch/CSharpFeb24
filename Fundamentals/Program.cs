// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string Name = "Spencer";
char Initial = 'S';

// Console.WriteLine($"I am {Name} my first initial is {Initial}");

if (Name == "Spencer")
{
    // Console.WriteLine("Hi spencer");
}


int[] Ages = new int[5];
int[] Scores = [100,200,3];

foreach (int SingleScore in Scores)
{
    Console.WriteLine(SingleScore);
}

for (int i = 0; i < Scores.Length; i++)
{
    Scores[i] = 1000;
}
// Console.WriteLine(Ages[3]);


List<string> Names = new List<string>();
Names.Add("Spencer");
Names.Add("Isaac");
Names.Add("Trae");
Names.Add("Shawn");

// Names.Remove("Shawn");
// Names.RemoveAt(2);
Names.ForEach(Console.WriteLine);

Dictionary<string, int> PetAges = new();

PetAges.Add("Wiley",4);
PetAges.Add("Mugzy",2);
// PetAges.Add("Wiley",5); // this will not work to update, use subscript syntax
PetAges["Wiley"] = 5;

foreach (KeyValuePair<string,int> entry in PetAges)
{
    Console.WriteLine($"key is {entry.Key} value is {entry.Value}");
}
