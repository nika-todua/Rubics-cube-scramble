using System;
using System.Collections.Generic;

class RubiksCube
{
    static string[] moves = { "U", "U'", "D", "D'", "L", "L'", "R", "R'", "F", "F'", "B", "B'" };

    static void Main(string[] args)
    {
        int scrambleMoves = 20; // Number of random moves to scramble the cube
        List<string> scrambleSequence = GenerateScramble(scrambleMoves);

        Console.WriteLine("Scramble Sequence:");
        foreach (var move in scrambleSequence)
        {
            Console.Write(move + " ");
        }
    }

    static List<string> GenerateScramble(int moveCount)
    {
        Random random = new Random();
        List<string> scramble = new List<string>();

        for (int i = 0; i < moveCount; i++)
        {
            int moveIndex = random.Next(moves.Length);
            scramble.Add(moves[moveIndex]);
        }

        return scramble;
    }
}
