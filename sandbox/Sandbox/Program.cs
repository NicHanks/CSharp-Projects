using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int playerTurn = 1; // Player 1 starts
    static void Main(string[] args)
    {
        //I want to put in a computer that guesses a number after each play the player makes
        Console.WriteLine("Hello Sandbox World!");
        int choice;
        bool validInput;

        do
        {
            Console.Clear();
            Console.WriteLine("Tic-Tac-Toe\n");
            DisplayBoard();

            validInput = int.TryParse(Console.ReadLine(), out choice);

            if (validInput && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                char symbol = (playerTurn % 2 == 0) ? 'O' : 'X';
                board[choice - 1] = symbol;
                playerTurn++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.ReadLine(); // Pause for the user to read the message
            }
        } while (!CheckForWin() && !CheckForDraw());

        Console.Clear();
        DisplayBoard();

        if (CheckForWin())
        {
            int winner = (playerTurn - 1) % 2 + 1;
            Console.WriteLine($"Player {winner} wins!");
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }

    static void DisplayBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    static bool CheckForWin()
    {
        for (int i = 0; i < 3; i++)
        {
            // Check rows
            if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
                return true;
            // Check columns
            if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                return true;
        }

        // Check diagonals
        if (board[0] == board[4] && board[4] == board[8])
            return true;
        if (board[2] == board[4] && board[4] == board[6])
            return true;

        return false;
    }

    static bool CheckForDraw()
    {
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O')
                return false;
        }
        return true;
    }
}