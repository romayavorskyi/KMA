using System.Windows;
using System.Windows.Controls;

namespace Practice3.UserControls
{
    /// <summary>
    /// Interaction logic for LableAndTextControl.xaml
    /// </summary>
    public partial class LableAndTextControl : UserControl
    {

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(LableAndTextControl), new PropertyMetadata(null));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(LableAndTextControl), new PropertyMetadata(null));

        public LableAndTextControl()
        {
            InitializeComponent();
        }
    }
}
