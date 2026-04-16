using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEssentials.UI.WinUI.Converters
{
    public class ObjectToIntConverter : MSEssentials.UI.Common.Converters.ObjectToIntConverter, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language) =>
            base.Convert(value);

        public object ConvertBack(object value, Type targetType, object parameter, string language) =>
            base.ConvertBack((int)value);
    }
}
