using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace DataBindingMvvm.Components;

public class NumericTextBox : TextBox
{
    private static readonly Regex Regex = new("[^0-9]+");

    protected override void OnPreviewTextInput(TextCompositionEventArgs e)
    {
        e.Handled = !IsTextAllowed(e.Text);
        base.OnPreviewTextInput(e);
    }

    private bool IsTextAllowed(string text) => !Regex.IsMatch(text) && Text.Length < 3;
}