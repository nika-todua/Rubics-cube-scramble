using System;
using System.Collections.Generic;

class RubiksCube
{
    // Array of possible moves for the Rubik's cube
    static string[] moves = { "U", "U'","U2", "D", "D'", "D2", "L", "L'", "L2", "R", "R'", "R2", "F", "F'", "F2", "B", "B'", "B2" };

    static void Main(string[] args)
    {
        // Number of random moves to generate
        int scrambleMoves = 20;

        // Generate a list of scramble moves
        List<string> scrambleSequence = GenerateScramble(scrambleMoves);

        // Display the scramble sequence
        Console.WriteLine("Scramble Sequence:");
        foreach (string move in scrambleSequence)
        {
            Console.Write(move + " "); // Print each move
        }
        Console.WriteLine(); // New line after printing all moves
    }

    // Function to generate the scramble sequence
    static List<string> GenerateScramble(int numberOfMoves)
    {
        Random random = new Random(); // Random number generator
        List<string> scramble = new List<string>(); // List to store the scramble moves
        string lastMove = ""; // Variable to track the last move

        // Loop through and generate the scramble moves
        for (int i = 0; i < numberOfMoves; i++)
        {
            // Pick a random move
            string move = moves[random.Next(moves.Length)];

            // If the new move is on the same face as the last move, pick a different one
            if (i > 0 && move[0] == lastMove[0])
            {
                // Pick a new move that is different from the last one
                move = moves[random.Next(moves.Length)];
            }

            // Add the move to the list
            scramble.Add(move);

            // Update the last move
            lastMove = move;
        }

        // Return the list of moves
        return scramble;
    }
}
