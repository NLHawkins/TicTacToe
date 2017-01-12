using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void DrawBoard(string[] board)
        {
            int counter = 0;
            foreach (string place in board)
            {
                Console.Write(" " + place);
                if (counter == 2)
                {
                    Console.WriteLine("");
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
        }

        static void Main(string[] args)
        {
            string[] board =
                {
                "0","1","2","3","4","5","6","7","8",
                };

            Console.WriteLine("Tic-Tac-Toe");
            string player = "X";
            bool keepPlaying = true;
            int turn = 1;


            while (keepPlaying)


            {
                DrawBoard(board);

                Console.WriteLine($"Make Your Move Player {player}");

                int bull;
                string moveCheck = Console.ReadLine();
                bool move
                if ()
                int move = int.Parse();
                
                Console.Clear();

                bool boardBool = int.TryParse(board[move], out bull);

                if (boardBool == true)
                {
                    board[move] = player;
                    if ((board[0] == board[1] && board[1] == board[2])
                        || (board[3] == board[4] && board[4] == board[5])
                         || (board[6] == board[7] && board[7] == board[8])
                          || (board[0] == board[3] && board[3] == board[6])
                           || (board[1] == board[4] && board[4] == board[7])
                            || (board[2] == board[5] && board[5] == board[8])
                             || (board[0] == board[4] && board[4] == board[8])
                              || (board[2] == board[4] && board[4] == board[6]))
                    {
                        keepPlaying = false;
                    }

                    else if (turn == 9)
                    {
                        break;
                    }
                    
                    
                    else
                    {
                        player = player == "X" ? "O" : "X";
                        turn++;
                    }


                }

                else
                {


                    Console.WriteLine("That Spot is taken! Choose another...");
                    keepPlaying = true;
                }
            }

            if (turn == 9)
            {
                Console.WriteLine("CAT!!!!!.....GAME OVER");
            }
            else
            {
                Console.WriteLine($"Player {player} Wins!");
            }
           
        }
    }
}





