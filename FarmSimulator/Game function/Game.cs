using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
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

        public bool SaveGame()
        {
            throw new ArgumentNullException();
        }

        public void LoadGame()
        {

        }

        public void DeleteGame()
        {

        }
        
        public void NewGame()
        {

        }
    }
}
