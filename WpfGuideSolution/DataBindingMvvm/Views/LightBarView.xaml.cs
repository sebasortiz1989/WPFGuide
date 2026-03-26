using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using DataBindingMvvm.Viewmodels;

namespace DataBindingMvvm.Views;

public partial class LightBarView : UserControl
{
    private static readonly Regex Regex = new("[^0-9]+");

    public LightBarView(LightBarViewmodel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e) => e.Handled = !IsTextAllowed(e.Text);

    private bool IsTextAllowed(string text) => !Regex.IsMatch(text) && NumericTextBox1.Text.Length < 3;
}