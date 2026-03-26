using System.Windows.Controls;
using DataBindingMvvm.Viewmodels;

namespace DataBindingMvvm.Views;

public partial class LightBarView : UserControl
{
    public LightBarView(LightBarViewmodel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}