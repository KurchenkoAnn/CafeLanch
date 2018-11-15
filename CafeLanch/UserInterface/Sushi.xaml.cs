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
    /// Interaction logic for Sushi.xaml
    /// </summary>
    public partial class Sushi : MetroWindow
    {
        ServiceReference1.SushiClient SushiClient = new ServiceReference1.SushiClient();
        public Sushi()
        {
            InitializeComponent();
            GetSushiFromService();
            
        }
        public void GetSushiFromService()
        {
            ProgRing.IsActive = true;
            Task t = new Task(() =>
            {
                var list = SushiClient.GetSushis();
                this.Invoke(() =>
                {
                    ListOfSushis.ItemsSource = list;
                    ProgRing.IsActive = false;
                });

            });
            t.Start();


        }


    }
}
