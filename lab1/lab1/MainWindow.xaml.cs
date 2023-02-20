using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Xceed.Wpf.AvalonDock.Layout;

namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            Calc a = new Calc();
            a.calc();
        }

        private void mouse(object sender, MouseEventArgs e)
        {
            lblCursorPosition.Text = "Мяу";
        }

        private void mouseleave(object sender, MouseEventArgs e)
        {
            lblCursorPosition.Text = "Мур";
        }

        private void mousemove(object sender, MouseEventArgs e)
        {
             lblCursorPosition.Text = "";
        }

        private void mouseup(object sender, MouseButtonEventArgs e)
        {
            count++;
            lblCursorPosition.Text = "Тык";
        }

        private void changecolor(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            lblCursorPosition.Text = "Изменен выбранный цвет";
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            lblCursorPosition.Text = "Клац";
        }

        private void completed(object sender, DragCompletedEventArgs e)
        {
            lblCursorPosition.Text = "Котик наигрался и спит";
        }

        private void delta(object sender, DragDeltaEventArgs e)
        {
            lblCursorPosition.Text = "Котик играеца";
        }
    }
    public class Calc
    {
        bool flag = false;
        const decimal value = 9876;
        decimal[] array = { 147, 258, 369 };
        public enum Operation : int //не может быть нецелочисленным, поэтому заменила
        {
            Add = 1,
            Sub = 2,
            Mul = 3,
            Div = 4,
        };
        public void calc()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Do_oper(array[i], value, Operation.Add);
                Do_oper(array[i], value, Operation.Sub);
                Do_oper(array[i], value, Operation.Mul);
                Do_oper(array[i], value, Operation.Div);
            }
        }

        public void Do_oper(decimal x, decimal y, Operation oper)
        {
            flag = false;
            decimal result = 0;
            char c = ' ';
            switch (oper)
            {
                case Operation.Add:
                    result = x + y;
                    c = '+';
                    break;
                case Operation.Sub:
                    result = x - y;
                    c = '-';
                    break;
                case Operation.Mul:
                    result = x * y;
                    c = '*';
                    break;
                case Operation.Div:
                    result = x / y;
                    c = '/';
                    break;
                default:
                    break;
            }
            if (result % 2 == 0)
            {
                flag = true;
            }
            Console.WriteLine("{0} {3} {1} = {2}",x, y ,result, c);
            Console.WriteLine("число четное: {0}\n",flag);
        }
    }
}
