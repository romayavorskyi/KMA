﻿using System.Windows.Controls;

namespace LoginWindow.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            HelloLabel.Content = $"Hello";
        }
    }
}
