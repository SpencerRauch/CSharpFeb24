// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Food Kiwi = new("Kiwi",true,50,0.49);

Console.WriteLine($"{Kiwi.Name} {(Kiwi.Delicious ? "is" : "is not")} delicious");
// Kiwi.Name = "Apple"; // won't work without a setter
Kiwi.Price = 100;
Kiwi.PrintInfo();
// Console.WriteLine(Kiwi.Price);

Fruit Apple = new("Apple",true,45,0.49,true);
Apple.PrintInfo();


Apple.PrintInfo(4);

Food AppleAsFood = (Food)Apple;
AppleAsFood.PrintInfo();