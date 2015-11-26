﻿using System;
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
            if (blocs[3].Y - blocs[0].Y == 3)
            {
                blocs[1].X -= 1;
                blocs[0].Y -= 1;
                blocs[2].X -= 2;
                blocs[2].Y -= 2;
                blocs[3].X -= 3;
                blocs[3].Y -= 3;
            }
            else
            {
                blocs[1].X += 1;
                blocs[0].Y += 1;
                blocs[2].X += 2;
                blocs[2].Y += 2;
                blocs[3].X += 3;
                blocs[3].Y += 3;
            }
        }
    }
}
