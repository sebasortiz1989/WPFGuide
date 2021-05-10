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
        public TextBlock _resultTextBlock;
        public TextBox _inputDogAge;
        StackPanel MainVerticalStackPanel;

        public MainWindow()
        {
            InitializeComponent();

            Image backgroundImage = new Image()
            {
                Source = new BitmapImage(
                new Uri("https://www.foresightsports.com/sites/default/files/images/home/play-anywhere.jpg")),
                //new Uri(Environment.CurrentDirectory + @"\..\..\Images\play-anywhere.jpg", UriKind.RelativeOrAbsolute)),
                Height = 300
            };

            _resultTextBlock = new TextBlock() { Text = "Your dog is ", FontSize = 18 };

            _inputDogAge = new TextBox()
            {
                Width = 120,
                TextAlignment = TextAlignment.Center,
                FontSize = 16,
                Margin = new Thickness(5, 0, 0, 0)
            };

            _inputDogAge.KeyDown += InputDogAge_KeyDown; //This is when you call the function

            TextBlock userQuestion = new TextBlock() { Text = "How old is your dog? (years) ", FontSize = 18 };

            StackPanel HorizontalSp = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(1, 5, 0, 0) };

            HorizontalSp.Children.Add(userQuestion);
            HorizontalSp.Children.Add(_inputDogAge);

            MainVerticalStackPanel = new StackPanel();

            MainVerticalStackPanel.Children.Add(HorizontalSp);
            MainVerticalStackPanel.Children.Add(_resultTextBlock);
            MainVerticalStackPanel.Children.Add(backgroundImage);

            myMainWindow.Content = MainVerticalStackPanel;
        }

        private void InputDogAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    int inputDogAge = Int32.Parse(_inputDogAge.Text);
                    string resultInHumanAge = "";

                    if (inputDogAge >= 0 && inputDogAge <= 1)
                    {
                        resultInHumanAge = "0-12";
                        _resultTextBlock.Text = "Your dog is " + resultInHumanAge + " years old";
                    }
                    else if (inputDogAge >= 2 && inputDogAge <= 20)
                    {
                        resultInHumanAge = (((inputDogAge - 2) * 6) + 14).ToString();
                        _resultTextBlock.Text = "Your dog is " + resultInHumanAge + " years old";
                    }
                    else
                        _resultTextBlock.Text = "You entered a value that is not between 0-20 " +
                                               "Your dog is super old or not yet born";
                }
                catch(Exception myException)
                {
                    MessageBox.Show("Not a valid number, please enter a numeric value");
                }

                TextBlock myExtraText = new TextBlock() { Text = "Underneath the image", FontSize = 18 };
                MainVerticalStackPanel.Children.Add(myExtraText);
            }
        }
    }
}
