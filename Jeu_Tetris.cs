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
        int Id = 0;

        public List<string> ListeCouleur = new List<string> { "#3399ff", "#6C7F59", "#7E680B", "#FDD016", "#3A9649", "#47ce8e", "#8b7b8b", "#7b68ee", "#8b7e66", "#20b2aa" };




        public etatBloc[,] grilleTetris;

        public Jeu_Tetris()
        {
            grilleTetris = new etatBloc[10, 24];
            
        }

        public Forme InitialiserForme()
       {
            
            #region Les formes

            Forme carre = new Carree();
            Forme l = new L();
            Forme linverse = new LInverse();
            Forme ligne = new Ligne();
            Forme marche = new Marche();
            Forme marcheInverse = new MarcheInverse();
            Forme t = new T();


            #endregion
            formes.Clear();
            Forme formeAleatoire;
            formes.Add( carre);
            formes.Add(l);
            formes.Add(linverse);
            formes.Add(ligne);
            formes.Add(marche);
            formes.Add(marcheInverse);
            formes.Add(t);

            
            Random geneAleatoire = new Random();
            int nombregenere = geneAleatoire.Next(0, formes.Count - 1);
            int couleurgenere = geneAleatoire.Next(0, ListeCouleur.Count - 1);
            formeAleatoire = formes[nombregenere];
            formeAleatoire.Couleur = ListeCouleur[couleurgenere];
            return formeAleatoire;
        }


        public void initGrille()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    grilleTetris[i, j].Id = null  ;  // aucun objet est present dans la grille au depart
                }
            }
        }

        #region Collision
        //test les cases disponible vertical
        public bool CollisionVertical(Bloc[] blocs)
        {
            bool collision = false;

            for (int i = 0; i < blocs.Count(); i++)
                if (blocs[i].Y == 0 || grilleTetris[blocs[i].X,blocs[i].Y - 1].Id != null)
            {
                    collision = true;
                    return collision;
                }

            return collision;
        }


        //test les cases disponible horizontal
        public bool CollisionHorizontalGauche(Bloc[] blocs)
        {
            bool collision = false;

            for (int i = 0; i < blocs.Count(); i++)
                if ( blocs[i].X  == 9 || grilleTetris[blocs[i].X + 1,blocs[i].Y ].Id != null)
                {
                    collision = true;
                    return collision;
                }

            return collision;
        }

        public bool CollisionHorizontalDroite(Bloc[] blocs)
        {
            bool collision = false;

            for (int i = 0; i < blocs.Count(); i++)
                if (blocs[i].X  == 0 ||  grilleTetris[blocs[i].X - 1,blocs[i].Y ].Id != null)
                {
                    collision = true;
                    return collision;
                }

            return collision;
        }
        #endregion


        public etatBloc[,] getGrille()
        {
            return grilleTetris;
        }


        public void remplirGrille(Forme forme)
        {
            for(int i = 0; i < forme.blocs.Count(); i++)
            {
                grilleTetris[forme.blocs[i].X, forme.blocs[i].Y].Id = Id;
                grilleTetris[forme.blocs[i].X, forme.blocs[i].Y].Couleur = forme.Couleur;

            }
        }

        public void VerifLigneComplete()
        {
            for (int r = 0; r < 20; r++)
            {
                int compteur = 0;
                for (int c = 0; c < 10; c++)
                {
                    if(grilleTetris[c,r].Id != null)
                    {
                        compteur += 1;
                    }
                }
                if(compteur == 10)
                {
                    for (int row = 0; row < 20; row++)
                    {
                        for (int c = 0; c < 10; c++)
                        {
                            grilleTetris[c, row] = grilleTetris[c, row + 1];


                        }
                    }

                    r -= 1;
                }

            }
        }

        public void Rotation(Forme forme)
        {
            //sert a vérifié la disponibilité des cases apres rotation
            //Forme test = forme;
            //test.rotation();
            bool colision = false;
            //for(int i = 0; i< test.blocs.Count(); i++)
            //{
            //    if(grilleTetris[test.blocs[i].X, test.blocs[i].Y].Id != null || test.blocs[i].X < 0 || test.blocs[i].X > 9 || test.blocs[i].Y < 0)
            //    {
            //        colision = true;
            //    }
            //}

            if(colision ==false)
            {
                forme.rotation();
            }

        }
        

        }

        
    }

