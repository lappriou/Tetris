using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class LInverse : Forme
    {
        public LInverse()
        {
            blocs[0] = new Bloc { X = 5, Y = 20 };
            blocs[1] = new Bloc { X = 5, Y = 21 };
            blocs[2] = new Bloc { X = 5, Y = 22 };
            blocs[3] = new Bloc { X = 4, Y = 20 };
        }
        public override void rotation()
        {
            if (blocs[2].Y - blocs[0].Y == 2)
            {
                blocs[0].X += 1;
                blocs[0].Y += 1;
                blocs[2].X -= 1;
                blocs[2].Y -= 1;
                blocs[3].X += 2;
                
            }

            if (blocs[0].X  - blocs[2].X == 2 )
            {
                blocs[0].X -= 1;
                blocs[0].Y += 1;
                blocs[2].X += 1;
                blocs[2].Y -= 1;
                blocs[3].Y += 2;
            }

            if (blocs[0].Y - blocs[2].Y == 2)
            {
                blocs[0].X -= 1;
                blocs[0].Y -= 1;
                blocs[2].X += 1;
                blocs[2].Y += 1;
                blocs[3].X -= 2;

            }

            if (blocs[2].X - blocs[0].X == 2)
            {
                blocs[0].X += 1;
                blocs[0].Y += 1;
                blocs[2].X -= 1;
                blocs[2].Y += 1;
                blocs[3].X -= 2;
            }
        }
    }
}
