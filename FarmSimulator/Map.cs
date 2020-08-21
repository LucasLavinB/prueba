using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Map
    {
        protected int[,] map;
        private Lake lake;
        private River river;
        private Farm farm;

        public Map(int sizeMap)
        {
            int[,] map = new int[sizeMap, sizeMap];

            this.map = map;
            GenerateMap(false, true);

        }
        public int[,] GetMap()
        {
            return this.map;
        }
        public void GenerateMap(bool createLake , bool createRiver = true)
        {

            if(createLake == true)
            {
                Lake lake = new Lake();
            }

            if(createRiver == true)
            {
                River river = new River();
                InsertRiver(river);
            }



        }

        private void InsertRiver(River river)
        {
            this.river = river;

            var positionRiver = this.river.GetPosition();
            var directionRiver = this.river.GetDirection();

            for(int i = 0; i < positionRiver.Count(); i++)
            {
                if(directionRiver == true)
                {
                    this.map[positionRiver[i][0], positionRiver[i][1]] = 1;
                }
                else
                {
                    this.map[positionRiver[i][1], positionRiver[i][0]] = 1;
                }
            }
        }

    }
}
