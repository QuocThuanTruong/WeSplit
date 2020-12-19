﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WeSplit.Converter
{
	class JourneyStatusConverter: IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Visibility visibility = Visibility.Visible;

			int passedValue = (int)value;

			if (passedValue == -1)
			{
				visibility = Visibility.Collapsed;
			}
			else
			{
				visibility = Visibility.Visible;
			}

			Debug.WriteLine("" + visibility);

			return visibility;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
