class Prompts {

    //Attributes
    private string _name;
    private List<string> _prompts;
    private string _filename = "prompts.txt";
    private Random _random = new Random();


    //Constructor
    public Prompts() {
        // Initializing the _prompts list
        _prompts = new List<string>();
        foreach (var line in _filename)
        {
            string stringLine = line.ToString();
            _prompts.Add(stringLine);
        }
    }


    //Methods
    public void DisplayListOfPrompts() {

    }
    public void AddToList() {

    }
    public void Edit() {

    }
    public void DisplayRandomPrompt() {
        //randomIndex is getting a number from the class: _random (we created an instance of that class in line 7)
        int randomIndex = _random.Next(0, _prompts.Count());
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine("Random Prompt: " + randomPrompt);
    }

}