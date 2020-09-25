using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Game
    {
        private int turn;
        private DateTime creationDate;
        private DateTime saveDate;
        private int money;
        private Map map;
        private Market market;

        public Game(DateTime creationDate, DateTime saveDate, int money, Map map, Market market , int turn = 0)
        {
            this.turn = turn;
            this.creationDate = creationDate;
            this.saveDate = saveDate;
            this.money = money;
            this.map = map;
            this.market = market;
        }

        public bool SaveGame()
        {
            return true;
        }

        public bool LoadGame()
        {
            return true;
        }

        public bool DeleteGame()
        {
            return true;
        }

        public void NewGame()
        {
            turn = 1;
            money = 50000;
            Console.WriteLine("Fecha de creacion: " + creationDate);
            Console.WriteLine("Dinero disponible: " + money);
                        
        }
    }
}
