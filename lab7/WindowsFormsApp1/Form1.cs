using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите функцию");
            }
            else
            {
                textBox1.Text = $"{"x\\y",-10}";

                double X0 = ((double)numericUpDown1.Value);
                double Xn = ((double)numericUpDown2.Value);
                double Hx = ((double)numericUpDown3.Value);
                double x = X0;
                //Nx=

                double Y0 = ((double)numericUpDown6.Value);
                double Yn = ((double)numericUpDown5.Value);
                double Hy = ((double)numericUpDown4.Value);
                double y = Y0;

                for (int j = 1; y <= Yn; y = Y0 + j * Hy, j++)
                { 
                    textBox1.AppendText($"{y,10}");
                }
                textBox1.AppendText(Environment.NewLine);
                for (int i = 1; x <= Xn; x = X0 + i * Hx, i++)
                {
                    textBox1.AppendText($"{x,10:0.00}");
                    y = Y0;
                    for (int j = 1; y <= Yn; y = Y0 + j * Hy, j++)
                    {
                        textBox1.AppendText($"{y*Func(x),10:0.00}");
                    }
                    textBox1.AppendText(Environment.NewLine);
                }
            }
        }
        public double Func(double x)
        {
                double result = 0;
                if (checkedListBox1.GetItemChecked(0))
                {
                    result += Math.Sin(x);
                }
                else if (checkedListBox1.GetItemChecked(1))
                {
                    result += Math.Cos(x) ;
                }
                else if (checkedListBox1.GetItemChecked(2))
                {
                    result += Math.Exp(x);
                }
                else if (checkedListBox1.GetItemChecked(3))
                {
                    result += Math.Tan(x);
                }
                else if (checkedListBox1.GetItemChecked(4))
                {
                    result += Math.Log(x);
                }
                else if (checkedListBox1.GetItemChecked(5))
                {
                    result += Math.Log10(x);
                }
                return result; 
        }
    }
}
