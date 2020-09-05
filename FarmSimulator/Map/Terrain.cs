using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Terrain
    {
        private Block[,] terrain = new Block[10,10];
        
        public Terrain()
        {
            
        }
        public Block[,] GetTerrain()
        {
            return this.terrain;
        }

    }
}
