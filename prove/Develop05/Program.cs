using System;
using System.IO; 
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Attributes 
        string _userInput = "";
        int _totalPoints = 0;
        List<Goal> _listOfGoals = new List<Goal>();
        Console.WriteLine($"Hello! \nCurrent Points: {_totalPoints}");
        do 
        {
            Console.WriteLine(@$"
Menu Options:
    Create New Goal[1]
    Display Goals[2]
    Save Goals[3]
    Import Goals[4]
    Check Goal Off[5]
    Display Points[6]
    Quit[7]
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
                    string goaltype  = "Simple Goal";
                    Console.WriteLine("How many pionts is it worth? ");
                    int points = int.Parse(Console.ReadLine()); 
                    Goal simpleGoal = new SimpleGoal(goaltype, name, points); 
                    _listOfGoals.Add(simpleGoal);                    
                } if (_userInput == "2")
                {
                    //New Eternal Goal
                    Console.WriteLine("What is the name of your Eternal Goal? ");
                    string goal = "Eternal Goal";
                    string name = Console.ReadLine();
                    Console.WriteLine("How many pionts is it worth? ");
                    int points = int.Parse(Console.ReadLine()); 
                    EternalGoal eternalGoal = new EternalGoal(goal, name, points);
                    _listOfGoals.Add(eternalGoal);
                } if (_userInput == "3")
                {
                    //New Checklist Goal
                    string name = "Checklist Goal";
                    Console.WriteLine("What is the name of the main Goal? ");
                    string mainGoal = Console.ReadLine();
                    Console.WriteLine("How many pionts is the main goal worth? ");
                    int bigPoints = int.Parse(Console.ReadLine()); 
                    Console.WriteLine("What are the mini goals called?");
                    string taskGoals = Console.ReadLine();
                    Console.WriteLine("How many pionts are the smaller goals worth? ");
                    int smallPoints = int.Parse(Console.ReadLine()); 
                    IncrementalGoal incrementalGoal = new IncrementalGoal(name, mainGoal, bigPoints, taskGoals, smallPoints);
                    _listOfGoals.Add(incrementalGoal);
                }
            } if (_userInput == "2")
            {
                //List Goals
                foreach (Goal i in _listOfGoals)
                {
                    Console.WriteLine(i.GetStringRepresentation());
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
                string[] lines = System.IO.File.ReadAllLines("Goals.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    string z = parts[0];
                    if (z == "Simple Goal")
                    {
                        Goal simplegoal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
                        _listOfGoals.Add(simplegoal);
                    } if (z == "Eternal Goal")
                    {
                        Goal goal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                        _listOfGoals.Add(goal);

                    } if (z == "Checklist Goal")
                    {
                        Goal goal = new IncrementalGoal(parts[0], parts[1], int.Parse(parts[2]), parts[3], int.Parse(parts[4]));
                        _listOfGoals.Add(goal); ///////////////////////// Why does declaring the type 'Goal' work here but not when creating the Goal through the terminal like in line 67?
                    }
                }
            }
            if (_userInput == "5")
            {
                //check off a goal
                int x = 1;
                foreach (Goal i in _listOfGoals)
                {
                    Console.Write($"Goal [{x}] is: ");
                    Console.WriteLine(i.GetStringRepresentation());
                    x = x + 1;
                }
                Console.WriteLine("Which goal would you like to mark off?[?] ");
                string o = Console.ReadLine();
                int q = int.Parse(o);

                int l = 1;
                foreach (Goal i in _listOfGoals)
                {
                    
                    if (q == l)
                    {
                        i.MarkAsComplete();
                    } else 
                    {
                        l = l + 1;
                    }
                }
            }
            if (_userInput == "6")
            {
                //show points
                foreach (Goal e in _listOfGoals)
                {
                    //string str = e.GetDone()
                    if (e.GetDone() == "[x]")
                    {
                        //add the points in the class to the points in the program. 
                        _totalPoints += e.GetPoints();
                    } 
                }
                Console.WriteLine($"You have {_totalPoints} points!");
            }
        } while (_userInput != "7");
        Console.WriteLine("Good Job! ");

        //Methods
    }
}