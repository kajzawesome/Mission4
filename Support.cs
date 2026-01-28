using System;

public class Support
{
	public Support()
	{
	}

	public void printBoard(char[] board)
	{
		string strBoard = "";
        for (int i = 0; i < 9; i += 3)
		{
            // space for first cell
            strBoard += " ";
			if (board[i] == ' ')
			{
				strBoard += (i + 1).ToString();
            }
            else
            {
               strBoard += board[i];
            }

            strBoard += " | ";
            // space for second cell
            if (board[i+1] == ' ')
            {
                strBoard += (i + 2).ToString();
            }
            else
            {
                strBoard += board[i+1];
            }

            strBoard += " | ";
            // space for third cell
            if (board[i+2] == ' ')
            {
                strBoard += (i + 3).ToString();
            }
            else
            {
                strBoard += board[i+2];
            }

            if (i < 6)
			{
				strBoard += "\n---+---+---\n";
			}
        }
        Console.WriteLine(strBoard);
    }

	public bool gameOver(char[] board)
	{
        bool gameOver = false;

        // Check rows
        for (int i = 0; i < 9; i += 3)
        {
            if (board[i] != ' ' && board[i] == board[i + 1] && board[i] == board[i + 2])
            {
                Console.WriteLine("Game Over");
                Console.WriteLine($"Winner: {board[i]}");
                gameOver = true;
            }
        }
        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (board[i] != ' ' && board[i] == board[i + 3] && board[i] == board[i + 6])
            {
                Console.WriteLine("Game Over");
                Console.WriteLine($"Winner: {board[i]}"); 
                gameOver = true;
            }
        }
        // Check diagonals
        if (board[0] != ' ' && board[0] == board[4] && board[0] == board[8])
        {
            Console.WriteLine("Game Over");
            Console.WriteLine($"Winner: {board[0]}");
            gameOver = true;
        }
        if (board[2] != ' ' && board[2] == board[4] && board[2] == board[6])
        {
            Console.WriteLine("Game Over");
            Console.WriteLine($"Winner: {board[2]}");
            gameOver = true;
        }

        return gameOver;
    }
}
