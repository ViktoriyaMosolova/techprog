using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Res = new List<string>();
        public void Calc()
        {
            double X0 = ((double)numericUpDown1.Value);
            double Xn = ((double)numericUpDown2.Value);
            double Hx = ((double)numericUpDown3.Value);
            double x = X0;
            double Nx = (Xn - X0) / Hx;

            double Y0 = ((double)numericUpDown6.Value);
            double Yn = ((double)numericUpDown5.Value);
            double Hy = ((double)numericUpDown4.Value);
            double y = Y0;
            double Ny = (Yn - Y0) / Hy;

            string textresfile = "";
            textresfile += string.Format("{0, -10}", "x\\y");
            for (int i = 1; i <= Ny + 1; y = Y0 + i * Hy, i++)
            {
                textresfile += string.Format("{0, -10}", y);
            }
            textresfile += Environment.NewLine;
            for (int i = 1; i <= Nx + 1; x = X0 + i * Hx, i++)
            {
                textresfile += string.Format("{0, -10}", x);
                y = Y0;
                for (int j = 1; j <= Ny + 1; y = Y0 + j * Hy, j++)
                {
                    if (Math.Round(y * Func(x), 2).ToString().Length > 5)
                    {
                        textresfile += string.Format("{0, -10}", (y * Func(x)).ToString("0.00E+0"));
                    }
                    else
                    {
                        textresfile += string.Format("{0, -10}", Math.Round(y * Func(x), 2).ToString());
                    }
                }
                textresfile += Environment.NewLine;
            }
            Res.Add(textresfile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите функцию");
            }
            else
            {
                textBox1.Clear();
                Calc();
                textBox1.Text = (Res[Res.Count - 1]);
            }
        }
        public double Func(double x)
        {
                double result = 0;
                if (checkedListBox1.GetItemChecked(0))
                {
                    result += Math.Sin(x);
                }
                if (checkedListBox1.GetItemChecked(1))
                {
                    result += Math.Cos(x) ;
                }
                if (checkedListBox1.GetItemChecked(2))
                {
                    result += Math.Exp(x);
                }
                if (checkedListBox1.GetItemChecked(3))
                {
                    result += Math.Tan(x);
                }
                if (checkedListBox1.GetItemChecked(4))
                {
                    result += Math.Log(x);
                }
                if (checkedListBox1.GetItemChecked(5))
                {
                    result += Math.Log10(x);
                }
                return result; 
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string resourcesFolder = Application.StartupPath + "\\Resources\\";
            string[] imagePaths = { resourcesFolder + "sin.jpg",
                                    resourcesFolder + "cos.jpg",
                                    resourcesFolder + "exp.jpg",
                                    resourcesFolder + "tan.jpg",
                                    resourcesFolder + "ln.jpg",
                                    resourcesFolder + "lg.jpg" };

            if (checkedListBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile(imagePaths[0]);
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile(imagePaths[1]);
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile(imagePaths[2]);
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile(imagePaths[3]);
            }
            else if (checkedListBox1.SelectedIndex == 4)
            {
                pictureBox1.Image = Image.FromFile(imagePaths[4]);
            }
            else if (checkedListBox1.SelectedIndex == 5)
            {
                pictureBox1.Image = Image.FromFile(imagePaths[5]);
            }

        }

        private void button2_Click(object sender, EventArgs e)//перезапись
        {
            textBox1.Clear();
            Res.Clear();
            Calc();
            string fileoutput = Application.StartupPath + "\\OutputRes\\result.txt";
            using (StreamWriter writer = new StreamWriter(fileoutput, false))
            {
                writer.WriteLine(Res[Res.Count - 1]);
            }
            MessageBox.Show("Значения в файле перезаписаны");
        }

        private void button4_Click(object sender, EventArgs e)//дописать
        {
            textBox1.Clear();
            Calc();
            string fileoutput = Application.StartupPath + "\\OutputRes\\result.txt";
            using (StreamWriter writer = new StreamWriter(fileoutput, true))
            {
                writer.WriteLine(Res[Res.Count - 1]);
            }
            MessageBox.Show("Значения в файле дописаны");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
