using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.model
{
    public static class Game
    {
        public static void StartCreateCommandos()
        {
            Commandos d2 = CommandosFactory.CreateCommandos("AirCommando", "yuli", "nnm");
            Commandos d3 = CommandosFactory.CreateCommandos("SeaCommando", "noy", "bnn");
        }

   
    }
}
