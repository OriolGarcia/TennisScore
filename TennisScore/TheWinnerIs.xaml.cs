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
    /// Interaction logic for TheWinnerIs.xaml
    /// </summary>
    public partial class TheWinnerIs : Page
    {
        public TheWinnerIs(Jugador jug)
        {
            InitializeComponent();
            winner.Text = winner.Text + " " + jug.Nombre;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageInit init = new PageInit();
            MainWindow win = ((MainWindow)Window.GetWindow(this));
            win.Navegador.Navigate(init);
        }
    }
}
