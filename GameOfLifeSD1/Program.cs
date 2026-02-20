namespace GameOfLifeSD1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string choice;
            Board board = new Board(10,10);
            do
            {
                Console.WriteLine("\n\n1. Display 2. Clear 3. Count neighbors 4. Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        board.DisplayBoard();
                        break;
                    case "2":
                        board.ClearBoard();
                        break;
                    case "3":
                        Console.WriteLine($"There are {board.CountNeighbors(1, 1)} neighbors");
                        break;
                    case "4":
                        Console.WriteLine("Exiting program");
                        break;

                }
            } while (choice != "3");




        }
    }
}
