using System;
using System.IO; 
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int _points = 0;
        string _userInput = "";
        do 
        {
            PrintMenu();        
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
                    Console.WriteLine("What is the name of your Goal? ");
                    string name = Console.ReadLine();
                    using (StreamWriter x = new StreamWriter("Goals.txt"))
                    {
                        x.WriteLine(name);
                    }
                }


            }

        } while (_userInput != "5");


        //Methods
        void PrintMenu()
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
        }
        void CreatNew()
        {

        }
        void Save()
        {

        }
        void Load()
        {

        }
    }
}