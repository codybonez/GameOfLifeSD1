namespace GameOfLifeSD1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Board board = new Board(10,10);

            // Create the generations for the game
            int generations = 10;


            for (int i = 0; i < generations; i++)
            {
                board.DisplayBoard();          
                board.Rules();
                Console.WriteLine($"Current generation {i+1}");
                Thread.Sleep(1000);

            }


            // Apply rules to game



            // display

           


        }
    }
}
