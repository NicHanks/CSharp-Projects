class Word {
    //Attributes
    private string _word;

    //Constructor
    public Word(){

    }

    //Methods
    public string HideWord(string x) {
        string newWord = "";
        foreach (char letter in x)
            {
                newWord += "_";
            }
        return newWord;
    }
}