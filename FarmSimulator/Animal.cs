using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Animal : Product
    {
        private int foodConsumption;
        private int minFood;
        private int foodPenalty;
        private int escapeProbability;
        private int[] escapeRange;
        private int deadProbability;
        private int[] deadRange;
        private int units;

        public Animal()
        {

        }
    }
}
