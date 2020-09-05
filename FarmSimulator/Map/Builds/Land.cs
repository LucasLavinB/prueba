using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Land : Production
    {
        private Seed seed;
        private int nutrients = 100;
        private bool worms;
        private bool undergrowth;
    }
}
