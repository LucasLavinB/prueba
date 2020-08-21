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

            for( int i = 0; i < map.Length; i++)
            {
                //SALTO DE LINEA DE LA IMPRESION
                Console.WriteLine();

                for(int j = 0; j < map.Length; j++)
                {
                    int counterLeft = 0;
                    int counterRight = 0;


                    //RECORREMOS LOS BLOQUES DE LOS TERRENOS
                    //Y DETERMINAMOS SI POSEEN MAS TIERRA QUE AGUA EN LA PARTE IZQUIERDA Y DERECHA
                    for(int x = 0; x < 10; x++)
                    {
                        for(int y = 0; y < 10; y++)
                        {
                            int[,] terrain = map[i, j].GetTerrain();

                            if(x < 3)
                            {
                                if(terrain[x, y] == 0)
                                {
                                    counterLeft++;
                                }
                            }

                            if (x > 3)
                            {
                                if (terrain[x, y] == 0)
                                {
                                    counterRight++;
                                }
                            }
                        }
                    }

                    //SI POSEEN MAS TIERRA EN LA PARTE DERECHA SE IMPRIME EL PIXEL VERDE

                    if(counterLeft >= 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("█");
                    }
                    if (counterLeft < 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.Write("█");
                    }
                    if (counterRight >= 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("█");
                    }
                    if (counterRight < 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("█");
                    }


                }
            }

           
        }
    }
}
