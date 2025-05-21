using System;
using System.Windows.Controls;

namespace Presentation.Services
{
    public static class NavigationService
    {
        public static Frame MainFrame { get; set; }

        public static void Navigate(object page)
        {
            MainFrame?.Navigate(page);
        }
    }
}
