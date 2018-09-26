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
using ModularCalculator.ViewModel;

namespace ModularCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorViewModel CVM;
        
        public MainWindow()
        {
            InitializeComponent();

            CVM = (CalculatorViewModel)base.DataContext;
        }

        void SetViewModel(string value)
        {
            CVM.screenNumber = double.Parse(value);
        }

        #region Function keys


        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            CVM.ClearAll();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            CVM.Plus();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            CVM.Minus();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            CVM.Multiply();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            CVM.Divide();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            CVM.Calculate();
        }

        #endregion


        #region Numeric keys

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("1");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("2");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("3");
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("4");
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("5");
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("6");
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("7");
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("8");
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("9");
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel("0");
        }

        #endregion
    }
}
