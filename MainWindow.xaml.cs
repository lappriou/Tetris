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

namespace Tetris
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Jeu_Tetris jeu = new Jeu_Tetris();
            Forme forme = jeu.InitialiserForme();
            // Create Columne

            for(int c = 0; c < 10; c++) { 
            ColumnDefinition colonne = new ColumnDefinition();

            GrilleJeu.ColumnDefinitions.Add(colonne);
            }

            // Create Rows

            for (int c = 0; c < 20; c++)
            {
                RowDefinition ligne = new RowDefinition();

                GrilleJeu.RowDefinitions.Add(ligne);
            }


            Forme formeSuivante = jeu.InitialiserForme();

            //dessine la forme en cours


            //while ()
            //{


                for (int o = 0; o < 4; o++)
                {
                    Label bloc = new Label();
                    bloc.Background =  Brushes.Aqua  ;
                    Grid.SetColumn(bloc, forme.blocs[o].X);
                    Grid.SetRow(bloc, forme.blocs[o].Y);
                    GrilleJeu.Children.Add(bloc);
                }
                //TimeSpan timespan = new TimeSpan(0, 1, 0);

            //}




        }


    }


    }

