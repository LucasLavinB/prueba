using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FarmSimulator
{
    static class PrintMap
    {
        //METODO ESTATICO PARA IMPRIMIR EN CONSOLA EL MAPA
        public static void Render(Terrain[,] map)
        {

            //CODIGO PARA IMPRIMIR

            //CADA TERRRENO EQUIVALDRA A DOS PIXELES █ █

            for (int i = 0; i < 100; i++)
            {
                //SALTO DE LINEA DE LA IMPRESION
                Console.WriteLine();

                for(int j = 0; j < 100; j++)
                {

                    int counter = 0;
                    int counterFarm = 0;
                    //int counterLeft = 0;
                    //int counterRight = 0;


                    //RECORREMOS LOS BLOQUES DE LOS TERRENOS
                    //Y DETERMINAMOS SI POSEEN MAS TIERRA QUE AGUA EN LA PARTE IZQUIERDA Y DERECHA
                    for(int x = 0; x < 10; x++)
                    {
                        for(int y = 0; y < 10; y++)
                        {
                            int[,] terrain = map[i, j].GetTerrain();

                            if(terrain[x,y] == 1)
                            {
                                counter++;
                            }
                            if (terrain[x, y] == 2)
                            {
                                counterFarm++;
                            }
                            //if(x < 5)
                            //{
                            //    if(terrain[x, y] == 0)
                            //    {
                            //        counterLeft++;
                            //    }
                            //}

                            //if (x >= 5)
                            //{
                            //    if (terrain[x, y] == 0)
                            //    {
                            //        counterRight++;
                            //    }
                            //}
                        }
                    }

                    //SI POSEEN MAS TIERRA EN LA PARTE IZQUIERDA O DERECHA SE IMPRIME EL PIXEL VERDE

                    if(counter > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("██");
                    }
                    if(counterFarm > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("██");
                    }
                    if(counter == 0 && counterFarm == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("██");
                    }
                    //if(counterLeft >= 50)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Green;

                    //    Console.Write("█");
                    //}
                    //if (counterLeft < 50)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Blue;

                    //    Console.Write("█");
                    //}
                    //if (counterRight >= 50)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Green;

                    //    Console.Write("█");
                    //}
                    //if (counterRight < 50)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Blue;

                    //    Console.Write("█");
                    //}▄▀


                }
            }

           
        }

        //public static void ViewMatrix(Terrain[,] map)
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        //SALTO DE LINEA DE LA IMPRESION
        //        Console.WriteLine();

        //        for (int j = 0; j < 100; j++)
        //        {

        //            //RECORREMOS LOS BLOQUES DE LOS TERRENOS
        //            //Y DETERMINAMOS SI POSEEN MAS TIERRA QUE AGUA EN LA PARTE IZQUIERDA Y DERECHA
        //            for (int x = 0; x < 10; x++)
        //            {
        //                for (int y = 0; y < 10; y++)
        //                {
        //                    int[,] terrain = map[i, j].GetTerrain();

        //                    Console.Write(terrain[x,y]);
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
