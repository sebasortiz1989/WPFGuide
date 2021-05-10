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

namespace CheckBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cbTopingChanged(object sender, RoutedEventArgs e)
        {
            if (cbCheese.IsChecked == true && cbPepperoni.IsChecked == true && cbJam.IsChecked == true && cbPineapple.IsChecked == true)
                cbParent.IsChecked = true;
            else if (cbCheese.IsChecked == false && cbPepperoni.IsChecked == false && cbJam.IsChecked == false && cbPineapple.IsChecked == false)
                cbParent.IsChecked = false;
        }

        private void cbParent_Checked_change(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbParent.IsChecked == true);
            cbCheese.IsChecked = newVal;
            cbPepperoni.IsChecked = newVal;
            cbJam.IsChecked = newVal;
            cbPineapple.IsChecked = newVal;
        }
    }
}
