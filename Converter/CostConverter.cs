using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace TestTask.Converter
{
    public class CostConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
                return Math.Round((decimal)value, 4);
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double result;
            if (double.TryParse(value.ToString(), System.Globalization.NumberStyles.Any, culture, out result))
            {
                return result;
            }
            else if (double.TryParse(value.ToString().Replace(" ", ""), System.Globalization.NumberStyles.Any, culture, out result))
            {
                return result;
            }
            return value;
        }
    }
}
