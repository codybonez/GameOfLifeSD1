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

        public Board()
        {
         board = new bool[i,j];
        }

        public int i = 100;
        public int j = 100;
        bool[,] board;
 
        public void DisplayBoard()
        {
            board = new bool[i, j];
          
            for (i = 0; i < 100; i++)
            {
      
                for (j = 0; j < 100; j++)
                {
                    Console.Write($"[{board[j, i]}]");
            
                }
            }
            
      
        }
       public void ClearBoard()
        {
           

            for (i = 0; i < 100; i++)
            {
           
                for (j = 0; j < 100; j++)
                {
                    Console.Write($"[]"); 
               

                }
            }

        }
       

    }
}
