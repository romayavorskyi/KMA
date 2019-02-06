using System;
using Practice4.Views;
using Practice4.Windows;

namespace Practice4.Models
{

    public enum ModesEnum
    {
        Login,
        SingUp,
        Main
    }

    public class NavigationModel
    {

        private ContentWindow _contentWindow;
        private LoginView _loginView;
        private SignUpView _signUpView;
        private MainView _mainView;

        public NavigationModel(ContentWindow contentWindow, Storage storage)
        {
            _contentWindow = contentWindow;
            _loginView = new LoginView(storage);
            _signUpView = new SignUpView(storage);
            _mainView = new MainView(storage);
        }

        public void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Login:
                    _contentWindow.ContentControl.Content = _loginView;
                    break;
                case ModesEnum.SingUp:
                    _contentWindow.ContentControl.Content = _signUpView;
                    break;
                case ModesEnum.Main:
                    _contentWindow.ContentControl.Content = _mainView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

    }
}
