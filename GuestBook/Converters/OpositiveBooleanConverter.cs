using System;
using System.Windows.Data;

namespace GuestBook.Converters
{
    public class OpositiveBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return false;
            
            return (!(bool)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return false;

            return (!(bool)value);
        }
    }
}
