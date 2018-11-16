using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using Mastermind_BlancoF.Models;

namespace Mastermind_BlancoF.Converters
{
	class ColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Peg.Colors color = (Peg.Colors)value;

			SolidColorBrush brush = new SolidColorBrush(Colors.Black);

			switch (color)
			{
				case Peg.Colors.Grey:
					brush = new SolidColorBrush(Colors.Gray);
					break;
				case Peg.Colors.Black:
					brush = new SolidColorBrush(Colors.Black);
					break;
				case Peg.Colors.White:
					brush = new SolidColorBrush(Colors.White);
					break;
				case Peg.Colors.Yellow:
					brush = new SolidColorBrush(Colors.Yellow);
					break;
				case Peg.Colors.Red:
					brush = new SolidColorBrush(Colors.Red);
					break;
				case Peg.Colors.Green:
					brush = new SolidColorBrush(Colors.Green);
					break;
				case Peg.Colors.Blue:
					brush = new SolidColorBrush(Colors.Blue);
					break;
				default:
					break;
			}
			
			return brush;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
