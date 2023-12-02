using System;
using System.IO; 
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Attributes 
        int _points = 0;
        string _userInput = "";
        List<Goal> _listOfGoals = new List<Goal>();
        do 
        {
            Console.WriteLine(@"You have {_points}!
        
            Menu Options:
                Create New Goal[1]
                List Goals[2]
                Save Goals[3]
                Load Goals[4]
                Record Event[5]
                Quit[6]
            Select a choice from the menu: ");       
            _userInput = Console.ReadLine();
            if (_userInput == "1")
            {
                Console.WriteLine(@"The type of goals are:
                Simple Goal[1]
                Eternal Goal[2]
                Checklist Goal[3]
                What type of goal would you like to create? ");
                _userInput = Console.ReadLine();
                if (_userInput == "1")
                {
                    //New simp Goal
                    Console.WriteLine("What is the name of your Simple Goal? ");
                    string name = Console.ReadLine();
                    string goaltype  = "simple goal";
                    Console.WriteLine("How many pionts it worth? ");
                    int points = int.Parse(Console.ReadLine()); 
                    Goal goal = new Goal(goaltype, name, points); 
                    _listOfGoals.Add(goal);                    
                } if (_userInput == "2")
                {
                    //New Eternal Goal
                    Console.WriteLine("What is the name of your Eternal Goal? ");
                    string goal = "Eternal Goal";
                    string name = Console.ReadLine();
                    Console.WriteLine("How many pionts it worth? ");
                    int points = int.Parse(Console.ReadLine()); 
                    BigGoal biggoal = new BigGoal(goal, name, points);
                    _listOfGoals.Add(biggoal);
                } if (_userInput == "3")
                {
                    //New Checklist Goal
                    Console.WriteLine("What is the name of your Eternal Goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the main goal?");
                    string goal = $"Checklist Goal, {int.Parse(Console.ReadLine())}";
                    Console.WriteLine("What is the smaller subsections of the goal gonna be?");
                    string goal1 = $"{int.Parse(Console.ReadLine())}";
                    Console.WriteLine("How many pionts small goals worth? ");
                    int points = int.Parse(Console.ReadLine()); 
                    Console.WriteLine("How many pionts it worth? ");
                    int points1 = int.Parse(Console.ReadLine()); 
                    IncrementalGoal incrementalgoal = new IncrementalGoal(goal, name, points);
                    _listOfGoals.Add(incrementalgoal);
                }
            } if (_userInput == "2")
            {
                //List Goals
                foreach (Goal i in _listOfGoals)
                {
                    Console.WriteLine(i);
                }
            } if (_userInput == "3")
            {
                //Save Goals
                using (StreamWriter outputFile = new StreamWriter("goals.txt"))
                {
                    foreach (Goal i in _listOfGoals)
                    {
                        string stringedversion = i.GetStringRepresentation();
                        outputFile.WriteLine(stringedversion);
                    }
                }
            } if (_userInput == "4")
            {
                //Load Goals
                string[] lines = System.IO.File.ReadAllLines("StepGoals.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    string z = parts[0];
                    if (z == "simp goal")
                    {
                        Goal goal = new Goal(parts[0], parts[1], int.Parse(parts[2]));
                    } if (z == "Big goal")
                    {
                        BigGoal bgoal = new BigGoal(parts[0], parts[1], int.Parse(parts[2]));
                    } if (z == "IncrementalGoal")
                    {
                        IncrementalGoal igoal = new IncrementalGoal(parts[0], parts[1], int.Parse(parts[2]));
                    }
                }
            }
        } while (_userInput != "5");
        Console.WriteLine("Good Job! ");



        //Methods
        void CreatNew()
        {

        }
    }
}