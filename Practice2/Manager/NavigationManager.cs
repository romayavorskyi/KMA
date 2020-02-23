using Practice2.Models;

namespace Practice2.Manager
{
    public class NavigationManager
    {

        private static NavigationManager _instance;
        private static object _lock = new object();
        private NavigationModel _navigationModel;

        public static NavigationManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                            _instance = new NavigationManager();
                    }
                }

                return _instance;
            }
        }

        public void Initialize(NavigationModel navigationModel)
        {
            _navigationModel = navigationModel;
        }

        public void Navigate(ModesEnum mode)
        {
            _navigationModel?.Navigate(mode);
        }

    }
}
