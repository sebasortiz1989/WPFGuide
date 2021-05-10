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

namespace CatYearsProject
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

        private void ResultTextBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    int inputDogAge = Int32.Parse(InputDogAge.Text);
                    string resultInHumanAge = "";

                    if (inputDogAge >= 0 && inputDogAge <= 1)
                    {
                        resultInHumanAge = "0-12";
                        ResultTextBlock.Text = "Your dog is " + resultInHumanAge + " years old";
                    }
                    else if (inputDogAge >= 2 && inputDogAge <= 20)
                    {
                        resultInHumanAge = (((inputDogAge - 2) * 6) + 14).ToString();
                        ResultTextBlock.Text = "Your dog is " + resultInHumanAge + " years old";
                    }
                    else
                        ResultTextBlock.Text = "You entered a value that is not between 0-20 " +
                                               "Your dog is super old or not yet born";
                }
                catch(Exception myException)
                {
                    MessageBox.Show("Not a valid number, please enter a numeric value");
                }
            }
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
