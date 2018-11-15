using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : MetroWindow
    {
        ServiceReference1.DrinkClient DrinkClient = new ServiceReference1.DrinkClient();

        public Drinks()
        {
            InitializeComponent();
            //ListOfDrinks.ItemsSource = DrinkClient.GetDrinks();
            GetDrinkFromService();

        }

        public void GetDrinkFromService()
        {
            ProgRing.IsActive = true;
            Task t = new Task(() =>
            {
                
                var list = DrinkClient.GetDrinks();

                this.Invoke(() =>
                {
                    ListOfDrinks.ItemsSource = list;
                    ProgRing.IsActive = false;
                });

            });
            t.Start();
        }

       
    }
}
