using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_Games
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Games myGame = new Games();
            Gamers gamer;
            bool goGames = true;

            if (args.Length > 0) 
            {
                foreach (var item in args)
                {                    
                    gamer = new Gamers(item);
                    myGame.AddGamers(gamer);
                }
            }
            else
            {
                int iterator = 0;
                do
                {
                    Console.WriteLine($"Введите имя {++iterator}-го игрока. При вводе \"GO\", ввод игрогов закончится");
                    string name = Console.ReadLine();
                    if (name == "GO")
                    {
                        goGames = false;
                    }
                    else
                    {
                        gamer = new Gamers(name);
                        myGame.AddGamers(gamer);
                    }
                }while (goGames && iterator!=8);
            }
            myGame.distributuionTeams();
            myGame.battleTeams();
            
        }
    }
}
