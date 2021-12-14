using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2
{
    public class rocket
    {
        private string PilotName;
        private string RocketName;
        private int AVGspeed;
        private int speed;
        private bool IsEngine;
        private static bool IsStart = false;
        private static int CountEngine = 4;

        public rocket(string PilotName, string RocketName) { this.PilotName = PilotName;
            this.RocketName = RocketName;
        }

        public rocket (string Rocketname) { this.RocketName = Rocketname; }

        static rocket() { CountEngine = 6; }

        public void Start()
        {
            Console.WriteLine("Rocket Start!!!!");
        }

        public void SpeedUp(int delta)
        {
            speed += delta;
        }

        public void EndTrip()
        {
            Console.WriteLine("Your trip by rocket is end!!!!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
