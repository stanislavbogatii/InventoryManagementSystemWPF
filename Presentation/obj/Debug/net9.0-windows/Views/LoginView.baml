   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      "    Presentation.Views.LoginView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  Login��5       � DataContext 5      ,   &Presentation.ViewModels.LoginViewModel  5   
   .��5      �� $��50q�6   $��Center=�6   .+�5   
   �� $��Логин:��6   �� 5   
   ��6   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��Пароль:��6   $��0,10,0,0q�6#   G� 5   
   -   5         G�Name$ PasswordBox��5      �� 5   
   -   5        $��
Войти��5      $��0,10,0,0q�6!   5      �� 5   
   $��Регистрация��6   $��0,10,0,0q�6'   ��5      �� *NavigateRegisterCommand+�� 5   
   
���  ��$��0,10,0,0q�6C   ��6   �� *ErrorMessage+6C   5      5      