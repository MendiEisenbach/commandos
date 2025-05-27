using commandos.model;

namespace commandos
{
    class Program()
    {
        static void Main(string[] args)
        {
            Weapon Weapon1 = new Weapon("M16", "refael", 20 );
            Console.WriteLine( Weapon1.NumberOfBalls );
            Weapon1.Shoot();
            Console.WriteLine(Weapon1.NumberOfBalls);

        }

    }
}