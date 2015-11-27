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
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; i < 20; j++)
                {
                    grilleTetris[i, j].Id = null  ;  // aucun objet est present dans la grille au depart
                    grilleTetris[i, j].Couleur = "#DDDDDD"; // la couleur est par defaut au debut
                }
            }
        }

        //test les cases disponible vertical
        public bool CollisionVertical(Bloc[] blocs)
        {
            bool collision = false;
            Bloc test = new Bloc();

            for (int i =0; i< blocs.Count(); i++)
            if(grilleTetris[blocs[i].X, blocs[i].Y - 1].Id != null || grilleTetris[blocs[i].X, blocs[i].Y + 1].Id != null)
            {
                    collision = true;
            }

            return collision;


        }

        //test les cases disponible horizontal
        public bool CollisionHorizontal(Bloc[] blocs)
        {
            bool collision = false;
            Bloc test = new Bloc();

            for (int i = 0; i < blocs.Count(); i++)
                if (grilleTetris[blocs[i].X - 1, blocs[i].Y].Id != null || grilleTetris[blocs[i].X + 1, blocs[i].Y].Id != null)
                {
                    collision = true;
                }

            return collision;
        }
    }
}
