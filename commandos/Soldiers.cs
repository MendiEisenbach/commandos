using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace commandos.model
{
    public class AirCommando : Commandos
    {
        public AirCommando(string name, string codeName) : base(name, codeName)
        {

        }

        public void FlightCapability()
        {
            Console.WriteLine("Flight capability");
        }

        public override void Attac()
        {
            Console.WriteLine($"AirCommando {CodeName} Attacks");
            Status = "Attac";
        }
    }

    public class SeaCommando : Commandos
    {
        public SeaCommando(string name, string codeName) : base(name, codeName)
        {

        }

        public void SwimmingCapability()
        {
            Console.WriteLine("Swimming capability");
        }

        public override void Attac()
        {
            Console.WriteLine($"SeaCommando {CodeName} Attacks");
            Status = "Attac";
        }
    }
}
