using System;
using System.Threading;

namespace TicTacToe
{
    
    class Program
    {
        static char[] placeholders= {'1','2', '3', '4', '5', '6', '7' , '8' , '9'};
        static int player = 1;
        
        


        static void DrawBoard()
        {
            //Console.WriteLine("    |    |     ");
            Console.WriteLine("  {0} | {1}  | {2}   ",placeholders[0],placeholders[1],placeholders[2]);
            Console.WriteLine("____|____|____");
            //Console.WriteLine("    |    |    ");
            Console.WriteLine("  {0} | {1}  | {2}   ", placeholders[3], placeholders[4], placeholders[5]);
            //Console.WriteLine("    |    |    ");
            Console.WriteLine("____|____|____");
            //Console.WriteLine("    |    |    ");
            Console.WriteLine("  {0} | {1}  | {2}   ", placeholders[6], placeholders[7], placeholders[8]);
            //Console.WriteLine("||");
        }

        static int gameWin()
        {
            if ( (placeholders[0] == 'X' && placeholders[1] == 'X' && placeholders[2] == 'X') || 
                (placeholders[3] == 'X' && placeholders[4] == 'X' && placeholders[5] == 'X') ||
                (placeholders[6] == 'X' && placeholders[7] == 'X' && placeholders[8] == 'X') ||
                (placeholders[0] == 'X' && placeholders[3] == 'X' && placeholders[6] == 'X') ||
                (placeholders[1] == 'X' && placeholders[4] == 'X' && placeholders[7] == 'X') ||
                (placeholders[2] == 'X' && placeholders[5] == 'X' && placeholders[8] == 'X') ||
                (placeholders[0] == 'X' && placeholders[4] == 'X' && placeholders[8] == 'X') ||
                (placeholders[2] == 'X' && placeholders[4] == 'X' && placeholders[6] == 'X'))
            {
                return 1;
            }
            else if ((placeholders[0] == 'O' && placeholders[1] == 'O' && placeholders[2] == 'O') ||
                (placeholders[3] == 'O' && placeholders[4] == 'O' && placeholders[5] == 'O') ||
                (placeholders[6] == 'O' && placeholders[7] == 'O' && placeholders[8] == 'O') ||
                (placeholders[0] == 'O' && placeholders[3] == 'O' && placeholders[6] == 'O') ||
                (placeholders[1] == 'O' && placeholders[4] == 'O' && placeholders[7] == 'O') ||
                (placeholders[2] == 'O' && placeholders[5] == 'O' && placeholders[8] == 'O') ||
                (placeholders[0] == 'O' && placeholders[4] == 'O' && placeholders[8] == 'O') ||
                (placeholders[2] == 'O' && placeholders[4] == 'O' && placeholders[6] == 'O'))
            {
                return -1;
            }
            else if (placeholders[0] != '1' && placeholders[1] != '2' && placeholders[2] != '3'
                && placeholders[3] != '4' && placeholders[4] != '5' && placeholders[5] != '6'
                && placeholders[6] != '7' && placeholders[7] != '8' && placeholders[8] != '9')
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        static void DrawX(int input)
        {
            if (placeholders[input-1] != 'X' && placeholders[input-1] != 'O')
            {
                placeholders[input - 1] = 'X';
            }
            else
            {
                player++;
            }
            
        }
        static void DrawO(int input)
        {
            if (placeholders[input - 1] != 'X' && placeholders[input - 1] != 'O')
            {
                placeholders[input - 1] = 'O';
            }
            else
            {
                player++;
            }
                
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                DrawBoard();
                int nme;
                if( player % 2 == 0)
                {
                    nme = 2;
                }
                else
                {
                    nme = 1;
                }
                Console.WriteLine("Player {0} turn , Please choose a valid place :\n",  nme );
                string inp = Console.ReadLine();
                int choosenPLace;
                bool correctIn = int.TryParse(inp, out choosenPLace);
                if (!correctIn)
                {
                    Console.WriteLine("Not a valid Input");
                }
                else if (correctIn && choosenPLace != 0 && choosenPLace < 10)
                {


                    if (player % 2 == 0)
                    {
                        DrawX(choosenPLace);
                    }
                    else
                    {
                        DrawO(choosenPLace);
                    }
                    player++;
                }
            } while (gameWin() == 0); 
            if (gameWin() == -1)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("Player 1 has won");
            }
            if (gameWin() == 1)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("Player 2 has won");
            }
            if (gameWin() == 2)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("It was a Draw");
            }
            Console.WriteLine("Game Over, Press any key to exit");
            Console.ReadKey();
        } 
    }
}
