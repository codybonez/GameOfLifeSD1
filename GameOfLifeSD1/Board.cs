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
        int selector;
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
        public void CountNeighbors()
        {
            selector = 0;
            // Take a selector
            // Look through top-left, top-right, top, middle-left, middle-right, bottom-left, bottom-right, bottom
            // take each and count
            // Edge case: if no pos exists, then do not count
     

            // some logic to access the board



            // if (top-left doesn't exist){
            // do not count 
            //}

            // repeat the same process for all sides


        }

    }
}
