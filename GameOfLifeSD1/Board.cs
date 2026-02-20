using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            board[1,0] = true;
             board[1,1] = true;
              board[0,1] = true;
            board[1, 3] = true;
               
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
        public int CountNeighbors(int PosX, int PosY)
        {

          

            if (PosX - 1 >= 0 && PosY - 1 >= 0 && board[PosX + 1, PosY] == true)
                {
                    neighbors++;
                }
            

          
                if (PosX-1 >= 0 && PosY-1 >= 0 && board[PosX -1 , PosY] == true)
                {
                    neighbors++;
                }
            
            
                if (PosX - 1 >= 0 && PosY - 1 >= 0 && board[PosX, PosY + 1] == true)
                {
                    neighbors++;
                }

          

            if (PosX - 1 >= 0 && PosY - 1 >= 0 && board[PosX, PosY - 1] == true)
                 {       
                neighbors++;
                 }
            
         
                if (PosX - 1 >= 0 && PosY - 1 >= 0 && board[PosX + 1, PosY + 1] == true)
                {
                    neighbors++;
                }
            
            
                if (PosX - 1 >= 0 && PosY - 1 >= 0 && board[PosX - 1, PosY - 1] == true)
                {
                    neighbors++;
                }
            
          
            
                if (PosX - 1 >= 0 && PosY - 1 >= 0 && board[PosX + 1, PosY - 1] == true)
                {
                    neighbors++;
                }
            
          
            
                if (PosX - 1 >= 0 && PosY - 1 >= 0 && board[PosX - 1, PosY + 1] == true)
                {
                    neighbors++;
                }
            


           
            return neighbors;

        }


    }
}



