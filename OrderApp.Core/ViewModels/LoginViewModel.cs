using System;
using System.Diagnostics;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using OrderApp.Core.Services;
using ReactiveUI;

namespace OrderApp.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly AuthenticationService _authenticationService;
        private string _login;

        public string Login
        {
            get => _login;
            set => this.RaiseAndSetIfChanged(ref _login, value);
        }

        private string _password;

        public string Password
        {
            get => _password;
            set => this.RaiseAndSetIfChanged(ref _password, value);
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get => _errorMessage;
            set => this.RaiseAndSetIfChanged(ref _errorMessage, value);
        }

        public LoginViewModel()
        {
            _authenticationService = new AuthenticationService();
            LoginCommand = ReactiveCommand.CreateFromTask(LoginUser, 
                this.WhenAny(model => model.Login, model=>model.Password, 
                (x,y)=> !string.IsNullOrEmpty(x.Value) && !string.IsNullOrEmpty(y.Value)));
            LoginCommand.ThrownExceptions.Subscribe((ex) =>
            {
                Debug.WriteLine(ex);
                ErrorMessage = ex.GetBaseException().Message;
            });
        }

        private async Task LoginUser()
        {
            try
            {
                if (await _authenticationService.LoginAsync(Login, Password))
                {
                    //Login success go home page
                }
                else
                {
                    //ErrorMessage = "login unsuccessful";
                }
            }
            catch (Exception e)
            {
               // ErrorMessage = e.GetBaseException().Message;
            }

        }

        public ReactiveCommand<Unit,Unit> LoginCommand { get; set; }

    }
}