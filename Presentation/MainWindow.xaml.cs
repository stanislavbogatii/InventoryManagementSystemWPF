using System.Windows;
using Presentation.Services;
using Presentation.Views;

namespace Presentation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationService.MainFrame = MainFrame;
            NavigationService.Navigate(new LoginView());
        }
    }
}
