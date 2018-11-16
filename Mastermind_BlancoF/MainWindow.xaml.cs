using Mastermind_BlancoF.Models;
using Mastermind_BlancoF.UserControls;
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

namespace Mastermind_BlancoF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        List<Peg> answerPegs = new List<Peg>();

        public int NumRows { get; set; } = 10;

        public int NumPegs { get; set; } = 4;

        public int CurrentRow { get; set; } = 0;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResetAnswer()
        {
            answerPegs.Clear();
            AnswerPanel.Children.Clear();

            for (int i = 0; i < NumPegs; i++)
            {
                Peg peg = new Peg();
                peg.Color = (Peg.Colors)random.Next(1, (int) Peg.Colors.Num_Colors);
                answerPegs.Add(peg);
            }
            PegButtonContainerControl pegContainer = new PegButtonContainerControl(answerPegs);
            AnswerPanel.Children.Add(pegContainer);

        }


        private void Reset()
        {
            SelectionPanel.Children.Clear();
            for (int i = 0; i < NumRows; i++)
            {
                List<Peg> pegs = new List<Peg>();
                for (int j = 0; j < NumPegs; j++) pegs.Add(new Peg());

                PegButtonContainerControl pegContainer = new PegButtonContainerControl(pegs);
                SelectionPanel.Children.Add(pegContainer);

            }

            HintPanel.Children.Clear();
            for (int i = 0; i < NumRows; i++)
            {
            List<Peg> pegs = new List<Peg>();
            for (int j = 0; j < NumPegs; j++) pegs.Add(new Peg());

            PegContainerControl pegContainer = new PegContainerControl(pegs);
            HintPanel.Children.Add(pegContainer);

            }
        }


        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            PegButtonContainerControl pegContainer = (PegButtonContainerControl)SelectionPanel.Children[CurrentRow];
            List<Peg> pegs = pegContainer.Pegs;
            int hintIndex = 0;
            for (int i = 0; i < pegs.Count; i++)
            {
                for (int j = 0; j < answerPegs.Count; j++)
                {
                    if (pegs[i].Color == answerPegs[j].Color)
                    {
                        PegContainerControl hintContainer = (PegContainerControl)HintPanel.Children[CurrentRow];
                        hintContainer.Pegs[hintIndex].Color = (i == j) ? Peg.CORRECT_COLOR_POSITION : Peg.CORRECT_COLOR;
                        hintIndex++;
                        break;
                    }
                }
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Reset();
            ResetAnswer();
        }

        private void VisibleButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (AnswerPanel.Visibility == Visibility.Visible)
            {
                AnswerPanel.Visibility = Visibility.Hidden;
                button.Content = "Show";
            }
            else
            {
                AnswerPanel.Visibility = Visibility.Visible;
                button.Content = "Hide";
            }
        }
    }
}
