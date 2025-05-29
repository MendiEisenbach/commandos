using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.model
{
    internal class EnemyFactory
    {

        public static Enemy CreateEnemy(string name)
        {
            return new Enemy(name);
        }
    }
}
