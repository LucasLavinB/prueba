using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    abstract class Production : Build
    {
        protected int health = 100;
        protected int water = 100;
        protected int maturity = 0;
        protected double finalProduction;
        protected bool disease;
    }
}
