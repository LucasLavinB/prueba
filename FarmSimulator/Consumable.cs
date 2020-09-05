using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Consumable
    {
        private string name;
        private string description;

        public Consumable(string name , string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Aplication(Production production)
        {

        }
    }
}
