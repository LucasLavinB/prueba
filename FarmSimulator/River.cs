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

                    this.position.Add(positions);
                }

                int positionNumber = randomNumber.Next(previusNumber - 2, previusNumber + 3);

                previusNumber = positionNumber;

                i++;
            }
        }
    }
}
