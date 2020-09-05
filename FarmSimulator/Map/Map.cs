using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Map
    {
<<<<<<< HEAD:FarmSimulator/Map.cs
        protected Terrain[,] map = new Terrain[10,10];
        private Lake lake;
        private River river;
=======
        protected Terrain[,] map = new Terrain[100,100];
        private Lake lake = null;
        private River river = null;
>>>>>>> ddfa2814e6ca3c2f6f38bf0f44ef5f6b285f2ab9:FarmSimulator/Map/Map.cs
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
