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
        public double CoefficientVitesse { get; set; }

        public Level(int scoreADepasser, double coefficientVitesse)
        {
            ScoreADepasser = scoreADepasser;
            CoefficientVitesse = coefficientVitesse;
        }
    }
}
