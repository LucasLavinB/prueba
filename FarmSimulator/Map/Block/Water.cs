using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Water : Block
    {
        public bool GetWorkable(bool Workable)
        {
            return this.Workable == false;
        }

    }
}
