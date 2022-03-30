using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TennisLibrary;

namespace TennisScore
{
    /// <summary>
    /// Interaction logic for PageScoring.xaml
    /// </summary>
    public partial class PageScoring : Page
    {
        DataScoring score = new DataScoring();

        public PageScoring(string name1, string name2)
        {

            InitializeComponent();

            score.InitGame(name1, name2);
            NombreJ1.Content = name1;
            NombreJ2.Content = name2;
        }

        private void JuegoGanadoJ1_Click(object sender, RoutedEventArgs e)
        {


            score.jugador1.Augmentarpuntuación(score.jugador2);
            SetsJ1.Content = score.jugador1.Sets;
            SetsJ2.Content = score.jugador2.Sets;
            PuntuacionJ1.Content = score.jugador1.Puntuacion;
            PuntuacionJ2.Content = score.jugador2.Puntuacion;
            if ((score.jugador1.Sets>=6&&score.jugador2.Sets<= score.jugador1.Sets-2)||(score.jugador1.Sets > 6&& score.jugador2.Sets == 6))
            {
                TheWinnerIs winner = new TheWinnerIs(score.jugador1);
                MainWindow win = ((MainWindow)Window.GetWindow(this));
                win.Navegador.Navigate(winner);
            }

        }

        private void JuegoGanadoJ2_Click(object sender, RoutedEventArgs e)
        {
            score.jugador2.Augmentarpuntuación(score.jugador1);
            SetsJ1.Content = score.jugador1.Sets;
            SetsJ2.Content = score.jugador2.Sets;
            PuntuacionJ1.Content = score.jugador1.Puntuacion;
            PuntuacionJ2.Content = score.jugador2.Puntuacion;

            if ((score.jugador2.Sets >= 6 && score.jugador1.Sets <= score.jugador2.Sets - 2) || (score.jugador2.Sets > 6 && score.jugador1.Sets == 6))
            {
                TheWinnerIs winner = new TheWinnerIs(score.jugador2);
                MainWindow win = ((MainWindow)Window.GetWindow(this));
                win.Navegador.Navigate(winner);
            }

        }
    }
}

