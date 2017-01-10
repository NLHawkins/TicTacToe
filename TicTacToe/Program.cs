using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            //char[] playerArray = { '1', '2' };
            char[] markArray = { 'X', 'O' };
            //char[] playersNumber = { playerArray[0], playerArray[1] };
            char[] playersMark = { markArray[0], markArray[2] };

            Console.WriteLine("Tic-Tac-Toe");


            string[] board =
            {
                "0","1","2","3","4","5","6","7","8",
            };
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
            Console.WriteLine($"Player {playersMark} , Choose first move");


            string choice = Console.ReadLine();
            int move = Int32.Parse(choice);
            int boardValue = Int32.Parse(board[move]);
            if (move == boardValue)
            {
                board[move] = playersMark;
            }
            else
            {
                Console.WriteLine("That Spot is taken! Choose another...");
            }
            //move.Equals(Int32.Parse(board[move - 1]));


            //string[] marks = { "X", "O", string.{counter} ;

        }   }
    }