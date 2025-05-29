using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.model
{
    public class CommandosFactory
    {

        public static List<Commandos> CommandoFactoryList { get; set; } = new List<Commandos>();

        public static void AddToList(Commandos soldier)
        {
            CommandoFactoryList.Add(soldier);
        }

        public static Commandos CreateCommandos(string type, string name, string codeName)
        {
            Commandos NewComando;

            switch (type)
            {
                case "AirCommando":
                    NewComando = new AirCommando(name, codeName);
                    break;

                case "SeaCommando":
                    NewComando = new SeaCommando(name, codeName);
                    break;

                default:
                    throw new ArgumentException("Invalid commando type");
            }

            AddToList(NewComando);
            return NewComando;
        }
    }
}
