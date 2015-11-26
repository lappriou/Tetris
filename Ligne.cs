using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Ligne : Forme
    {
        public Ligne()
        {
            blocs[0] = new Bloc { X = 4, Y = 20 };
            blocs[1] = new Bloc { X = 4, Y = 21 };
            blocs[2] = new Bloc { X = 4, Y = 22 };
            blocs[3] = new Bloc { X = 4, Y = 23 };
        }
        public override void rotation()
        {

        }
    }
}
