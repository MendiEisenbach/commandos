using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.model
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int NumberOfBalls { get; set; }

        public Weapon(string name, string manufacturer, int numberOfBalls)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumberOfBalls = numberOfBalls;
        }

        public void Shoot()
        {
            Console.WriteLine("shoot");
            NumberOfBalls--;
        }
    }
}
