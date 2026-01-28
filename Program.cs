Support sp = new Support();

//  Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

// Create a game board array to store the players’ choices
char[] choices = new char[9];
bool validGuess = false;
int player1 = 0;
int player2 = 0;

for (int i = 0; i < 9; i++)
{
    choices[i] = ' ';
}

do
{
    // Player one move
    sp.printBoard(choices);

    validGuess = false; //
    Console.WriteLine("Player 1, you are X. Enter your choice (1-9): ");
    do
    {
        try
        {
            player1 = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("That wasn't a valid number.");
            continue; // 
        }

        if (player1 < 1 || player1 > 9)
        {
            Console.WriteLine("Incorrect input: please enter a number (1-9)");
            continue;
        }

        // Check if spot is already taken
        if (choices[player1 - 1] != ' ')
        {
            Console.WriteLine("That spot has already been taken. Choose another.");
            continue;
        }

        validGuess = true;

    } while (validGuess == false);

    // update array with X
    choices[player1 - 1] = 'X';

    if (sp.gameOver(choices))
    {
        break;
    }

    // Player two move
    sp.printBoard(choices);

    validGuess = false; // 
    Console.WriteLine("Player 2, you are O. Enter your choice (1-9): ");
    do
    {
        try
        {
            player2 = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("That wasn't a valid number.");
            continue; 
        }

        if (player2 < 1 || player2 > 9)
        {
            Console.WriteLine("Incorrect input: please enter a number (1-9)");
            continue;
        }

        // Check if spot is already taken
        if (choices[player2 - 1] != ' ')
        {
            Console.WriteLine("That spot has already been taken. Choose another.");
            continue;
        }

        validGuess = true;

    } while (validGuess == false);

    // updated array with O
    choices[player2 - 1] = 'O';

} while (!sp.gameOver(choices));

// print final board
Console.WriteLine();
sp.printBoard(choices);
