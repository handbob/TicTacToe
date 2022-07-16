using System;
public class Game {
    Int32 i, bot = 2, player = 1, move = 0;
    Int32[] matrix = new Int32[9] {
        1, 2, 3, 
        4, 5, 6,
        7, 8, 9
    };
    public Int32 Create() {
        for (i = 0; i < matrix.Length; i = i + 1) {
            if (i == matrix[2]) {
                Console.Write($"[{matrix[0]}]");
                Console.Write($"[{matrix[1]}]");
                Console.Write($"[{matrix[2]}]");
            }
        }
        Console.WriteLine();
        for (i = 0; i < matrix.Length; i = i + 1) {
            if (i == matrix[2]) {
                Console.Write($"[{matrix[3]}]");
                Console.Write($"[{matrix[4]}]");
                Console.Write($"[{matrix[5]}]");
            }
        }
        Console.WriteLine();
        for (i= 0; i < matrix.Length; i = i + 1) {
            if (i == matrix[2]) {
                Console.Write($"[{matrix[6]}]");
                Console.Write($"[{matrix[7]}]");
                Console.Write($"[{matrix[8]}]");
            }
        }
        Console.WriteLine();
        return i;
    }
    public Int32 Move() {
        bot = Random.Shared.Next(1, 9);
        player = Convert.ToInt32(Console.ReadLine());

        if (player == matrix[0]) {
            move = player;
            Console.WriteLine(matrix[move]);
        }
        return move;
    }
};
public class Program {
    public static void Main(String[] args) {
        Game game = new Game();
        game.Create();
        game.Move();
        game.Create();
    }
};
