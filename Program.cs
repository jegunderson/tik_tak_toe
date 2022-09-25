using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        List<string> board = new List<string> {" ", " ", " ", " ", " ", " ", " ", " ", " "};
        
        static void main(string[] args)
        {
            display_board(board);
            whos_turn(board);
        }
        static void display_board(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

        static bool whos_turn(List<string> board)
        {
            int num_blanks = 9;
            bool x_turn = true;

            foreach (string square in board)
                if (square != " ")
                {
                    num_blanks -= 1;
                }
            if (num_blanks % 2 == 1)
            {
                x_turn = true;
            }
            else
            {
                x_turn = false;
            }

            return x_turn;
        }
        
        static bool play_game(List<string> board)
        {
            display_board(board);
            whos_turn(board);
            if (whos_turn(board) == true)
            {
                Console.WriteLine("X> ");
                int position = Console.ReadLine();
                board[position - 1] = "X";
            }
            else
            {
                Console.WriteLine("O> ");
                int position = Console.ReadLine();
                board[position - 1] = "O";
            }
            return false;
        }
        display_board(board);
    }_
}
