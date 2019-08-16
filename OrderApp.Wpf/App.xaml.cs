using System.Windows;
using OrderApp.Wpf.Pages;

namespace OrderApp.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            new LoginPage().Show();
        }
    }
}
