using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Jeu_Tetris
    {
        public struct etatBloc
        {
            public int? Id { get; set; } // garde en memoire a quel objet appartient le bloc
            public string Couleur { get; set; }
        }

        List<Forme> formes = new List<Forme>();
        Forme carre = new Carree();
        Forme l = new L();
        Forme linverse = new LInverse();
        Forme ligne = new Ligne();
        Forme marche = new Marche();
        Forme marcheInverse = new MarcheInverse();
        Forme t = new T();

        public etatBloc[,] grilleTetris;

        public Jeu_Tetris()
        {
            grilleTetris = new etatBloc[10, 24];
            
        }

        public Forme InitialiserForme()
       {
            formes.Add( carre);
            formes.Add(l);
            formes.Add(linverse);
            formes.Add(ligne);
            formes.Add(marche);
            formes.Add(marcheInverse);
            formes.Add(t);

            Random geneAleatoire = new Random();
            int nombregenere = geneAleatoire.Next(0, formes.Capacity - 1);
            return formes[nombregenere];
        }


        public void initGrille()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 4; j++)
                {
                    grilleTetris[i, j].Id = null  ;  // aucun objet est present dans la grille au depart
                    grilleTetris[i, j].Couleur = // la couleur est par defaut au debut
                }
            }
        }


        //test les cases disponible vertical
        public void CollisionVertical()
        {

        }

        //test les cases disponible horizontal
        public void CollisionHorizontal()
        {

        }

        // Remettre la grille vide (couleur et id a null)
        public void InitGrille()
        {

        }


    }
}
