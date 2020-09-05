using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Earth : Block
    {
        private int quality;

        public bool GetWorkable(bool Workable)
        {
            return this.Workable == true;
        }

        public int GetQuality(int quality)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            return this.quality = randomNumber;
        }

        public void CalculateQuality()
        {
            throw new ArgumentNullException();
        }
    }
}
