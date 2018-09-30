using System.Windows.Controls;
using Practice2.Models;
using Practice2.ViewModels;

namespace Practice2.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView(Storage storage)
        {
            InitializeComponent();
            MainViewModel viewModel = new MainViewModel(storage);
            DataContext = viewModel;
            HelloLabel.Content = $"Hello";
        }
    }
}
