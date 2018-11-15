using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            
            //    var p = new MediaPlayer();
            //    p.Open(new Uri(@"C:/Users/Owner/Desktop/picca-fary.mp3", UriKind.Absolute));
            //    p.Play();
            
        }

        
        

        private void pizzas_Click(object sender, RoutedEventArgs e)
        {
            Pizza p = new Pizza();
           p.ShowDialog();
         
        }

        private void drinks_Click(object sender, RoutedEventArgs e)
        {
            Drinks d = new Drinks();
            d.ShowDialog();
            
        }

        private void sushi_Click(object sender, RoutedEventArgs e)
        {
            Sushi s = new Sushi();
            s.ShowDialog();
        }

        private void desserts_Click(object sender, RoutedEventArgs e)
        {
            Desserts d = new Desserts();
            d.ShowDialog();
        }
    }
}
