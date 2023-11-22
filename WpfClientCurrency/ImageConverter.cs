﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfClientCurrency
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                double chage = double.Parse(value.ToString());
                if (chage < 0)
                    return new Uri("pack://application:,,,/Images/down.png");
                else if(chage > 0)
                    return new Uri("pack://application:,,,/Images/up.png");
                return new Uri("pack://application:,,,/Images/no-change.png");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
