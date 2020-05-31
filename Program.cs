using System;
using System.Text;

namespace SimpleGameMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int mapLenght = 10;
            int mapHeight = 10;
            TerrainEnum[,] map = new TerrainEnum[mapLenght, mapHeight];

            Console.OutputEncoding = UTF8Encoding.UTF8;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if(i == 0 || j == 0 || i == mapLenght - 1 || j == mapHeight - 1)
                    {
                        map[i, j] = TerrainEnum.wall;
                        Console.ForegroundColor = map[i, j].GetColor();
                        Console.Write($"{map[i, j].GetChar()}");
                    }
                    else
                    {
                        map[i, j] = (TerrainEnum)random.Next(1, 4);
                        Console.ForegroundColor = map[i, j].GetColor();
                        Console.Write($"{map[i, j].GetChar()}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
