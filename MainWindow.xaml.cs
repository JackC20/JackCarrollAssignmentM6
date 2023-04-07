using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace JackCarrollAssignmentM6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string number1 = "";
        static string number2 = "";
        static string number3 = ""; 
        static string operate = "";
        static bool justHitEquals = false; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void updateText()
        {
            calc.Text = number1;
        }

        private void addNum(Object sender, RoutedEventArgs e)
        {
            
            if (justHitEquals)
            {
                number1 = ""; 
            }


            var senderBtn = sender as Button;
            number1 = number1 + senderBtn.Content.ToString();
            updateText();



        }

        private void operation(Object sender, RoutedEventArgs e)
        {
            justHitEquals = false; 
            var senderBtn = sender as Button;
            operate = senderBtn.Content.ToString();
            number2 = number1;
            number1 = "";
            updateText();

        }

        private void negative(Object sender, RoutedEventArgs e)
        {

            if (justHitEquals)
            {
                number1 = "";
                justHitEquals = false;
            }

            if (!number1.Contains("-"))
            {
                number1 = "-" + number1;
            }

            else
            {
                number1 = number1.Replace("-", "");
            }

            updateText(); 
            

            

        }

        private void equals(Object sender, RoutedEventArgs e)
        {
            if (number1 != "" && number2 != "" && number2 != "-" && number1 != "-")
            {


                double num3 = 0;
                double num1 = double.Parse(number2);
                double num2 = double.Parse(number1);

                if (operate.Equals("+"))
                {
                    num3 = num1 + num2;


                }

                else if (operate.Equals("-"))
                {
                    num3 = num1 - num2;


                }

                else if (operate.Equals("*"))
                {
                    num3 = num1 * num2;


                }

                else if (operate.Equals("/"))
                {
                    num3 = num1 / num2;


                }

                else if (operate.Equals("^"))
                {
                    num3 = Math.Pow(num1, num2);


                }

                number1 = num3.ToString();
                updateText();
                justHitEquals = true;
                number2 = "";

            }
        }

        private void clear(Object sender, RoutedEventArgs e)
        {
            number1 = "";
            number2 = ""; 
            operate = "";
            updateText();
            justHitEquals = false;
        }
        
    }
}
