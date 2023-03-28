using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class XY
    {
        double X,Y,F;
        int flag;
        public XY(double x, double y, double f, int flag, double X0, double Xn, double Nx, double Y0, double Ny, double Hy)
        {
            this.X = x;
            this.Y = y;
            this.F = f;

            this.flag = flag;
            this.X0 = X0;
            this.Xn = Xn;
            this.Nx = Nx;
            this.Y0 = Y0;
            this.Ny = Ny;
            this.Hy = Hy;
        }
        double X0, Xn, Nx;
        double Y0, Ny, Hy;
        public override string ToString()
        {
            string output = $"X: {X:0.00} ";
            output += $"Y: {Y:0.00} ";
            output += $"G: {F:0.00} ";
            return output;
        }
        public bool FO()
        {
            if (flag == 1) return true;
            else return false;
        }
        public string ToStringXY()
        {
            string output = $"X0: {X0:0.00} Xn: {Xn:0.00} Nx: {Nx:0.00}\n";
            output += $"Y0: {Y0:0.00} Ny: {Ny:0.00} Hy: {Hy:0.00} ";
            return output;
        }

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Proverka())
                {
                    ReadGrid();
                }
                string path = Directory.GetCurrentDirectory() + "\\MyProgram.txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    int k = 0;
                    for (int i = 0; i < ArrayNodes.Count; i++)
                    {
                        if (ArrayNodes[i].FO())
                        {
                            k++;
                            sw.Write($"Набор - {k}\n{ArrayNodes[i].ToStringXY()}" + Environment.NewLine);
                        }
                        else
                        {
                            sw.Write($"{ArrayNodes[i].ToString(),-10}" + Environment.NewLine);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("что то пошло не так......");
            }

        }
        List<XY> ArrayNodes = new List<XY>();
        public void ReadGrid()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double X0 = Convert.ToDouble(dataGridView1[0, i].Value);
                double Xn = Convert.ToDouble(dataGridView1[1, i].Value);
                double Nx = Convert.ToDouble(dataGridView1[2, i].Value);

                double Y0 = Convert.ToDouble(dataGridView1[3, i].Value);
                double Ny = Convert.ToDouble(dataGridView1[4, i].Value);
                double Hy = Convert.ToDouble(dataGridView1[5, i].Value);
                ArrayNodes.Add(new XY(0, 0, 0, 1, X0, Xn, Nx, Y0, Ny, Hy));
                for (int j = 0; j < Nx; j++)
                {
                    for (int k = 0; k < Ny; k++)
                    {
                        double Hx = (Xn - X0) / Nx;
                        double x = X0 + Hx * j;
                        double y = Y0 + Hy * k;
                        ArrayNodes.Add(new XY(x,y,G(x, y), 0, 0, 0, 0, 0, 0, 0));
                    }
                }
            }
        }
        public bool Proverka()
        {
            bool flag = true;
            for(int i = 0; i< dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1[j, i].Value == null)
                    {
                        flag = false;
                        MessageBox.Show("пусто!!!!!!!!!!!!");
                        return flag;
                    }
                }
            }
            return flag;
        }
        public double G(double x, double y)
        {
            double result;
            try
            {
                result = x / Math.Abs(Math.Log(y, 3));
            }
            catch
            {
                result = Double.NaN;
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
    }

}
