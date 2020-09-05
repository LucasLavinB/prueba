using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Storage : Build
    {
        private int maxCapacity;

        public Storage(int maxCapacity)
        {
            this.maxCapacity = maxCapacity;
        }
    }
}
