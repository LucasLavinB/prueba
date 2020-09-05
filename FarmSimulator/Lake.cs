using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Lake
    {
        //ATRIBUTOS
        private List<int[]> position = new List<int[]>();
        
        //CONSTRUCTOR DEL LAGO
        public Lake()
        {
            GenerateLake();
        }

        //METODOS DE ACCESO
        public List<int[]> GetPosition()
        {
            return this.position;
        }
        
        //METODO GENERADOR DE LAGO - MEJORAR, LAGOS MAL LOGRADOS
        public void GenerateLake()
        {
            Random randomNumber = new Random();

            int positionYLake = randomNumber.Next(100);
            int positionXLake = randomNumber.Next(100);

            int i = 0;

            while (i < 225)
            {
                int[] positions = { positionYLake, positionXLake };

                this.position.Add(positions);


                int positionXNumber = randomNumber.Next(positionXLake - 1, positionXLake + 2);
                int positionYNumber = randomNumber.Next(positionYLake - 1, positionYLake + 2);

                int[] verify = { positionXNumber, positionYNumber };

                if ((positionXNumber == positionXLake && positionYNumber == positionYLake) || (this.position.Contains(verify)) || (positionXNumber < 0) || (1000 < positionXNumber) || (positionYNumber < 0) || (1000 < positionYNumber))
                {
                    continue;
                }
                else
                {
                    positionXLake = positionXNumber;
                    positionYLake = positionYNumber;

                    i++;
                }
                
            }
        }

        public void InsertLake(Terrain[,] map)
        {

            for (int i = 0; i < this.position.Count; i++)
            {
                int positionXBlock = this.position[i][1] % 10;
                int positionYBlock = this.position[i][0] % 10;
                int positionXTerrain = this.position[i][1] / 10;
                int positionYTerrain = this.position[i][0] / 10;

                int[,] terrain = map[positionXTerrain, positionYTerrain].GetTerrain();

                terrain[positionXBlock, positionYBlock] = 1;
            }

        }

    }
}
