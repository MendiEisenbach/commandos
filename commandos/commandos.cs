using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.model
{
    public class commandos
    {
        public string Name {  get; set; }
        public string Password { get; set; }
        public string[] Tools { get; set; } = new string[] { "hammer", "chisel", "rope", "bag", "water bottle" };
        public string Status { get; set; }

        public commandos(string name, string password, string[] tools, string status)
        {
            Name = name;
            Password = password;
            Tools = tools;
            Status = status;
        }

        public void Walk()
        {

        }

        public void Hide()
        {

        }

        public void Attac()
        {

        }
    }
}
