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

	}
}
