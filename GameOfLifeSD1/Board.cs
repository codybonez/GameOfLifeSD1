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

        public Board(int row, int col)
        {
        
         
           this.row = row;
            this.col = col;
            board = new bool[row, col];
            GenerateField();
            
        }
    
        public int row;
        public int col;
        bool[,] board;
     
        public void DisplayBoard()
        {
          
          
            for (int i = 0; i < row; i++)
            {
        
                for (int j = 0; j < col; j++)
                {
                    //Console.Write($"[{board[i, j]}]");
                    Console.Write(board[i, j] ? "[x]" : "[ ]");
                    if (j == col - 1) Console.WriteLine("\r");

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
            int neighbors = 0;
            //if (!((PosX < 0 || PosY < 0) || (PosY >= col || PosX >= row)))
            //{
            //    if (!((PosX == row) && (PosY == col)))
            //    {
            //        if (board[PosX, PosY] == true) neighbors++;
            //    }
            //}



            if (PosX - 1 >= 0 && PosY - 1 >= 0 && PosX + 1 < row && PosY + 1 < col && board[PosX + 1, PosY] == true)
            {
                neighbors++;
            }



            if (PosX - 1 >= 0 && PosY - 1 >= 0 && PosX + 1 < row && PosY + 1 < col && board[PosX - 1, PosY] == true)
            {
                neighbors++;
            }


            if (PosX - 1 >= 0 && PosY - 1 >= 0 && PosX + 1 < row && PosY + 1 < col && board[PosX, PosY + 1] == true)
            {
                neighbors++;
            }



            if (PosX - 1 >= 0 && PosY - 1 >= 0 && PosX + 1 < row && PosY + 1 < col && board[PosX, PosY - 1] == true)
            {
                neighbors++;
            }


            if (PosX - 1 >= 0 && PosY - 1 >= 0 && PosX + 1 < row && PosY + 1 < col && board[PosX + 1, PosY + 1] == true)
            {
                neighbors++;
            }


            if (PosX - 1 >= 0 && PosY - 1 >= 0 && PosX + 1 < row && PosY + 1 < col && board[PosX - 1, PosY - 1] == true)
            {
                neighbors++;
            }



            if (PosX - 1 >= 0 && PosY - 1 >= 0 && PosX + 1 < row && PosY + 1 < col && board[PosX + 1, PosY - 1] == true)
            {
                neighbors++;
            }



            if (PosX - 1 >= 0 && PosY - 1 >= 0 && PosX + 1 < row && PosY + 1 < col && board[PosX - 1, PosY + 1] == true)
            {
                neighbors++;
            }




            return neighbors;

        }
        public void Rules()
        {
            bool[,] nextgen = new bool[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int aliveneighbors = CountNeighbors(i, j);

                    if (board[i, j])
                    {
                        //nextgen[i,j] = aliveneighbors == 2 || aliveneighbors == 3;
                        if (aliveneighbors < 2)
                        {
                            board[i, j] = false;

                        }
                        if (aliveneighbors > 3)
                        {
                            board[i, j] = false;
                        }

                    }
                    else
                    {
                        //nextgen[i, j] = aliveneighbors == 3;
                        if (aliveneighbors == 3 || aliveneighbors == 2)
                        {
                            board[i, j] = true;
                        }

                    }
                 
                }
            }
            nextgen = board;
        }
        private void GenerateField()
        {
            Random generator = new Random();
            int number;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    number = generator.Next(2);
                    board[i, j] = ((number == 0) ? false : true);
                }
            }
        }
    }


}




