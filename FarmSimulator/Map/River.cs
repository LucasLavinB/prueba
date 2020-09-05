using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class River
    {
        //ATRIBUTOS
        private List<int[]> position = new List<int[]>();
        private bool direction = true;

        //CONSTRUCTOR DE LA CLASE
        public River()
        {
            GenerateRiver(); 
            GenerateDirection();
        }

        //METODOS DE ACCESO A ATRIBUTOS
        public List<int[]> GetPosition() 
        {
            return this.position;
        }

        public bool GetDirection()
        {
            return this.direction;
        }

        //METODOS GENERADORES


        //GENERA LA DIRECCION DEL RIO (VERTICAL U HORIZONTAL)
        public void GenerateDirection()
        {
            Random rnd = new Random();

            int direction = rnd.Next(2);

            if(direction == 0)
            {
                this.direction = true;
            }
            else
            {
                this.direction = false;
            }
        }

        //GENERA UN RIO MEDIANTE NuMEROS ALEATORIOS QUE SE TIENEN QUE ENTRELAZAR
        public void GenerateRiver()
        {
            Random randomNumber = new Random();

            int previusNumber = randomNumber.Next(100);

            int i = 0;

            while (i < 100)
            {
                for (int a = 0; a < 5; a++)
                {
                    int[] positions = { i, previusNumber + a - 2 };

                    this.position.Add(positions); //ANADIENDO POSICION
                }

                int positionNumber = randomNumber.Next(previusNumber - 2, previusNumber + 3);

                if(positionNumber > 997 || positionNumber < 3)
                {
                    continue;
                }
                else
                {
                    previusNumber = positionNumber;

                    i++;
                }
            }
        }

        public void InsertRiver(Terrain[,] map)
        {

            for(int i = 0; i < this.position.Count; i++)
            {
                int positionXBlock = this.position[i][1] % 10;
                int positionYBlock = this.position[i][0] % 10;
                int positionXTerrain = this.position[i][1] / 10;
                int positionYTerrain = this.position[i][0] / 10;

                if (this.direction == true)
                {
                    int[,] terrain = map[positionXTerrain, positionYTerrain].GetTerrain();

                    terrain[positionXBlock, positionYBlock] = 1;
                }
                else
                {
                    int[,] terrain = map[positionYTerrain, positionXTerrain].GetTerrain();

                    terrain[positionYBlock, positionXBlock] = 1;
                }
            }

        }
    }
}
