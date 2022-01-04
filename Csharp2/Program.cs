using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2
{
     public partial class rocket
     {
        //1.2 Реализовать не менее пяти закрытых полей (различных типов), представляющих 
        //основные характеристики рассматриваемого класса.
        private string PilotName { get; set; }
        private string RocketName { get; set; }
        private int AVGspeed { get; set; }
        private int MAXspeed { get; set; }
        private int BuildYear { get; set; }

        //Создать не менее двух статических полей (различных типов), представляющих 
        //общие характеристики объектов данного класса.
        private static bool IsStart = false;
        private static int CountEngine = 4;

        
        //Обязательным требованием является реализация нескольких перегруженных 
        //конструкторов, аргументы которых определяются студентом, исходя из
        //специфики реализуемого класса, а так же реализация конструктора по
        //умолчанию.
        public rocket(string PilotName, string RocketName) { this.PilotName = PilotName;
            this.RocketName = RocketName;
        }

        public rocket (string Rocketname) { this.RocketName = Rocketname; }


        //Создать статический конструктор.
        static rocket() { CountEngine = 6; }




        //Создать не менее трех методов управления классом и методы доступа к его 
        //закрытым полям.
        static public void Start()
        {
            Console.WriteLine("Rocket Start!!!!");
        }

        public void SpeedUp(int delta)
        {
            MAXspeed += delta;
        }

        static public void EndTrip()
        {
            Console.WriteLine("Your trip by rocket is end!!!!");
        }
     }


    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
