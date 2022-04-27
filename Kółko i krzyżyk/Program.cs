using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kółko_i_krzyżyk
{
    internal class Program

    {
        static bool winner = false;
        static bool error = false;
        static void DrawBoard (string [] board)
        {
            Console.WriteLine("**************");
            Console.Write("  " + board[0]);
            Console.Write(" | " + board[1]);
            Console.Write(" | " + board[2]);
            Console.WriteLine();
            Console.WriteLine("  ---------");
            Console.Write("  " + board[3]);
            Console.Write(" | " + board[4]);
            Console.Write(" | " + board[5]);
            Console.WriteLine();
            Console.WriteLine("  ---------");
            Console.Write("  " + board[6]);
            Console.Write(" | " + board[7]);
            Console.Write(" | " + board[8]);
            Console.WriteLine();
            Console.WriteLine("**************");
        }
        static void UserMove(string userMove, string[] board) 
        {
            Console.Write("Wybierz swój symbol: x lub o   ");
            string xOrO = Console.ReadLine();
            int userMoveInt = Convert.ToInt32(userMove);
            if (xOrO == "x")
            {
                board[userMoveInt] = "x";
            }
            else if (xOrO == "o")
            {
                board[userMoveInt] = "o";
            }
            else if ( xOrO != "x" || xOrO != "o" )
            {
                error = true;
                Console.WriteLine("Wprowadzono nieprawidłowy znak");
            }
        }
        static void Winner (string [] board)
        {
            if ( board[0] == "x" && board[3] == "x" && board[6] == "x" || 
                 board[1] == "x" && board[4] == "x" && board[7] == "x" ||
                 board[2] == "x" && board[5] == "x" && board[8] == "x" ||
                 board[0] == "x" && board[1] == "x" && board[2] == "x" ||
                 board[3] == "x" && board[4] == "x" && board[5] == "x" ||
                 board[6] == "x" && board[7] == "x" && board[8] == "x" ||
                 board[0] == "x" && board[4] == "x" && board[8] == "x" ||
                 board[2] == "x" && board[4] == "x" && board[6] == "x")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("'x' YOU ARE THE WINNER!");
                Console.ResetColor();
                winner = true;
            }
            else if (board[0] == "o" && board[3] == "o" && board[6] == "o" || 
                     board[1] == "o" && board[4] == "o" && board[7] == "o" ||
                     board[2] == "o" && board[5] == "o" && board[8] == "o" ||
                     board[0] == "o" && board[1] == "o" && board[2] == "o" ||
                     board[3] == "o" && board[4] == "o" && board[5] == "o" ||
                     board[6] == "o" && board[7] == "o" && board[8] == "o" ||
                     board[0] == "o" && board[4] == "o" && board[8] == "o" ||
                     board[2] == "o" && board[4] == "o" && board[6] == "o")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("'o' YOU ARE THE WINNER!");
                Console.ResetColor();
                winner = true;
            }
        }
        static void Main(string[] args)
        {
            string[] boardFields = new string[9] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            Console.WriteLine("Witaj w grze kółko i krzyżyk.");
            Console.WriteLine("Podaj swój ruch");
            DrawBoard(boardFields);
            do
            {
                do
                {
                    Console.Write("Twój ruch:");
                    string userMove = Console.ReadLine();
                    UserMove(userMove, boardFields);
                    DrawBoard(boardFields);
                    Winner(boardFields);
                } while (error == false);
            } while (winner == false);



            Console.ReadKey();
        }
    }
}
