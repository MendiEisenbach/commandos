using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.model
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Life { get; set; } = 100;
        public bool IsAlive { get; set; } = true;

        public Enemy(string name)
        {
               Name = name;
        }
        
        public void Scream()
        {
            Console.WriteLine("I am an enemy!!!");
        }
    }
}
