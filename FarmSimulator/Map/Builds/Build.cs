using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    abstract class Build
    {
        protected string name;
        protected int buyPrice;
        protected int sellPrice;
        protected Terrain terrain;
    }
}
