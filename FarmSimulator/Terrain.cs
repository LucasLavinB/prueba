using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Terrain
    {
        protected int[,] terrain = new int[10,10];

        public int[,] GetTerrain()
        {
            return this.terrain;
        }
    }
}
