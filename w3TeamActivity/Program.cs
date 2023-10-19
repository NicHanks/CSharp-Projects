// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Player ronaldo = new Player("Christiano Ronaldo", 7);
ronaldo.Display();
Player jay = new Player("Big Jay", 100);
jay.Display();


Team cardinals = new Team("cardinals");
cardinals.AddPlayer(jay);
cardinals.AddPlayer(ronaldo);
cardinals.DisplayRoster();
