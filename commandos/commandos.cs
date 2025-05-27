using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.model
{
    public class Commandos
    {
        private string Name {  get; set; }
        public string CodeName { get; set; }
        public string[] Tools { get; set; } = new string[] { "hammer", "chisel", "rope", "bag", "water bottle" };
        public string Status { get; set; } = "unknown";

        public Commandos(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
        }

        public void SayName()
        {
            Console.WriteLine("enter your rank: ");
            string input = Console.ReadLine()!;

            if (input == "GENERAL")
            {
                Console.WriteLine(Name);
            }
            else if (input == "COLONEL")
            {
                Console.WriteLine(CodeName);
            }
            else
            {
                Console.WriteLine("You are not authorized to receive classified information.");
            }
        }

        public void Walk()
        {
            Console.WriteLine("The soldier is walking.");
            Status = "walking";
        }

        public void Hide()
        {
            Console.WriteLine("The soldier is hideing.");
            Status = "hideing";
        }

        public virtual void Attac()
        {
            Console.WriteLine($"Commando {CodeName} Attacks");
            Status = "Attac";

        }

    }
}
