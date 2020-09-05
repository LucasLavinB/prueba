using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    abstract class Product
    {
        protected string name;
        protected int waterConsumption;
        protected int minWater;
        protected int waterPenalty;
        protected int timeProduction;
        protected int diseaseProbability;
        protected int diseasePenalty;
    }
}
