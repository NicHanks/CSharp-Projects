
class ReflectingActivity
{
    //Attributes
    private string _discriptionOfActvity = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private List<string> _listOfPrompts = new List<string> 
    {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};
    private List<string> _listOfQuestions = new List<string>
    {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};
    //Constructor(s)
    public ReflectingActivity()
    {

    }
    public ReflectingActivity(string activityname, string description, int duration) //: base(activityname, description, duration)
    {
        // _name = "Reflecting";
        // _description = "This activity will help you reflect on times ...";
        // _duration = 50;
    }
    //Methods
    public void DisplayMessage()
    {

    }
    public void DisplayRandomPrompt()
    {

    }
    public void DisplayRandomQuestionsAndGetAnswers()
    {

    }
    public void CreateList()
    {

    }
    public void DisplayList()
    {

    }

    // Code help says:
    // Get a random prompt
    // Get a random question about the prompt
    // Display the prompt
    // Display questions about the prompt and get answers
}