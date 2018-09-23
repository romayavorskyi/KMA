using LoginWindow.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginWindow.Views;

namespace LoginWindow.Models
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
        private Views.LoginView _loginView;
        private Views.SignUpView _signUpView;
        private Views.MainView _mainView;

        public NavigationModel(ContentWindow contentWindow, Storage storage)
        {
            _contentWindow = contentWindow;
            _loginView = new Views.LoginView(this, storage);
            _signUpView = new Views.SignUpView(this, storage);
            _mainView = new Views.MainView();
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
