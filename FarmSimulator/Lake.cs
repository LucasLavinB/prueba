using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Lake
    {
        private List<List<int>> position;
        

        public Lake()
        {
            GenerateLake();
        }
        public List<List<int>> GetPosition()
        {
            return this.position;
        }
        
        public void GenerateLake()
        {

        }

    }
}
