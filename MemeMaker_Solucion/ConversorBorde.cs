﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace MemeMaker_Solucion
{
    class ConversorBorde : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)value ? 2 : 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
