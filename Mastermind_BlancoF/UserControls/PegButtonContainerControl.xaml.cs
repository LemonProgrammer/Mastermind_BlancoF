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
    /// Interaction logic for PegButtonContainerControl.xaml
    /// </summary>
    public partial class PegButtonContainerControl : UserControl
    {
        public List<Peg> Pegs { get; set; }

        public PegButtonContainerControl(List<Peg> pegs)
        {
            Pegs = pegs;
            InitializeComponent();
            DataContext = this;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Pegs.Count; i++)
            {
                PegButtonControl pegControl = new PegButtonControl(Pegs[i]);

                ColumnDefinition column = new ColumnDefinition();
                column.Width = new GridLength(1, GridUnitType.Star);
                PegContainer.ColumnDefinitions.Add(column);

                PegContainer.Children.Add(pegControl);
                Grid.SetColumn(pegControl, i);
            }
        }
    }
}
