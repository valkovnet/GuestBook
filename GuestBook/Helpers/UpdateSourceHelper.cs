using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace GuestBook.Helpers
{
    public class UpdateSourceHelper
    {
        public static readonly DependencyProperty UpdateSourceTriggerProperty =
            DependencyProperty.RegisterAttached("UpdateSourceTrigger", typeof(bool), typeof(UpdateSourceHelper),
                                                new PropertyMetadata(false, OnUpdateSourceTriggerChanged));

        public static bool GetUpdateSourceTrigger(DependencyObject d)
        {
            return (bool)d.GetValue(UpdateSourceTriggerProperty);
        }

        public static void SetUpdateSourceTrigger(DependencyObject d, bool value)
        {
            d.SetValue(UpdateSourceTriggerProperty, value);
        }

        private static void OnUpdateSourceTriggerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is bool && d is TextBox)
            {
                var textBox = d as TextBox;
                textBox.TextChanged -= PassportBoxPasswordChanged;

                if ((bool)e.NewValue)
                {
                    textBox.TextChanged += PassportBoxPasswordChanged;
                }
            }
        }

        private static void PassportBoxPasswordChanged(object sender, RoutedEventArgs e)
        {
            var frameworkElement = sender as PasswordBox;
            if (frameworkElement != null)
            {
                BindingExpression bindingExpression = frameworkElement.GetBindingExpression(TextBox.TextProperty);
                if (bindingExpression != null)
                {
                    bindingExpression.UpdateSource();
                }
            }
        }
    }
}
