using System;

namespace MemoryGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
           

            Random myrandom = new Random();
            MenuOfTheGame();
            int sizeOfArray = CheckingArrayFromThePlayer();
            MemoryGameBuilding(sizeOfArray);




        }


        public static void MenuOfTheGame()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Welcom to Memory Game!\nPress any key to continue");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("You can play by chosing the number of the cards you wish to play with\nTo be continue pree any key");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
            Console.Clear();
        }

        public static int CheckingArrayFromThePlayer()
        {
            Console.WriteLine("Enter array of matrix to start: 2 | 4 | 8");
            try
            {
                int sizeOfArray = int.Parse(Console.ReadLine());
                if (sizeOfArray == 2 || sizeOfArray == 4 || sizeOfArray == 8)
                {
                    return sizeOfArray;
                }
                else
                {
                    return 4;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return 4;
            }

        }

        public static void PrintingMatrixWithNumbers(int sizeOfArray)
        {
            int[,] myMatrix = new int[sizeOfArray, sizeOfArray];


            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {

                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    Random myrandom = new Random();
                    myMatrix[i, j] = myrandom.Next(1, sizeOfArray * sizeOfArray / 2 + 1);
                    Console.Write(myMatrix[i, j] + "\t");

                }
                Console.WriteLine();

            }
            Console.WriteLine("\nPress any key");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MemoryGameBuilding(int sizeOfArray)
        {
            int score = 0;
            Random myrandom = new Random();

            int[,] myMatrix = new int[sizeOfArray, sizeOfArray];


            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {

                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    myMatrix[i, j] = myrandom.Next(1, sizeOfArray * sizeOfArray / 2 + 1);
                    Console.Write(myMatrix[i, j] + "\t");

                }
                Console.WriteLine();

            }
            Console.WriteLine("\nPress any key");
            Console.ReadLine();
            Console.Clear();

            
            for (int t = 0; t < (myMatrix.GetLength(0))*2; t++)
            {
                
                try
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Enter row number 1");
                    Console.BackgroundColor = ConsoleColor.Black;
                    int row2 = int.Parse(Console.ReadLine());
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;

                    if (row2 < sizeOfArray - 1)
                    {
                        Console.WriteLine("Enter column number 1");
                    }
                    else
                    {
                        Console.WriteLine("number not in the array...");
                        t++;
                    }

                    Console.BackgroundColor = ConsoleColor.Black;
                    int column2 = int.Parse(Console.ReadLine());
                    if (column2 <= sizeOfArray - 1)
                    {
                        if (myMatrix[row2, column2] == 0)
                        {
                            Console.WriteLine("The number in this array is empty! try again!");
                            t++;
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < myMatrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < myMatrix.GetLength(1); j++)
                                {
                                    if (i == row2 && j == column2 && myMatrix[i, j] == myMatrix[row2, column2])
                                    {
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(myMatrix[row2, column2] + "\t");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                    else
                                    {
                                        Console.Write("X" + "\t");
                                    }
                                }

                                Console.WriteLine();
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("number not in the array...");
                        t++;
                        continue;

                    }
                    try
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Enter row number 2");
                        Console.BackgroundColor = ConsoleColor.Black;
                        int row3 = int.Parse(Console.ReadLine());
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        if (row3 <= sizeOfArray - 1)
                        {
                            Console.WriteLine("Enter column number 2");
                        }
                        else
                        {
                            Console.WriteLine("number not in the array...");
                            t++;
                        }

                        Console.BackgroundColor = ConsoleColor.Black;
                        int column3 = int.Parse(Console.ReadLine());
                        if (column3 <= sizeOfArray - 1)
                        {
                            if (myMatrix[row3, column3] == 0)
                            {
                                Console.WriteLine("The number in this array is empty! try again!");
                                t++;
                                continue;
                            }
                            else
                            {
                                for (int i = 0; i < myMatrix.GetLength(0); i++)
                                {
                                    for (int j = 0; j < myMatrix.GetLength(1); j++)
                                    {
                                        if (i == row3 && j == column3 && myMatrix[i, j] == myMatrix[row3, column3])
                                        {
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write(myMatrix[row3, column3] + "\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else
                                        {
                                            Console.Write("X" + "\t");
                                        }
                                    }

                                    Console.WriteLine();
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("number not in the array...");
                            t++;
                            continue;

                        }

                        for (int i = 0; i < myMatrix.GetLength(0); i++)
                        {
                            if ((row2 == row3 && column2 == column3))
                            {

                                Console.WriteLine("You chose the same numbers....");
                                i++;
                                break;

                            }
                            else
                            {
                                if (myMatrix[row2, column2] == myMatrix[row3, column3])
                                {
                                    Console.WriteLine("very good!");
                                    score = score + 1;
                                    Console.WriteLine($"Your score is {score}");
                                    myMatrix[row2, column2] = 0;
                                    myMatrix[row3, column3] = 0;
                                    break;

                                }

                                else
                                {
                                    Console.WriteLine("wrong!");
                                    score = score - 1;
                                    Console.WriteLine($"Your score is {score}");
                                    break;
                                }
                            }

                        }
                    }
                    catch (NullReferenceException ex)
                    {

                        Console.WriteLine("can not be empty");
                        t++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("can not be string");
                        t++;
                    }


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                






            }
        }
    }



}
