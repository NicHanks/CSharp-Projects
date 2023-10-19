

class Prompts {
    int _randomInteger = 0;
    string _filename = "prompts.txt";
    string _randomPrompt;
    

    public string GetRandomPrompt() {
        Random random = new Random();
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] eachQuestion = line.Split(",");
            _randomInteger = random.Next(0,8);
            if (_randomInteger == 0) {
                _randomPrompt = eachQuestion[0]; 
            }
            else if (_randomInteger == 1) {
                _randomPrompt = eachQuestion[1];
            }
            else if (_randomInteger == 2) {
                _randomPrompt = eachQuestion[2];
            }
            else if (_randomInteger == 3) {
                _randomPrompt = eachQuestion[3];
            }
            else if (_randomInteger == 4) {
                _randomPrompt = eachQuestion[4];
            }
            else if (_randomInteger == 5) {
                _randomPrompt = eachQuestion[5];
            }
            else if (_randomInteger == 6) {
                _randomPrompt = eachQuestion[6];
            }
            else {
                _randomPrompt = eachQuestion[7];
            }
        }
        return _randomPrompt;
        
    }
}


// class Prompts {

//     //Attributes
//     private string[] _prompts = new string[];
//     private string _filename = "prompts.txt";
//     private Random _random = new Random();


//     //Constructor
//     public Prompts() {
//         string[] _prompts = System.IO.File.ReadAllLines(_filename);

//         // foreach (string line in lines)
//         // {
//         //     string[] parts = line.Split(",");

//         //     string firstName = parts[0];
//         //     string lastName = parts[1];
//         // }
//         }
//     //Methods
//     public void GetRandomPrompt()
//     {
//         int randomIndex = new Random().Next(_prompts.Count);
//         //return _prompts[randomIndex];
//         Console.WriteLine(_prompts[randomIndex]);
//     }

//     public void DisplayListOfPrompts() {
//         Console.WriteLine(_prompts);
//         // foreach (string line in _prompts) {
//         //     Console.WriteLine(line);
//         // }
//     }
//     public void AddToList() {

//     }
//     public void Edit() {

//     }

//     //     //randomIndex is getting a number from the class: _random (we created an instance of that class in line 7)
//     //     int randomIndex = _random.Next(0, _prompts.Count());
//     //     string randomPrompt = _prompts[randomIndex];
//     //     Console.WriteLine("Random Prompt: " + _prompts);
//     // }

// }