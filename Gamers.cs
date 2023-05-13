using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Games
{
    internal class Gamers
    {
        static private int myRandom()
        {
            Random random = new Random();
            var currentTime = DateTime.Now.Millisecond;
            int Number = currentTime;
            Number *= Number;
            int _myRandom = 1 + random.Next(Number) % 100;
            return _myRandom;
        }
        public Gamers(string _name)
        {
            name = _name;
            coin = myRandom();
            honor = 100;
            lucky = myRandom();
        }
        private string name;
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        private int coin;

        public int _coin
        {
            get { return coin; }
            set { coin = value; }
        }
        private int honor;

        public int _honor
        {
            get { return honor; }
            set { honor = value; }
        }
        private int lucky;
        public int _lucky { 
            get { return lucky; }
            set { lucky = value; }
        }

        public static bool operator <(Gamers player1, Gamers player2)
        {
            if (player1._honor == player2._honor)
                return player1._coin < player2._coin;
            else return player1._honor < player2._honor;
        }
        public static bool operator >(Gamers player1, Gamers player2)
        {
            if (player1._honor == player2._honor)
                return player1._coin > player2._coin;
            else return player1._honor > player2._honor;
        }
        public static bool operator ==(Gamers player1, Gamers player2)
        {
            if (player1._coin == player2._coin && player1._honor == player2._honor)
                return true;
            else return false;
        }
        public static bool operator !=(Gamers player1, Gamers player2)
        {
            if (player1._coin != player2._coin || player1._honor != player2._honor)
                return true;
            else return false;
        }
    }
}
