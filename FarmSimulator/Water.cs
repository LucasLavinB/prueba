using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Water : Block
    {
        public Water(bool workable = false)
        {
            this.workable = workable;
        }
    }
}
