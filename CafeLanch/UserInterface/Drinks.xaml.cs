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
using System.Windows.Shapes;

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : MetroWindow
    {
        public Drinks()
        {
            InitializeComponent();
        }

       

        private void comboboxC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LV.ItemsSource = null;
            LV.Items.Clear();
            //foreach (Clothes clothes in shopContext.Clothess.Include("category"))
            //{
            //    if (comboboxC.SelectedItem.ToString().Equals(clothes.category.Name))
            //    {
            //        LV.Items.Add(clothes);
            //    }
            //}
        }
    }
}
