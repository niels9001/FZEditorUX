using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace FZEditor
{

    public class DoubleToThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
        object parameter, string language)
        {
            var var = (double)value;

            return new Thickness(var, var, var, var);
        }

        public object ConvertBack(object value, Type targetType,
        object parameter, string language)
        {
            return value;
        }
    }
}
