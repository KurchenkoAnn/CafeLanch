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
    /// Interaction logic for Desserts.xaml
    /// </summary>
    public partial class Desserts : MetroWindow
    {
        ServiceReference1.DessertClient DessertClient = new ServiceReference1.DessertClient();

        public Desserts()
        {
            InitializeComponent();
            GetDessertFromService();
        }
        public void GetDessertFromService()
        {
            ProgRing.IsActive = true;
            Task t = new Task(() =>
            {
                var list = DessertClient.GetDessert();
                this.Invoke(() =>
                {
                    ListOfDesserts.ItemsSource = list;
                    ProgRing.IsActive = false;
                });

            });
            t.Start();


        }
    }
}
