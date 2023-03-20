using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using static AvaloniaApplication7.Classes.Helper;

namespace AvaloniaApplication7.Pages;

public partial class MainPage : UserControl
{
    public MainPage()
    {
        InitializeComponent(); 
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void LoadData()
    {
        this.FindControl<DataGrid>("MainDG").Items = Db.Users.Include(el => el.Role).ToList();
    }

    private void StyledElement_OnInitialized(object? sender, EventArgs e)
    {
        LoadData();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Navigation.Content = new TempPage();
    }

    private void Button_OnClick1(object? sender, RoutedEventArgs e)
    {
        Error();
    }
}