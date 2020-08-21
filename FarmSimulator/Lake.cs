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

            int sizeYLake = randomNumber.Next(15);

            int i = 0;

            while (i < sizeYLake)
            {
                int sizeXLake = randomNumber.Next(15);

                for (int a = 0; a < sizeXLake; a++)
                {
                    int[] positions = { positionYLake + i, positionXLake + a - (positionXLake/2) };

                    this.position.Add(positions);
                }

                int positionNumber = randomNumber.Next(positionXLake - (positionXLake/2), positionXLake + (positionXLake / 2));

                positionXLake = positionNumber;

                i++;
            }
        }

    }
}
