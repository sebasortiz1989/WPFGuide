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

namespace ButtonDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush[] _colors = { Brushes.Red, Brushes.Yellow, Brushes.Blue};
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            myLabel.Foreground = _colors[rnd.Next(0,_colors.Length)];
            myLabel.FontSize++;
        }

        private void myButton_MouseEnter(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.Gray;
        }

        private void myButton_MouseLeave(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.Black;
        }
    }
}
