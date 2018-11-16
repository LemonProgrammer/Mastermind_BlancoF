using Mastermind_BlancoF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Mastermind_BlancoF.UserControls
{
	/// <summary>
	/// Interaction logic for PegControl.xaml
	/// </summary>
	public partial class PegControl : UserControl
	{
        public Mastermind_BlancoF.Models.Peg Peg { get; set; }


        public PegControl(Peg peg)
		{
            Peg = peg;

			InitializeComponent();
            DataContext = this;
		}

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
