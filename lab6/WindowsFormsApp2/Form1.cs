using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
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
                    int k = 0;
                    for (int i = 0; i < ((int)dataGridView1.RowCount); i++)
                    {
                        string path = Directory.GetCurrentDirectory() + $"\\G{i + 1:000}.txt";
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            sw.Write($"Набор - {i + 1}\n{ArrayNodes[k].ToStringXY()}" + Environment.NewLine);
                            k++;
                            while (ArrayNodes[k].FO() == false)
                            {
                                sw.Write($"{ArrayNodes[k].ToString(),-10}" + Environment.NewLine);
                                k++;
                                if (k == ArrayNodes.Count) break;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("что то пошло не так......");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
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
                        ArrayNodes.Add(new XY(x, y, G(x, y), 0, 0, 0, 0, 0, 0, 0));
                    }
                }
            }
        }
        public bool Proverka()
        {
            bool flag = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
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
            double result = 0;
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
        List<double[]> rez = new List<double[]>();
        public void ReadFileRez()
        {
            try
            {
                rez.Clear();
                string[] coordinates = textBox2.Text.ToString().Split(' ');
                string[] NumDat = textBox3.Text.ToString().Split(' ');
                listBox1.Items.Clear();
                textBox2.Clear();
                textBox3.Clear();
                for (int i = 0; i < NumDat.Length; i++)
                {
                    using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + $"\\G{Convert.ToInt32(NumDat[i]):000}.txt"))
                    {
                        string line;
                        for (int k = 0; k < coordinates.Length - 1; k += 2)
                        {
                            int x = Convert.ToInt32(coordinates[k]);
                            int y = Convert.ToInt32(coordinates[k + 1]);

                            for (int m = 0; m < 3; m++) reader.ReadLine();
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] values = line.Split(' ');

                                if (double.Parse(values[0]) == x && double.Parse(values[1]) == y)
                                {
                                    double[] res = { Convert.ToInt32(NumDat[i]), x, y, 1, Convert.ToDouble(values[2]) };
                                    rez.Add(res);
                                    break;
                                }
                                else
                                {
                                    double[] res = { Convert.ToInt32(NumDat[i]), x, y, 0 };
                                    rez.Add(res);
                                }
                            }

                            reader.BaseStream.Seek(0, SeekOrigin.Begin);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введено что-то не то((");
            }
        }
        public void OutputRez()
        {
            for (int i = 0; i < rez.Count; i++)
            {
                string line = "";
                line += $"{rez[i][0],-15}";
                line += $"({rez[i][1], 3},{rez[i][2],3})";
                if (rez[i][3] == 1) line += $"{rez[i][4],10}";
                if (rez[i][3] == 0) line += $"{"нет", 10}";
                listBox1.Items.Add(line);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ReadFileRez();
            OutputRez();
        }
    }
    public class XY
        {
            double X, Y, F;
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
                string output = $"{X:0.00} ";
                output += $"{Y:0.00} ";
                output += $"{F:0.00} ";
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
}
