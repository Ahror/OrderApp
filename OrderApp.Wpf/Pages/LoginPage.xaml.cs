using System.Windows;
using OrderApp.Core.ViewModels;

namespace OrderApp.Wpf.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
    }
}
