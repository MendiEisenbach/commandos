using System.Xml.Linq;
using commandos.model;

namespace commandos
{
    class Program()
    {
        static void Main(string[] args)
        {
            //Commandos[] commandosList = {

            //     new AirCommando("Noam", "Lump"),
            //     new SeaCommando("Or", "Gal"),
            //     new Commandos("Ziv", "Shampania")


            //};

            //for (int i = 0; i < commandosList.Length; i++)
            //{
            //    commandosList[i].Attac();
            //}

            //Enemy enemy1 = new Enemy("amy");

            Enemy enemy2 = EnemyFactory.CreateEnemy("abu-ally");

            //enemy1.Scream();
            //enemy2.Scream();

            Game.StartCreateCommandos();


            //foreach (var Commandos in CommandosFactory.CommandoFactoryList)
            //{
            //    Console.WriteLine(Commandos.CodeName);
            //}

            

            


        }

    }
}
