﻿using System;
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

            //char[] markArray = { 'X', 'O' };
            //char[] playersNumber = { playerArray[0], playerArray[1] };



            Console.WriteLine("Tic-Tac-Toe");


            while (true)

            {

                for (int x = 0; x < 17; x++)
                {
                    int gameCounter = 0;
                    if (x % 2 == 0)
                    {
                        gameCounter = 0;
                    }
                    else
                    {
                        gameCounter = 1;
                    }



                    //tell game counter to be 0 if turn is even, 1 if turn is odd



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

                    string[] playerArray = { "X", "O" };
                    string player = playerArray[gameCounter];

                    Console.WriteLine($"Make Your Move Player {player}");

                    string choice = Console.ReadLine();
                    int move = Int32.Parse(choice);
                    int boardValue = Int32.Parse(board[move]);
                    //int[] gameArray = { 0, 1 };
                    //foreach (int gameCounter in gameArray)
                    if (move == boardValue)
                    {
                        board[move] = player;


                        //here i want to draw the array, so far i have insert the foreach loop we used to originally draw by can only change one at a time
                    }
                    else
                    {
                        Console.WriteLine("That Spot is taken! Choose another...");
                    }
                }
            }

            /*  Console.WriteLine($"Make Your Move Player {player}");

              string choice = Console.ReadLine();
              int move = Int32.Parse(choice);
              int boardValue = Int32.Parse(board[move]);

              if (move == boardValue)
              {
                  board[move] = playerArray[gameCounter];


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
              else
              {
                  Console.WriteLine("That Spot is taken! Choose another...");
              }

          }
          */




            /* Console.WriteLine($"Make Your Move Player{player}");
             string[] playerArray = { "X", "O" };
             string choice = Console.ReadLine();
             int move = Int32.Parse(choice);
             int boardValue = Int32.Parse(board[move]);

             if (move == boardValue)
             {
                 board[move] = playerArray[gameCounter];
             }
             else
             {
                 Console.WriteLine("That Spot is taken! Choose another...");
             }
    gameCounter = 0;
         }

     }

     //Console.WriteLine($"Player{player} , Choose your move");



     /*string choice = Console.ReadLine();
     int move = Int32.Parse(choice);
     int boardValue = Int32.Parse(board[move]);
     if (move == boardValue)
     {
         board[move] = playerArray[gameCounter];
     }
     else
     {
         Console.WriteLine("That Spot is taken! Choose another...");
     }*/
            //move.Equals(Int32.Parse(board[move - 1]));


            //string[] marks = { "X", "O", string.{counter} ;


        }
    }
}




