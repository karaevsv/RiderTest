using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using static AvaloniaApplication7.Classes.Helper;

namespace AvaloniaApplication7.Pages;

public partial class TempPage : UserControl
{
    public TempPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Navigation.Content = new MainPage();
    }
}