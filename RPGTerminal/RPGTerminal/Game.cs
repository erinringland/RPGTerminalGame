using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTerminal
{
    class Game
    {
        static RPGEntities db = new RPGEntities();
        
        public void GetHeroName()
        {
            string userName = "";

            Player newPlayer = new Player();

            while (userName == "")
            {
                Console.Write("What's your name?");
                userName = Console.ReadLine();
            }

            newPlayer.Name = userName;
            newPlayer.isCurrent = true;
            newPlayer.HealthPoints = 10;
            newPlayer.HitPoints = 10;

            db.Players.Add(newPlayer);
            db.SaveChanges();

            Console.Clear();
        }
        public void Start()
        {
            //Console.WriteLine("Hello"); // Uncomment closer to the end of the project

            //GetHeroName(); // Uncomment closer to the end of the project

            Player currPlayer = db.Players.FirstOrDefault(p => p.isCurrent == true);

            Console.WriteLine("Hello " + currPlayer.Name);

        }
    }
}
