using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            textBox3.Text = "";
            try
            {
                double x1 = Convert.ToDouble(textBox1.Text);
                double x2 = Convert.ToDouble(textBox2.Text);
                /////////////надо эту хуйню вынести из try-------------------
                List<double> result = Calc.Result(x1, x2);

                const int N = 999;
                double step = (x2 - x1) / N;
                double x = 0;

                for (int i = 0; i < result.Count-1; i++)
                {
                    x = x1 + step * i;
                    textBox3.Text += $"   {i + 1,-5}   {x,-10:0.00}";
                    textBox3.Text += $"{result[i],-20:0.00}\n";
                }
                MessageBox.Show($"Ошибок: {result[result.Count - 1]}");
                /////////////------------------------------------------------
            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }

    public class Calc
    {
        public static double F1(double x)
        {
            return Math.Log(1 - x);
        }
        public static double F2(double x)
        {
            return Math.Exp((1 / Math.Pow(x, 3)) + 9) - Math.Exp(-((1 / Math.Pow(x, 3)) + 9)) / 2;
        }
        public static double F3(double x)
        {
            return Math.Exp(Math.Cos(x / (1 - x)));
        }
        public static double F4(double x)
        {
            double f4 = 0;
            int j = 0;
            while (j < 1000)
            {
                f4 += 1 / (x + Math.Sqrt(j));
                j++;
                if (Double.IsInfinity(f4) || Double.IsNaN(f4))
                {
                    break;
                }
            }
            return f4;
        }

        public delegate double Functions(double x); 

        public static List<double> Result(double x1, double x2)
        {
            double F = 0;
            var result = new List<double>();

            var methods = new Functions[4] { F1, F2, F3, F4 };

            const int N = 999;
            int count = 0;
            double step = (x2 - x1) / N;
            double x = x1;

            int count_error = 0;
            int flag = 0;
            int index = 0;

            while (count <= N)
            {
                x = x1 + step * count;
                F = index = flag = 0;

                while (index < methods.Length)
                {
                    try
                    {
                        F += methods[index](x);
                    }
                    catch
                    {
                        flag = 1; break;
                    }
                    if (Double.IsInfinity(F) || Double.IsNaN(F)) { flag = 1; break; }
                    index++;
                }
                result.Add(F);
                count++;
                if (flag == 1) { count_error++; continue; };
            }
            result.Add(count_error);
            return result;
        }
    }
}
