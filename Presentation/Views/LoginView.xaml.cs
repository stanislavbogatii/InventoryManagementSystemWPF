using System.Windows;
using System.Windows.Controls;
using Presentation.ViewModels;

namespace Presentation.Views
{
    public partial class LoginView : Page
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel vm)
            {
                vm.LoginCommand.Execute(PasswordBox.Password);
            }
        }
    }
}
