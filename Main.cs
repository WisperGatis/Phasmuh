using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gamerules
{
    class Generation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EdgeField-streethousse");
            string ee = Console.ReadLine();
            int GhostRange = 10;
            int GhotSpeed = 1.5;
            Console.WriteLine("GenerateRandomGhostArea");
            int Difficulty = Convert.ToInt32(Console.ReadLine());
            int playerAmount = Convert.ToInt32(Console.ReadLine());
            var ApparitionRate = ("GhostType");

            if (PlayerAmount == 0)
            {
                Console.WriteLine("FailedMission");
                if (PlayerAmout == 1)
                {
                    Console.WriteLine("Reduce" +ApparitionRate);
                }
            }
            else
            {
                Console.WriteLine("Continue");
            }
        }

        static void GhostState(string[] args)
        {
            bool SafeplayerArea = true;
            Console.WriteLine("IsPlayerInSafeZone?"+ SafeplayerArea);
            bool SafeplayerArea = Console.ReadLine();
            bool deathEvent = false;

            if (SafeplayerArea = false)
            {
                Console.WriteLine("deathEvent"+ deathEvent = true);
                
                if (deathEvent = true)
                {
                    Console.WriteLine(Player != null);
                }
                else
                {
                    Console.WriteLine("ChaseEndBy"+ SafeplayerArea = true);
                }
            }
            else
            {
                bool PlayerState = Console.ReadLine();
                Console.WriteLine("Player Is alive"+ PlayerState = true);
            }
        }
        static void GhostStatement(string[] args)
        {
            Console.WriteLine("IsGhostAreaSafe");
            bool Crucifix = false;
            bool chasePoss = false;
            
            if (crucifix == true)
            {
                int crucifixRange = 300;
                
                if (crucifixRange => 300)
                {
                    chasePoss = true;
                }
                else
                {
                    Console.WriteLine("UselessCrucifix");
                }
            }
            else
            {
                bool chase = false;
                int ghostNumber = Convert.ToInt64(Console.ReadLine());
                var ghostType = Console.ReadLine();
                int PlayerAmount = Convert.ToInt32(Console.ReadLine());
                
                if (chase = true);
                {
                    Console.WriteLine("GhostCanChase" + ghostNumber);
                }
            }
        }

        static void deadPlayer(string[] args)
        {
            int PlayerAmount = Convert.ToInt32(Console.ReadLine());
            bool DoorsVisible = false;
            bool GhostVisible = true;
            bool PickableItems = true;
            int AmountOfDeadPlayer = PlayerAmount-1;
            
            if (AmountOfDeadPlayer <= PlayerAmount)
            {
                Console.WriteLine("GameIsOver");
            }
            else
            {
                return (main.cs);
            }
        }
        static void VisiblePoints(string[] args)
        {
            bool DoorStatut = true;
            bool GhostViewablePlayer = true;
            var PlayerSafe = ("Safe");
            var State = Console.ReadLine();

            if (State == PlayerSafe)
            {
                Console.WriteLine(+PlayerSafe);
            }
            if (DoorStatut == False)
            {
                (PlayerSafe == false);
            }
            else
            {
                PlayerSafe == true;
            }
        }

        static void MainMenu(string[] args)
        {
            Console.WriteLine("Jouer");
            bool play = Console.ReadLine();
            Console.WriteLine("Entraînement");
            bool Training = Console.ReadLine();
            console.WriteLine("Options");
            bool settings = Console.ReadLine();
            console.WriteLine("Magasin");
            bool shop = console.ReadLine();
            Console.WriteLine("Quitter");
            bool exit = Console.ReadLine();

            if (exit == true)
            {
                return(END);
            }
            else
            {
                Console.WriteLine("continue");
            }
            if (Shop == true)
            {
                //shop part
            }
            else
            {
                return(MainMenu);
            }
            if (settings == true)
            {
                Console.WriteLine("Settings menu open");
            }
            else
            {
                return(MainMenu);
            }
            if (Training == true)
            {
                Console.WriteLine("startTrainingSession");
                var TrainingDiff = 10;
                var GhostType = Revenant;
                var map = StreetHouse;
                var ItemKit = default;
            }
            else
            {
                return(MainMenu);
            }
            if (play == true)
            {
                var Lobby = ShowLobyListOnDB;
                Console.WriteLine(+Lobby);
                var ANSW = Convert.ToBoolean(Console.ReadLine());
            }
            else
            {
                return(MainMenu);
            }
        }
    }
}