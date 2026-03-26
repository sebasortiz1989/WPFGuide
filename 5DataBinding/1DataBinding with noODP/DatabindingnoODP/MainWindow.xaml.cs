using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DatabindingnoODP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> AvailableNumbers { get; } = new ObservableCollection<int> { 1, 2, 3, 4, 5 };

        public MainWindow()
        {
            //this.DataContext = this; //The data context of the mainwindow should be the same windows itself.
            //This is so we can use availableNumbers inside of our XAML
            //Another way is by saying DataContext="{Binding RelativeSource={RelativeSource Self}}" in the XAML
            InitializeComponent();
        }

        private void AddNumber(object sender, RoutedEventArgs e)
        {
            var random = new Random();
            AvailableNumbers.Add(random.Next(0, 10));
        }

        private void DeleteNumber(object sender, RoutedEventArgs e)
        {
            if (AvailableNumbers.Count > 0)
                AvailableNumbers.RemoveAt(0);
        }
    }
}
