using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Vistas
{
    class ConversorDeEstados:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                int valor = int.Parse(value.ToString());
                if (valor == 0)
                {
                    return new SolidColorBrush(Color.FromRgb(0, 255, 0));
                }
                else if (valor > 0 && valor <= 30)
                {
                    return new SolidColorBrush(Color.FromRgb(255, 128, 128));
                }
                else if (valor > 30 && valor <= 60)
                {
                    return new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
                else if (valor > 60)
                {
                    return new SolidColorBrush(Color.FromRgb(139, 0, 0));
                }
            }
            return value;     
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
