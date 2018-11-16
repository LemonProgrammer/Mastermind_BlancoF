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
    /// Interaction logic for PegContainerControl.xaml
    /// </summary>
    public partial class PegContainerControl : UserControl
    {
        public List<Peg> Pegs { get; set; }
        public PegContainerControl(List<Peg> pegs)
        {
            InitializeComponent();
            Pegs = pegs;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Pegs.Count; i++)
            {
                PegControl pegControl = new PegControl(Pegs[i]);
                ColumnDefinition colum = new ColumnDefinition();
                colum.Width = new GridLength(1, GridUnitType.Star);
                PegContainer.ColumnDefinitions.Add(colum);
                PegContainer.Children.Add(pegControl);
                Grid.SetColumn(pegControl, i);

            }


        }
    }
}
