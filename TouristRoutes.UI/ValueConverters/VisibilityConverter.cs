using System.Globalization;

namespace TouristRoutes.UI.ValueConverters
{
    internal class VisibilyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
        CultureInfo culture)
        {
            if (value is TouristRout)
                return true;

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
        CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}