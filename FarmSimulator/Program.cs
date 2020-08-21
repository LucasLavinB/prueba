using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FarmSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(100);

            PrintMap.Render(map);

            Console.ReadLine();
        }
    }
}
