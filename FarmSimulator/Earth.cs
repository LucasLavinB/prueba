using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Earth : Block
    {
        private int quality;

        public Earth( bool workable = true)
        {
            this.workable = workable;
            this.quality = CalculateQuality();
        }

        public int GetQuality()
        {
            return this.quality;
        }

        public bool GetWorkable()
        {
            return this.workable;
        }

        private int CalculateQuality()
        {
            return 50;
        }
    }
}
