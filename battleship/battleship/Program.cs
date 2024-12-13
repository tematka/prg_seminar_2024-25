using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    internal class Program
    {
        static char[,] CreateMyShipsBoard()
        {
            //vytvoří tabulku, ve které budou umístěny moje lodě
            char[,] myShipsBoard = new char[10, 10] {
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
            };
            return myShipsBoard;
        }
        static char[,] CreateComputersShipsBoard()
        {
            //vytvoří tabulku, ve které budou umístěny lodě počítače
            char[,] computerShipsBoard = new char[10, 10] {
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
            };
            return computerShipsBoard;
        }
        static char[,] CreateComputersShotsBoard()
        {
            //vytvoří tabulku, kam se budou zaznamenávat moje střeli
            char[,] myShotsBoard = new char[10, 10] {
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
            };
            return myShotsBoard;
        }
        static char[,] CreateMyShotsBoard()
        {
            //vytvoří tabulku, kam se budou zaznamenávat střeli počítače
            char[,] computerShotsBoard = new char[10, 10] {
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
            };
            return computerShotsBoard;
        }
        static void WriteBoard(char[,] board)
        {
            Console.WriteLine("X  A B C D E F G H I J");
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.Write(i + 1 + " ");
                }
                else
                {
                    Console.Write(i + 1 + "  ");
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
       /* static char[,] MyShot(char[,] board, int numberOfMyShips, int numberOfComputersShips)
        {
            bool column, row;
            column = false;
            row = false;
            Console.WriteLine("")
            return board;
        }*/
        static void Main(string[] args)
        {
            int numberOfMyShips, numberOfComputersShips;
            numberOfMyShips = 17;
            numberOfComputersShips = 17;

            char[,] myShipsBoard = CreateMyShipsBoard();
            char[,] computersShipsBoard = CreateComputersShipsBoard();
            char[,] myShotsBoard = CreateMyShotsBoard();
            char[,] computersShotsBoard = CreateComputersShotsBoard();
            WriteBoard(myShipsBoard);

            Console.ReadKey();
        }
    }
}
