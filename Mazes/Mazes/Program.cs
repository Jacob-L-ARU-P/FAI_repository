using System;

namespace Mazes
{
    class Program
    {
        public static int[,] maze;
        public static int [,] position;
        public static int x = 0;
        public static int y = 0;
        static void Main(string[] args)
        {
            maze = new int[,] { { 1, 1, 0, 0, 1 }, { 0, 1, 0, 0, 0 }, { 0, 1, 1, 1, 0 }, { 0, 0, 1, 0, 1 } ,{ 0, 0, 1, 0, 0 } };
            for(int i =0;i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine("");
            }

            while (x != 4 && y != 4)
            {
                //position = new int[x, y];
                //Console.WriteLine(maze[x+1, y]);
                if (x >= 0 && y >= 0 && x < 5 && y < 5)
                {
                    if (maze[x, y+1] == 1)
                    {
                        y += 1;
                        Console.WriteLine("right");
                    }
                    else if (maze[x+1, y] == 1)
                    {
                        x += 1;
                        Console.WriteLine("down");
                    }
                    else if (maze[x, y-1] == 1)
                    {
                        y -= 1;
                        Console.WriteLine("left");
                    }
                    else if (maze[x-1, y] == 1)
                    {
                        x -= 1;
                        Console.WriteLine("up");
                    }
                }
                else if (x == 0 && y == 0)
                {
                    if (maze[x, y + 1] == 1)
                    {
                        y += 1;
                        Console.WriteLine("down");
                    }
                    else if (maze[x + 1, y] == 1)
                    {
                        x += 1;
                        Console.WriteLine("right");
                    }
                }
                else { x = 0; y = 0; }
            }
            Console.WriteLine("Solved");
            Console.ReadLine();
        }
    }
}
