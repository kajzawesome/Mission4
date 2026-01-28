Support sp = new Support();


//  Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

// Create a game board array to store the players’ choices
char[] choices = new char[9];
for (int i = 0; i<9; i++)
{
    choices[i] = ' ';
}


do
{
    // Player one move
    sp.printBoard(choices);

    Console.WriteLine("Player 1, you are X. Enter your choice (1-9): ");
    int player1 = int.Parse(Console.ReadLine());


    // update array with X
    player1 = player1 - 1;
    choices[player1] = 'X';

    if (sp.gameOver(choices)) 
    {
        break;
    }

    // Player two move
    sp.printBoard(choices);

    Console.WriteLine("Player 2, you are O. Enter your choice (1-9): ");
    int player2 = int.Parse(Console.ReadLine());

    // updated array with 0
    player2 = player2 - 1;
    choices[player2] = 'O';

} while (!sp.gameOver(choices));


// print final board
Console.WriteLine();
sp.printBoard(choices);



// Print the board by calling the method in the supporting class

// Check for a winner by calling the method in the supporting class, and notify the players
// when a win has occurred and which player won the game