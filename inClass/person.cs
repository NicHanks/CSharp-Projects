public class Person {
    //attributes
    public string _firstName;
    public string _lastName;
    
    
    // build construct
    public Person(string fnam, string scndnam)
    {
        _firstName = fnam;
        _lastName = scndnam;
    }    

    // This was the example:
    // Person person = new Person();
    // person._givenName = "Joseph";
    // person._familyName = "Smith";
    // person.ShowWesternName();
    // person.ShowEasternName();

    public void ShowPerson()
    {
        Console.WriteLine($"{_firstName}, {_lastName}");
    }

    public string changeName(string x)
    {
        _firstName = x;
        return _firstName;
    }
}