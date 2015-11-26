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
            int? id;
            string couleur;
            Bloc bloc;
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
