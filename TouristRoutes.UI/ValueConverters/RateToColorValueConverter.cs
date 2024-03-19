using System.Globalization;

namespace TouristRoutes.UI.ValueConverters
{
    internal class RateToColorValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
        CultureInfo culture)
        {
            if ((decimal)value < 4000)
                return Colors.Green;

        return Colors.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
        CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}