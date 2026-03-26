using System.Windows;
using System.Windows.Controls;

namespace DataBindingMvvm.Components;

public partial class BorderedButton : UserControl
{
    public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
        nameof(Text), typeof(string), typeof(BorderedButton), new PropertyMetadata(string.Empty));

    public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
        nameof(CornerRadius), typeof(CornerRadius), typeof(BorderedButton), new PropertyMetadata(new CornerRadius(0)));

    public static readonly DependencyProperty HoverBackgroundProperty = DependencyProperty.Register(
        nameof(HoverBackground), typeof(System.Windows.Media.Brush), typeof(BorderedButton), new PropertyMetadata(null));

    public static readonly DependencyProperty HoverForegroundProperty = DependencyProperty.Register(
        nameof(HoverForeground), typeof(System.Windows.Media.Brush), typeof(BorderedButton), new PropertyMetadata(null));

    public static readonly DependencyProperty HoverBorderBrushProperty = DependencyProperty.Register(
        nameof(HoverBorderBrush), typeof(System.Windows.Media.Brush), typeof(BorderedButton), new PropertyMetadata(null));

    public static readonly DependencyProperty PressedBackgroundProperty = DependencyProperty.Register(
        nameof(PressedBackground), typeof(System.Windows.Media.Brush), typeof(BorderedButton), new PropertyMetadata(null));

    public static readonly DependencyProperty PressedForegroundProperty = DependencyProperty.Register(
        nameof(PressedForeground), typeof(System.Windows.Media.Brush), typeof(BorderedButton), new PropertyMetadata(null));

    public static readonly DependencyProperty PressedBorderBrushProperty = DependencyProperty.Register(
        nameof(PressedBorderBrush), typeof(System.Windows.Media.Brush), typeof(BorderedButton), new PropertyMetadata(null));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public CornerRadius CornerRadius
    {
        get => (CornerRadius)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }

    public BorderedButton()
    {
        InitializeComponent();
    }

    public System.Windows.Media.Brush HoverBackground
    {
        get => (System.Windows.Media.Brush)GetValue(HoverBackgroundProperty);
        set => SetValue(HoverBackgroundProperty, value);
    }

    public System.Windows.Media.Brush HoverForeground
    {
        get => (System.Windows.Media.Brush)GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }

    public System.Windows.Media.Brush HoverBorderBrush
    {
        get => (System.Windows.Media.Brush)GetValue(HoverBorderBrushProperty);
        set => SetValue(HoverBorderBrushProperty, value);
    }

    public System.Windows.Media.Brush PressedBackground
    {
        get => (System.Windows.Media.Brush)GetValue(PressedBackgroundProperty);
        set => SetValue(PressedBackgroundProperty, value);
    }

    public System.Windows.Media.Brush PressedForeground
    {
        get => (System.Windows.Media.Brush)GetValue(PressedForegroundProperty);
        set => SetValue(PressedForegroundProperty, value);
    }

    public System.Windows.Media.Brush PressedBorderBrush
    {
        get => (System.Windows.Media.Brush)GetValue(PressedBorderBrushProperty);
        set => SetValue(PressedBorderBrushProperty, value);
    }
}