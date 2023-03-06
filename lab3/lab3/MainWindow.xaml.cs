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
using System.Xml;

namespace lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<double> rez = Calc.С();
            for (var i = 0; i<rez.Count; i++)
            {
                Text.Text += $"{rez[i]}\n";
            }
        }
    }

    public class Calc
    {
        public static List<double> С()
        {
            double f1, f2, f3, f4, F = 0;
            double x = -2;
            int count = 0;
            bool flag = true;
            var result = new List<double>();
            while (count <= 10)
            {
                try
                {
                    f1 = Math.Log(1 - x);
                    f2 = Math.Exp((1 / Math.Pow(x, 3)) + 9) - Math.Exp(-((1 / Math.Pow(x, 3)) + 9)) / 2;
                    f3 = Math.Exp(Math.Cos(x / (1 - x)));
                    f4 = 0;
                    int j = 1;
                    while (j <= 10)
                    {
                        f4 += 1 / (x + Math.Sqrt(j));
                        j++;
                    }
                    F = f1 + f2 + f3 + f4;

                    count++;
                    x += 0.01;
                    result.Add(F);
                }
                catch
                {
                    if (flag)
                    {
                        MessageBox.Show("Есть некорректный аргумент функции");
                        flag = false;
                    }
                }
                if (double.IsNaN(F))
                {
                     MessageBox.Show("Есть некорректный аргумент функции");
                     flag = false;
                }
            }
            return result;
        }

    }
}
