using System.Xml.Linq;
using commandos.model;

namespace commandos
{
    class Program()
    {
        static void Main(string[] args)
        {
            Commandos[] commandosList = {

                 new AirCommando("Noam", "Lump"),
                 new SeaCommando("Or", "Gal"),
                 new Commandos("Ziv", "Shampania")


            };

            for (int i = 0; i < commandosList.Length; i++)
            {
                commandosList[i].Attac();
            }


        }

    }
}