using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    static class PrintMap
    {
        public static void Render(Map map)
        {
            int[,] matrix = map.GetMap();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("");

                for (int j = 0; j < 100; j++)
                {

                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            if(matrix[j, i] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            if (matrix[j, i] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            if (matrix[j, i] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (matrix[j, i] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                        }
                    }

                    Console.Write(matrix[j,i]);
                }
            }
        }
    }
}
