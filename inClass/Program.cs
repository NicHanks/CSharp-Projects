// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Laptop win97 = new Laptop(17.2, "Windows 97 v2", true, "i9"); //"new Laptop" new construct

win97.ShowDetails();

Person Joe = new Person("Joe", "Momma");

Joe.ShowPerson();

Joe.changeName("Your");

Console.WriteLine($"Sincerly, {Joe._firstName}, {Joe._lastName}");

Person Sally = new Person("Sally", "X");

GroupOfPeople group1 = new GroupOfPeople(Joe, Sally);

GroupOfPeople.AllPeople();
