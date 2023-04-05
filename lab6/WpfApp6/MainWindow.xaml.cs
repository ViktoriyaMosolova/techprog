using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FileHandle a = new FileHandle();
            Calc b = new Calc();
            listBox1.Items.Add(a.ReadFile(@"C:\Users\1\Desktop\techprog\lab6\input.txt"));
            string k = b.c();
            a.WriteToFile(@"C:\Users\1\Desktop\techprog\lab6\output.txt", k);
            listBox1.Items.Add(k);
        }
    }

    public class Calc
    {
        public string c()
        {
            string a = "";
            for (int i = 7; i < 10; i++)
            {
                for (int j = 7; j < 10; j++)
                {
                    a += func(i, j).ToString() + "\n";
                }
            }
            return a;
        }
        public double func(double x, double y)
        {
            return x / Math.Log(y, 3);
        }
    }
    public class ListItems
    {
        public double x = 0;
        public double y = 0;

        public ListItems(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{x,20:0.00}{y,20:0.00}";
        }
    }

    public class FileHandle
    {
        public void WriteToFile(string path, string text)
        {
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                fstream.Write(buffer, 0, buffer.Length);
            }
        }
        public string ReadFile(string path)
        {
            string textFromFile = "";
            using (FileStream fstream = File.OpenRead(path))
            {
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);
                textFromFile = Encoding.Default.GetString(buffer);
            }
            /*List<ListItems> a = new List<ListItems>();
            using (StreamReader sr = new StreamReader(path))
            {
                double[] k = {0,0};
                string numbers = sr.ReadLine();
                foreach (var number in numbers.Split())
                {
                    k = 
                    
                }
                a.Add(new ListItems(number, number));
            }*/
            return textFromFile;
        }
    }
}
