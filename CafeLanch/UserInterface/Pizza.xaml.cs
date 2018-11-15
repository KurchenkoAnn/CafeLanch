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
    /// Interaction logic for Pizza.xaml
    /// </summary>
    public partial class Pizza : MetroWindow
    {

        ServiceReference1.PizzaClient PizzaClient = new ServiceReference1.PizzaClient();

        public Pizza()
        {
            InitializeComponent();
            GetPizzasFromService();
        }

        public void GetPizzasFromService()
        {
            ProgRing.IsActive = true;
            Task t = new Task(() =>
            {
                var list = PizzaClient.GetPizzas();
                this.Invoke(() =>
                {
                    ListOfPizzas.ItemsSource = list;
                    ProgRing.IsActive = false;
                });
               
            });
            t.Start();
        }

    }
}
