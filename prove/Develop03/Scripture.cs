using System;
using System.Collections.Generic;

class Scripture {
    Random random = new Random();
    Word wordClass = new Word();
    //Attributes
    private string _reference;
    private string _scriptureText;
    private string[] _editedWordslist = new string[0];

    // Constructors: 
    public Scripture(string referenceInfo, string verseText) {
        _reference = referenceInfo;
        _scriptureText = verseText; 
        string[] strings = verseText.Split(" ");
        _editedWordslist = strings;
        //Console.WriteLine(_editedWordslist);
    }

    // Methods: 
    public void HideWords() {
        int numWordsToPick = 1;
        for (int i = 0; i < numWordsToPick; i++) {
            int randomIndex = random.Next(0, _editedWordslist.Length);
            string pickedWord = _editedWordslist[randomIndex];
            string underscoredWord = wordClass.HideWord(pickedWord);
            _editedWordslist[randomIndex] = underscoredWord;
        } 
    }
    public void DisplayVerse() {
        string oneString = _reference + _scriptureText;
        Console.WriteLine(oneString);
    }
    public void DisplayModifiedVerse() {
        //string strings = _reference + _editedWordslist;
        Console.Write(_reference);
        foreach (string sting in _editedWordslist) {
            Console.Write(sting + " ");
        }
        Console.WriteLine();
    }
    // IsCompletelyHidden()
    // UserInput()

}