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

        bool[,] board = new bool[100, 100];

        public void DisplayBoard()


        {
      
            int i = 0;
            int j = 0;
          
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
           
            int i = 0;
            int j = 0;
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
