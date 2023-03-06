using System;
using System.Collections.Generic;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);

            double count = 0;
            const int N = 10;
            double step = (x2 - x1) / N;
            double x = x1;

            while (count < N)
            {
                x = x1 + step*count;
                textBox3.Text += $"{count+1,-10}{x,-10:.00}{Calc.Func(x),-10:.00}\n";
                count++;
            }
        }
    }

    public class Calc
    {
        public static double F1(double x) => Math.Log(1 - x);
        public static double Func(double x)
        {
            double result = 0;

            double F = 0;

            try
            {
                F = F1(x);
            }
            catch
            {
                MessageBox.Show("Есть некорректный аргумент функции");
            }

            return result;
        }
    }
}
