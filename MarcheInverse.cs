using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class MarcheInverse: Forme
    {
        public MarcheInverse()
        {
            blocs[0] = new Bloc { X = 6, Y = 20 };
            blocs[1] = new Bloc { X = 5, Y = 20 };
            blocs[2] = new Bloc { X = 5, Y = 21 };
            blocs[3] = new Bloc { X = 4, Y = 21 };
        }

        public override void rotation()
        {

        }
    }
}
