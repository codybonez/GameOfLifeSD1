using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeSD1
{
    public class Board
    {
        // Create 2d array of bools

        public Board(int _row, int _col)
        {
     
         board = new bool[_row, _col];
           row = _row;
            col = _col;
        }

        public int row;
        public int col;
        bool[,] board;
        int neighbors;
        public void DisplayBoard()
        {
          
          
            for (int i = 0; i < row; i++)
            {
      
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"[{board[i, j]}]");
            
                }
            }
            
      
        }
       public void ClearBoard()
        {


            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < col; j++)
                {
                    Console.Write($"[]");

                }
            }

        }
        public int CountNeighbors()
        {





            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {

                    if (i == row && j == col)
                    {
                        continue;
                    }
                    if (i >= 0 && i < row && j >= 0 && j < col)
                    {
                        neighbors++;
                    }




                }
            }
            return neighbors;

        }


    }
}
