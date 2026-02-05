namespace GameOfLifeSD1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string choice;
            Board board = new Board();
            do
            {
                Console.WriteLine("\n\n1. Display 2. Clear");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        board.DisplayBoard();
                        break;
                    case "2":
                        board.ClearBoard();
                        break;
                }
            } while (choice != "1" || choice != "2");




        }
    }
}
