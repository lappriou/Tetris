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
            Jeu_Tetris tetris = new Jeu_Tetris();
            
            Forme Carre = new Forme [4]{ new Bloc { X = 4, Y = 20 }, new Bloc { X = 5, Y = 20 }, new Bloc { X = 4, Y = 19 }, new Bloc { X = 5, Y = 19 } };
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
