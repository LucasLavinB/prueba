using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Farm
    {
        private List<Terrain> position = new List<Terrain>();

        public void GenerateFarm(Terrain[,] map)
        {
            Random randomNumber = new Random();

            int direction = randomNumber.Next(2);
            int n;
            int m;
            int positionXFarm;
            int positionYFarm;

            if (direction == 0)
            {
                n = 98;
                m = 99;
            }

            else
            {
                n = 99;
                m = 98;
            }

            while (true)
            {

                positionXFarm = randomNumber.Next(n);
                positionYFarm = randomNumber.Next(m);

                int verifcator = 0;

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int startFarm = map[positionXFarm / 10, positionYFarm / 10].GetTerrain()[i,j];

                        if(startFarm == 1)
                        {
                            verifcator++;
                        }
                    }
                }

                if(verifcator == 0)
                {
                    break;
                }
            }

            for(int x = 0; x < 3; x++)
            {
                for(int z = 0; z < 2; z++)
                {
                    if(direction == 0)
                    {
                        int[] position = { (positionXFarm / 10) + x, (positionYFarm / 10) + z };
                        this.position.Add(position);
                    }
                    else
                    {
                        int[] position = { (positionXFarm / 10) + z, (positionYFarm / 10) + x };
                        this.position.Add(position);
                    }
                }
            }
            


            
        }

        public void InsertFarm(Terrain[,] map)
        {
            for (int i = 0; i < this.position.Count; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        map[this.position[i][0], this.position[i][1]].GetTerrain()[x, y] = 2;
                    }
                }
            }
        }
    }
}
