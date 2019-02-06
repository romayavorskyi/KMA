﻿using System.Windows.Controls;
using Practice4.Models;
using Practice4.ViewModels;

namespace Practice4.Views
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
