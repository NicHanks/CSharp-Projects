using System.Text.RegularExpressions;

public class GroupOfPeople
{
    public string _person1;
    public string _person2;

    public GroupOfPeople(Person x, Person y)
    {
        Person _person1 = x;
        Person _person2 = y;

    }

    public void AllPeople()
    {
        Console.WriteLine($"Here is a list of all the people in the Group!/n Person 1: {_person1}/n Person 2: {_person1}");
        
    }
}