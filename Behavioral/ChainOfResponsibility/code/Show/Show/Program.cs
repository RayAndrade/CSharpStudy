// See https://aka.ms/new-console-template for more information

var mouse = new Show.MouseHandler();
var cat = new Show.CatHandler();
var dog = new Show.DogHandler();

mouse.SetNext(cat).SetNext(dog);

Console.WriteLine("Chain: Dog > Cat > Mouse\n");
Show.Client.ClientCode(mouse);
Console.WriteLine();

Console.WriteLine("Subchain: Dog > Cat\n");
Show.Client.ClientCode(cat);