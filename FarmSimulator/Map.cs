using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Map
    {
        protected Terrain[,] map = new Terrain[10,10];
        private Lake lake;
        private River river;
        private Farm farm;

        public Map()
        {
            GenerateTerrain();
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
                this.lake = lake;

                this.lake.InsertLake(this.map);
            }

            if(createRiver == true)
            {
                River river = new River();
                this.river = river;

                this.river.InsertRiver(this.map);
            }

            Farm farm = new Farm();
            farm.GenerateFarm(this.map);

            this.farm = farm;

            this.farm.InsertFarm(this.map);

        }

        private void GenerateTerrain()
        {

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    this.map[i, j] = new Terrain();
                }
            }
        }

    }
}
