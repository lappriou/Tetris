using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Forme 
    {
        public Bloc[] blocs = new Bloc[4];

        public void DeplacerAGauche()
        {         
                blocs[0].X = blocs[0].X - 1;
                blocs[1].X -= 1;
                blocs[2].X -= 1;
                blocs[3].X -= 1;
            
        }


        abstract public void rotation();
        

    }


}
