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

namespace TennisScore
{
    /// <summary>
    /// Interaction logic for PageInit.xaml
    /// </summary>
    public partial class PageInit : Page
    {
        public PageInit()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NombreJ1.Text) && !string.IsNullOrEmpty(NombreJ2.Text))
            {

                PageScoring wb = new PageScoring(NombreJ1.Text,NombreJ2.Text);
                MainWindow win = ((MainWindow)Window.GetWindow(this));
                win.Navegador.Navigate(wb);

            }
        }
    }
}
