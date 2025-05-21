using System.Windows.Input;
using Presentation.Helpers;
using Presentation.Services;
using Presentation.Views;

namespace Presentation.ViewModels
{
    public class RegisterViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand RegisterCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        public RegisterViewModel()
        {
            RegisterCommand = new RelayCommand(Register);
            NavigateLoginCommand = new RelayCommand(_ => NavigationService.Navigate(new LoginView()));
        }

        private void Register(object parameter)
        {
            Password = parameter as string;
            // Здесь можно добавить логику регистрации
            NavigationService.Navigate(new LoginView());
        }
    }
}
