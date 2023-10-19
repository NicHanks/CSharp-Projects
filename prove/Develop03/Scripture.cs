using System;
using System.Collections.Generic;

class Scripture {
    Random random = new Random();
    Word wordClass = new Word();
    //Attributes
    private string _reference;
    private string _scriptureText;
    private string[] _editedWordslist;

    // Constructors: 
    public Scripture(string referenceInfo, string verseText) {
        _reference = referenceInfo;
        _scriptureText = verseText; 
        _editedWordslist = verseText.Split(" ");
    }

    // Methods: 
    public void HideWords() {
        int numWordsToPick = 3;
        for (int i = 0; i < numWordsToPick; i++) {
            int randomIndex = random.Next(0, _editedWordslist.Length);
            string pickedWord = _editedWordslist[randomIndex];
            string underscoredWord = wordClass.HideWord(pickedWord);
            _editedWordslist[randomIndex] = underscoredWord;
        } 
        Console.WriteLine(_editedWordslist);
    }
    public string DisplayVerse() {
        string oneString = _scriptureText + _reference;
        return oneString;
    }
    // IsCompletelyHidden()
    // UserInput()

}