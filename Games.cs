using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Games
{
    internal class Games
    {
        private static List<Gamers> comGamers;
        Gamers team1, team2;
        public Games() { 
            comGamers = new List<Gamers>();
            team1 = new Gamers(String.Empty);
            team2 = new Gamers(String.Empty);
        }
        public void AddGamers(Gamers gamers)
        {
            if (comGamers.Count < 8)
                comGamers.Add(gamers);
            else Console.WriteLine("В игре уже участвует 8 игроков");
        }
        public void distributuionTeams() { 
            int coinComand1 = 0,coinComand2=0, honorComand1 = 0,honorComand2=0, luckyComand1 = 1,luckyComand2 = 1;
            string nameComand1 = "",nameComand2 = "";
            for (int i = 0; i < comGamers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    coinComand1 += comGamers[i]._coin;
                    honorComand1 += comGamers[i]._honor;
                    luckyComand1 *= comGamers[i]._lucky;
                    nameComand1 += comGamers[i]._name[0];
                }
                else {
                    coinComand2 += comGamers[i]._coin;
                    honorComand2 += comGamers[i]._honor;
                    luckyComand2 *= comGamers[i]._lucky;
                    nameComand2 += comGamers[i]._name[0];
                }
            }
            team1 = new Gamers(nameComand1);
            team1._honor = honorComand1;
            team1._coin = coinComand1;
            team1._lucky = luckyComand1;
            team2 = new Gamers(nameComand2);
            team2._honor = honorComand2;
            team2._coin = coinComand2;
            team2._lucky = luckyComand2;
        }
        public void battleTeams() {
            
            if (team1 > team2)
            {
                Console.WriteLine($"Команда1 {team1._name} победила!");
            }
            else
                if (team1 < team2) {
                Console.WriteLine($"Команда2 {team2._name} победила!");
            }
            else if (team1 == team2)
            {
                if (team1._lucky > team2._lucky)
                    Console.WriteLine($"Команда1 {team1._name} победила!");
                else if (team2._lucky > team1._lucky)
                    Console.WriteLine($"Команда2 {team2._name} победила!");
            }
            else Console.WriteLine("Ничья!");
            Console.ReadKey();
        }
    }
}
