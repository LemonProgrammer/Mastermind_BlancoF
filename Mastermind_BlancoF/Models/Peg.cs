using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_BlancoF.Models
{
	public class Peg : INotifyPropertyChanged
	{
		public enum Colors
		{
			Grey,
			Black,
			White,
			Yellow,
			Red,
			Green,
			Blue,
			Num_Colors
		}

		public static Colors CORRECT_COLOR = Colors.White;
		public static Colors CORRECT_COLOR_POSITION = Colors.Black;

		private Colors color = Colors.Grey;

        public event PropertyChangedEventHandler PropertyChanged;

        public Colors Color
		{
			get { return color; }
			set {
                color = value;
                OnPropertyChanged("Color");
            }
		}

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


		public void SetNextColor()
		{
			Color = Color + 1;
			if (Color > Colors.Blue)
			{
				Color = Colors.Black;
			}
		}

	}
}
