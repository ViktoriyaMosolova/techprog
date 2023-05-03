using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;
using System.Windows.Media.Animation;
using HelixToolkit;
using System.Windows.Media.Media3D;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot;
using DataPoint = OxyPlot.DataPoint;
using OxyPlot.WindowsForms;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using System.Configuration;



namespace WinFormsApp9
{

    public partial class Form1 : Form
    {
        readonly string file = Directory.GetCurrentDirectory() + "\\XY.txt";
        public Form1()
        {
            InitializeComponent(); 
            InitProperty();
            PlotData(ReadDataFromFile());
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        public void InitProperty()
        {

            chart1.Titles.Add("Вариант 47");
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";

            chart2.Titles.Add("Вариант 47");
            chart2.ChartAreas[0].AxisX.Title = "X";
            chart2.ChartAreas[0].AxisY.Title = "Y";

            chart3.Titles.Add("Вариант 47");
            chart3.ChartAreas[0].AxisX.Title = "X";
            chart3.ChartAreas[0].AxisY.Title = "Y";
            chart3.ChartAreas[0].AxisY2.Title = "Z";

            chart1.Update();
            chart2.Update();
            chart3.Update();
        }

        public List<List<double>> ReadDataFromFile()
        {
            List<List<double>> data = new List<List<double>>();
            try
            {
                List<double> currentSeries = null;
                comboBox1.Items.Clear();
                foreach (string line in File.ReadLines(file))
                {
                    if (line.StartsWith("#"))
                    {
                        currentSeries = new List<double>();
                        data.Add(currentSeries);
                        comboBox1.Items.Add(line);
                        comboBox1.SelectedIndex = 0;
                    }
                    else if (currentSeries != null)
                    {
                        string[] parts = line.Split('\t');
                        if (parts.Length >= 2 && double.TryParse(parts[0], out double x) && double.TryParse(parts[1], out double y))
                        {
                            currentSeries.Add(x);
                            currentSeries.Add(y);
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка при считывании данных");
            }
            return data;
        }

        public void PlotData(List<List<double>> data)
        {
            try
            {
                chart1.Series.Clear();
                chart2.Series.Clear();
                chart3.Series.Clear();

                List<double> xValues = null;
                List<double> yValues = null;

                foreach (List<double> seriesData in data)
                {
                    xValues = seriesData.Where((value, index) => index % 2 == 0).ToList();
                    yValues = seriesData.Where((value, index) => index % 2 == 1).ToList();

                    Series chartSeries1 = new Series();
                    chartSeries1.ChartType = SeriesChartType.Line;
                    chartSeries1.MarkerStyle = MarkerStyle.Circle;
                    chartSeries1.Points.DataBindXY(xValues, yValues);
                    chart1.Series.Add(chartSeries1);

                    Series chartSeries2 = new Series();
                    chartSeries2.ChartType = SeriesChartType.Column;
                    chartSeries2.Points.DataBindXY(xValues, yValues);
                    chart2.Series.Add(chartSeries2);


                    Series chartSeries3 = new Series();
                    chartSeries3.ChartType = SeriesChartType.Spline;
                    chart3.Series.Add(chartSeries3);
                    for (int i = 0; i < xValues.Count; i++)
                    {
                        double x = xValues[i];
                        double y = yValues[i];
                        chartSeries3.Points.AddXY(i, f(x, y));
                        if (checkBox1.Checked == true) {
                            chart3.ChartAreas[0].RecalculateAxesScale();
                        }
                    }
                }
                chart1.Update();
                chart2.Update();
                chart3.Update();
            }
            catch
            {
                MessageBox.Show("Ошибка при выводе графиков");
            }
        }

        double f(double x, double y)
        {
            int c = trackBar1.Value;
            return x*x + c*x*y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color selectedColor = colorDialog.Color;

                        Series selectedSeries1 = chart1.Series[comboBox1.SelectedIndex];
                        Series selectedSeries2 = chart2.Series[comboBox1.SelectedIndex];

                        if (comboBox2.SelectedIndex == 0)
                        {
                            foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in selectedSeries1.Points)
                            {
                                point.MarkerBorderColor = selectedColor;
                            }

                            chart1.Update();
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in selectedSeries2.Points)
                            {
                                point.BorderColor = selectedColor;
                            }

                            chart2.Update();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении цвета обводки маркера");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.Drawing.Color selectedColor = colorDialog.Color;

                        if (comboBox2.SelectedIndex == 0)
                        {
                            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = selectedColor;
                            chart1.Update();
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = selectedColor;
                            chart2.Update();
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            chart3.ChartAreas[0].AxisX.MajorGrid.LineColor = selectedColor;
                            chart3.Update();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении цвета оси X");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color selectedColor = colorDialog.Color;
                        Series selectedSeries1 = chart1.Series[comboBox1.SelectedIndex];
                        Series selectedSeries2 = chart2.Series[comboBox1.SelectedIndex];
                        Series selectedSeries3 = chart3.Series[comboBox1.SelectedIndex];

                        if (comboBox2.SelectedIndex == 0)
                        {
                            foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in selectedSeries1.Points)
                            {
                                point.Color = selectedColor;
                            }
                            chart1.Update();
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in selectedSeries2.Points)
                            {
                                point.Color = selectedColor;
                            }
                            chart2.Update();
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in selectedSeries3.Points)
                            {
                                point.Color = selectedColor;
                            }
                            chart3.Update();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении цвета линии данных");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = comboBox3.SelectedIndex;
                Series series = chart1.Series[comboBox1.SelectedIndex];
                switch (selected)
                {
                    case 0:
                        series.BorderDashStyle = ChartDashStyle.Solid;
                        break;
                    case 1:
                        series.BorderDashStyle = ChartDashStyle.Dash;
                        break;
                    case 2:
                        series.BorderDashStyle = ChartDashStyle.Dot;
                        break;
                    case 3:
                        series.BorderDashStyle = ChartDashStyle.DashDot;
                        break;
                    case 4:
                        series.BorderDashStyle = ChartDashStyle.DashDotDot;
                        break;
                    default:
                        series.BorderDashStyle = ChartDashStyle.Solid;
                        break;
                }
                chart1.Update();
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении цвета обводки маркера");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color selectedColor = colorDialog.Color;

                        if (comboBox2.SelectedIndex == 0)
                        {
                            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = selectedColor;
                            chart1.Update();
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = selectedColor;
                            chart2.Update();
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = selectedColor;
                            chart3.Update();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении цвета оси Y");
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PlotData(ReadDataFromFile());
            chart3.Titles.Clear();
            chart3.Titles.Add("f(x,y)=x^2+c*y*x     c(const) = " + trackBar1.Value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PlotData(ReadDataFromFile());
        }
    }
}
