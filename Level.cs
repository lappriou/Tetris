using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Level
    {
        public int ScoreADepasser { get; set; }
        public float CoefficientVitesse { get; set; }

        public Level(int scoreADepasser, float coefficientVitesse)
        {
            ScoreADepasser = scoreADepasser;
            CoefficientVitesse = coefficientVitesse;
        }
        {

        }
    }
}
