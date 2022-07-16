namespace TicTacToe.GameBoard;

using System;

public static class GameBoard {
    public static void Create() {
        Int32[] matrix = new Int32[9] {
            1, 2, 3, 
            4, 5, 6,
            7, 8, 9
        };
        for (Int32 i = 0; i < matrix.Length; i = i + 1) {
            if (i == matrix[2]) {
                Console.Write($"[{matrix[0]}]");
                Console.Write($"[{matrix[1]}]");
                Console.Write($"[{matrix[2]}]");
            }
        }
        Console.WriteLine();
        for (Int32 j = 0; j < matrix.Length; j = j + 1) {
            if (j == matrix[2]) {
                Console.Write($"[{matrix[3]}]");
                Console.Write($"[{matrix[4]}]");
                Console.Write($"[{matrix[5]}]");
            }
        }
        Console.WriteLine();
        for (Int32 k = 0; k < matrix.Length; k = k + 1) {
            if (k == matrix[2]) {
                Console.Write($"[{matrix[6]}]");
                Console.Write($"[{matrix[7]}]");
                Console.Write($"[{matrix[8]}]");
            }
        }
        Console.WriteLine();
    }
};
