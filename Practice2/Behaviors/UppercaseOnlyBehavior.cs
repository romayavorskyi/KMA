using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Practice2.Behaviors
{
    class UppercaseOnlyBehavior: Behavior<TextBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.TextChanged += OnTextChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.TextChanged -= OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            AssociatedObject.Text = AssociatedObject.Text.ToUpper();
        }
    }
}
