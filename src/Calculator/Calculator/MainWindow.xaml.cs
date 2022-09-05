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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;

        public MainWindow()
        {
            InitializeComponent();

            acButton.Click += ClearResult_Button;
            negativeButton.Click += NegativeConvert_Button;
            percentageButton.Click += PercentageCalculate_Button;
            equalButton.Click += equal_Button;
        }

        private void equal_Button(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PercentageCalculate_Button(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ResultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber /= 100;
                ResultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegativeConvert_Button(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(ResultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber *= -1;
                ResultLabel.Content = lastNumber.ToString();
            }
        }

        private void ClearResult_Button(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "0";
        }

        private void NumberEvent_Button(object sender, RoutedEventArgs e)
        {
            var content = (sender as Button).Content;
            if(ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = content as string;
            }
            else
            {
                ResultLabel.Content += content as string;

            }
        }
    }
}
