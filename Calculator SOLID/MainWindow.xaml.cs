
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator_SOLID
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    
    public partial class MainWindow : Window
    {
        internal Calculator calculator = new Calculator();
        internal KeyFilter filter = new KeyFilter();
        internal ConverterToCalculation Converter = new ConverterToCalculation();
        internal Tester tester= new Tester();


        public MainWindow()
        { 
            InitializeComponent();
        }

       
        

        private void CalculationText_KeyDown(object sender, KeyEventArgs e)
        {
            if (filter.Filtration(e) == true) { e.Handled = false; } else { e.Handled = true; }
            if (filter.EnterIsActive) {
                filter.ActionIsActive = false;
                Converter.Convertation(CalculationText.Text);
                if(!Converter.SecondNumIsEmpty)
                CalculationText.Text = calculator.CharAnaliz(Converter.Action, Converter.Num1, Converter.Num2, CalculationText.Text);
                if (Converter.FirstNumIsEmpty) { Converter.FirstNumIsEmpty = false;MessageBox.Show("Error03: Числа и дейтвия не обнаруженны","Error",MessageBoxButton.OK,MessageBoxImage.Error); }
                else
                if (Converter.ActionIsEmpty) { Converter.ActionIsEmpty = false; MessageBox.Show("Error02: Дейтвие не обнаруженно", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
                else
                if (Converter.SecondNumIsEmpty) { Converter.SecondNumIsEmpty = false; MessageBox.Show("Error01: Второе число не обнаруженно", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
                filter.ActionIsActive = false;
            }

        }

        private void CalculationText_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            //Test
            CalculationText.Text = tester.TesterWork(CalculationText.Text);
            //Test
            filter.ActionIsActive=false;
            //Test
            if (!tester.TestActived)
            {
                //Test
                CalculationText.Text = "";
            }
            
        }

        private void ButtonEqually_Click(object sender, RoutedEventArgs e)
        {
            filter.ActionIsActive = false;
            Converter.Convertation(CalculationText.Text);
            
            if (!Converter.SecondNumIsEmpty) 
                CalculationText.Text = calculator.CharAnaliz(Converter.Action, Converter.Num1, Converter.Num2, CalculationText.Text);
            if (Converter.FirstNumIsEmpty) { Converter.FirstNumIsEmpty = false; MessageBox.Show("Error03: Числа и дейтвия не обнаруженны", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
            else
            if (Converter.ActionIsEmpty) { Converter.ActionIsEmpty = false; MessageBox.Show("Error02: Дейтвие не обнаруженно", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
            else
            if (Converter.SecondNumIsEmpty) { Converter.SecondNumIsEmpty = false; MessageBox.Show("Error01: Второе число не обнаруженно", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
            filter.ActionIsActive = false;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "3";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if(!filter.ActionIsActive)CalculationText.Text += "+";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "6";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if(!filter.ActionIsActive) CalculationText.Text += "-";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "9";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (!filter.ActionIsActive)
                CalculationText.Text += "/";
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += ",";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            CalculationText.Text += "0";
        }

        private void ButtonMultiplication_Click(object sender, RoutedEventArgs e)
        {
            if (!filter.ActionIsActive) CalculationText.Text += "*";
        }
    }
}
