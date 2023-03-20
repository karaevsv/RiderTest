using Avalonia.Controls;
using AvaloniaApplication7.Data;
using MessageBox.Avalonia;
using MessageBox.Avalonia.Enums;

namespace AvaloniaApplication7.Classes;

public static class Helper
{
    public static MainWindow AppMainWindow = null;
    public static ContentControl Navigation = null;
    public static ZhenyaDbContext Db = new ZhenyaDbContext();
    
    public static void Error(string message = "Ошибка подключения к БД")
    {
        MessageBoxManager.GetMessageBoxStandardWindow("Ошибка", message, ButtonEnum.Ok, Icon.Error).ShowDialog(AppMainWindow);
    }
}