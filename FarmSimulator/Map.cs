using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Map
    {
        protected Terrain[,] map = new Terrain[100,100];
        private Lake lake;
        private River river;
        private Farm farm;

        public Map()
        {

        }
        public Terrain[,] GetMap()
        {
            return this.map;
        }
        public void GenerateMap(bool createLake , bool createRiver = true)
        {

            if(createLake == true)
            {
                Lake lake = new Lake();
                river.InsertLake(this.map);
            }

            if(createRiver == true)
            {
                River river = new River();
                river.InsertRiver(this.map);
            }



        }

        //INSERTAR LAGO DENTRO DE LA MATRIZ DE MAPA
        private void InsertLake(Lake lake)
        {
            this.lake = lake;

            var positionLake = this.lake.GetPosition();

            for (int i = 0; i < positionLake.Count(); i++)
            {

                this.map[positionLake[i][1], positionLake[i][0]] = 1;

            }
        }

    }
}
