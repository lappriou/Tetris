using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;

namespace Tetris
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Jeu_Tetris jeu = new Jeu_Tetris();
        Forme forme;
        Timer timer = new Timer();
        
        Forme formeSuivante;

        public MainWindow()
        {
            InitializeComponent();
            forme = jeu.InitialiserForme();
            timer.Interval = 1000;
            //GrilleJeu.KeyDown +=
            //   new KeyEventHandler(this.KeyDown);
            #region Crée la grille WPF
            // Create Columne

            for (int c = 0; c < 10; c++)
            {
                ColumnDefinition colonne = new ColumnDefinition();

                GrilleJeu.ColumnDefinitions.Add(colonne);
            }

            // Create Rows

            for (int c = 0; c < 20; c++)
            {
                RowDefinition ligne = new RowDefinition();

                GrilleJeu.RowDefinitions.Add(ligne);
            }

            //create Label
            for (int r = 0; r < 20; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Label bloc = new Label();
                    bloc.Background = Brushes.Beige;
                    //bloc.Borde = Brushes.Black;
                    bloc.Width = GrilleJeu.Width / 10;
                    bloc.Height = GrilleJeu.Height / 20;
                    Grid.SetColumn(bloc, c);
                    Grid.SetRow(bloc, r);

                    GrilleJeu.Children.Add(bloc);
                }
            }
            #endregion

            formeSuivante = jeu.InitialiserForme();
            RemplirCanvas();

        }



        public void DessinerForme()
        {
            for (int l = 0; l < 20; l++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (jeu.grilleTetris[c, l].Id != null)
                    {
                        Label bloc = new Label();
                        bloc.Background = new BrushConverter().ConvertFromString(jeu.grilleTetris[c, l].Couleur) as SolidColorBrush;
                        bloc.Width = GrilleJeu.Width / 10;
                        bloc.Height = GrilleJeu.Height / 20;
                        Grid.SetColumn(bloc, c);
                        Grid.SetRow(bloc, l);

                        GrilleJeu.Children.Add(bloc);
                    }
                }
            }

            for (int o = 0; o < 4; o++)
            {
                Label bloc = new Label();
                bloc.Background = new BrushConverter().ConvertFromString(forme.Couleur) as SolidColorBrush;
                bloc.Width = GrilleJeu.Width / 10;
                bloc.Height = GrilleJeu.Height / 20;
                Grid.SetColumn(bloc, forme.blocs[o].X);
                Grid.SetRow(bloc, forme.blocs[o].Y);

                GrilleJeu.Children.Add(bloc);
            }
        }

        public void CouleurDefaut()
        {
            for (int r = 0; r < 20; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Label bloc = new Label();
                    bloc.Background = Brushes.Beige;
                    //bloc.Borde = Brushes.Black;
                    bloc.Width = GrilleJeu.Width / 10;
                    bloc.Height = GrilleJeu.Height / 20;
                    Grid.SetColumn(bloc, c);
                    Grid.SetRow(bloc, r);

                    GrilleJeu.Children.Add(bloc);
                }
            }
        }

        public void RemplirCanvas()
        {
            CanFormeSuivante.Children.Clear();
            for (int i = 0; i < formeSuivante.blocs.Count(); i++)
            {
                Rectangle blocSuivant = new Rectangle();
                blocSuivant.Height = 30;
                blocSuivant.Width = 30;
                blocSuivant.Fill = new BrushConverter().ConvertFromString(formeSuivante.Couleur) as SolidColorBrush;
                Canvas.SetBottom(blocSuivant, CanFormeSuivante.Height/2 + (formeSuivante.blocs[i].Y -21)* blocSuivant.Height );
                Canvas.SetRight(blocSuivant, CanFormeSuivante.Width/2 + (formeSuivante.blocs[i].X - 4)* blocSuivant.Width);
                CanFormeSuivante.Children.Add(blocSuivant);

                    }
        }

        private void buJouer_Click(object sender, RoutedEventArgs e)
        {
            jeu.initGrille();
            //create Label
            CouleurDefaut();
            forme = jeu.InitialiserForme();

        }

       
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                if (jeu.CollisionVertical(forme.blocs) == false)
                {
                    CouleurDefaut();
                    forme.DeplacerEnBas();
                    DessinerForme();
                }
                else {
                    jeu.remplirGrille(forme);
                    DessinerForme();
                    forme = formeSuivante;
                    formeSuivante = jeu.InitialiserForme();
                    RemplirCanvas();
                    jeu.VerifLigneComplete();

                }

             }            
            else if (e.Key == Key.Up)
            {
                if (true)
                {
                    CouleurDefaut();
                    jeu.Rotation(forme);
                    DessinerForme();
                }
            }

            else if (e.Key == Key.Left)
            {
                if (jeu.CollisionHorizontalGauche(forme.blocs) == false)
                {
                    CouleurDefaut();
                    forme.DeplacerAGauche();
                    DessinerForme();
                }
            }
            else if (e.Key == Key.Right && jeu.CollisionHorizontalDroite(forme.blocs) == false)
            {
                CouleurDefaut();
                forme.DeplacerADroite();
                DessinerForme();
            }
        }
    }
    }


    

