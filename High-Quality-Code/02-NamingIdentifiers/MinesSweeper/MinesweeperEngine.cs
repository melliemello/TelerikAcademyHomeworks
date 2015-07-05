namespace NamingIdentifiers.Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MinesweeperEngine
    {
        internal static void Main(string[] arguments)
        {
            const int MAX_SCORE = 35;
            string command = string.Empty;
            char[,] playfield = GenerateField();
            char[,] bombs = SetBombsOnField();
            int currentScore = 0;
            List<Player> rating = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool showIndstructions = true;
            bool gameWon = false;
            bool gameLost = false;

            do
            {
                if (showIndstructions)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    PrintField(playfield);
                    showIndstructions = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playfield.GetLength(0) && column <= playfield.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintRating(rating);
                        break;
                    case "restart":
                        playfield = GenerateField();
                        bombs = SetBombsOnField();
                        PrintField(playfield);
                        gameLost = false;
                        showIndstructions = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                PlayNextTurn(playfield, bombs, row, column);
                                currentScore++;
                            }

                            if (MAX_SCORE == currentScore)
                            {
                                gameWon = true;
                            }
                            else
                            {
                                PrintField(playfield);
                            }
                        }
                        else
                        {
                            gameLost = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (gameLost)
                {
                    PrintField(bombs);
                    Console.Write(
                        "\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", 
                        currentScore);
                    string playerName = Console.ReadLine();
                    Player player = new Player(playerName, currentScore);
                    if (rating.Count < 5)
                    {
                        rating.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < rating.Count; i++)
                        {
                            if (rating[i].Score < player.Score)
                            {
                                rating.Insert(i, player);
                                rating.RemoveAt(rating.Count - 1);
                                break;
                            }
                        }
                    }

                    rating.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    rating.Sort((Player r1, Player r2) => r2.Score.CompareTo(r1.Score));
                    PrintRating(rating);

                    playfield = GenerateField();
                    bombs = SetBombsOnField();
                    currentScore = 0;
                    gameLost = false;
                    showIndstructions = true;
                }

                if (gameWon)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    PrintField(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string playerName = Console.ReadLine();
                    Player player = new Player(playerName, currentScore);
                    rating.Add(player);
                    PrintRating(rating);
                    playfield = GenerateField();
                    bombs = SetBombsOnField();
                    currentScore = 0;
                    gameWon = false;
                    showIndstructions = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void PrintRating(List<Player> playerRating)
        {
            Console.WriteLine("Rating:");
            if (playerRating.Count > 0)
            {
                for (int i = 0; i < playerRating.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} boxes",
                        i + 1, 
                        playerRating[i].Name, 
                        playerRating[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The rating is empty");
            }
        }

        private static void PlayNextTurn(char[,] field, char[,] bombs, int row, int column)
        {
            char bombsCount = GetNumberOfNearbyBombs(bombs, row, column);
            bombs[row, column] = bombsCount;
            field[row, column] = bombsCount;
        }

        private static void PrintField(char[,] field)
        {
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateField()
        {
            int rows = 5;
            int cols = 10;
            char[,] field = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private static char[,] SetBombsOnField()
        {
            int rows = 5;
            int columns = 10;
            char[,] field = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                Random random = new Random();
                int position = random.Next(50);
                if (!bombs.Contains(position))
                {
                    bombs.Add(position);
                }
            }

            foreach (int position in bombs)
            {
                int column = position / columns;
                int row = position % columns;
                if (row == 0 && position != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                field[column, row - 1] = '*';
            }

            return field;
        }

        private static void SetFreeBoxes(char[,] field)
        {
            int row = field.GetLength(0);
            int column = field.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char nearbyBombsCount = GetNumberOfNearbyBombs(field, i, j);
                        field[i, j] = nearbyBombsCount;
                    }
                }
            }
        }

        private static char GetNumberOfNearbyBombs(char[,] field, int row, int column)
        {
            int minesCount = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, column] == '*')
                {
                    minesCount++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, column] == '*')
                {
                    minesCount++;
                }
            }

            if (column - 1 >= 0)
            {
                if (field[row, column - 1] == '*')
                {
                    minesCount++;
                }
            }

            if (column + 1 < columns)
            {
                if (field[row, column + 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (field[row - 1, column - 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (field[row - 1, column + 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (field[row + 1, column - 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (field[row + 1, column + 1] == '*')
                {
                    minesCount++;
                }
            }

            return char.Parse(minesCount.ToString());
        }
    }
}
