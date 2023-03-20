using System;
using Avalonia.Controls;
using AvaloniaApplication7.Pages;
using static AvaloniaApplication7.Classes.Helper;

namespace AvaloniaApplication7;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        AppMainWindow = this;
        Navigation = this.FindControl<ContentControl>("MainFrame");
        Navigation.Content = new MainPage();
        LoadData();
    }

    public void LoadData()
    {
        var calendar = this.FindControl<CalendarDatePicker>("MyCalendar");
        calendar.DisplayDateStart = DateTime.Now;
        calendar.DisplayDateEnd = DateTime.Now.AddDays(14);
         
    }
}