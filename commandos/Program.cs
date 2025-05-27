using System.Xml.Linq;
using commandos.model;

namespace commandos
{
    class Program()
    {
        static void Main(string[] args)
        {
            Weapon Weapon1 = new Weapon("M16", "refael", 20);
            Console.WriteLine(Weapon1.NumberOfBalls);
            Weapon1.Shoot();
            Console.WriteLine(Weapon1.NumberOfBalls);

            Commandos commando1 = new Commandos("ziv", "shampania", "stand");
            Console.WriteLine(commando1.Status);
            commando1.Walk();
            Console.WriteLine(commando1.Status);

            commando1.SayName();

            Console.WriteLine(commando1.CodeName);
            commando1.CodeName = "soda";
            Console.WriteLine(commando1.CodeName);


        }

    }
}