﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace Labo5_meteo.Converter
{
    public class WeatherDescriptionToImageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var forecast = (string)value;
            if (forecast.Contains("nuageux"))
            {
                return new BitmapImage(new Uri("ms-appx:Images/cloudy.png"));
            }
            else
            {
                return new BitmapImage(new Uri("ms-appx:Images/sun.png"));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
