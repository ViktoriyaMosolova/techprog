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
using static System.Windows.Forms.LinkLabel;
using System.Drawing.Drawing2D;
using System.Runtime.ExceptionServices;
using System.Globalization;

/*
+1. В текстовом файле *.dat вручную разместить матрицу произвольного размера с любыми текстовыми
данными в произвольном формате. 
+2. С использованием счётчиков строк/столбцов задать допустимые размерности матрицы (но не более
фактического размера матрицы, присутствующей в заданном пользователем файле) 
+3.На пользовательской форме поместить элементы управления, отвечающие за преобразование исходных значений. 
    +a. Первая группа элементов отвечает за преобразования: 
        +i.К верхнему/нижнему регистру,
        +ii. Преобразование только первого символа каждого слова к верхнему регистру;
        +iii.Не преобразовывать(при выборе деактивирует остальные преобразователи). 
    +b.Вторая группа управляющих элементов отвечает за применимость настроек первой группы к
    строчным значениям, содержащим 
        +i. русские символы
        +ii. латинские символы,
        +iii. русские и латинские символы. 
+4. Считать из файла подматрицу заданного пользователем размера и преобразовать её в соответствии с
настройками из пп. 3a, 3b. 
+5. Выводить преобразованную матрицу в любой табличный элемент управления на отдельной вкладке
или форме по выбору пользователя.*/

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFile();
            tabPage3.Parent = null;
            listBoxRegistr.SelectedIndex = 3;
        }

        public void ReadFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\matrix.dat"))
                {
                    string[] lines = reader.ReadToEnd().Split('\n');
                    topLeftRow1.Maximum = lines.Length;
                    bottomRightRow1.Maximum = lines.Length;
                    topLeftCol1.Maximum = lines[0].Split(' ').Length;
                    bottomRightCol1.Maximum = lines[0].Split(' ').Length;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при считывании файла");
            }
        }

        string[,] subMatrix;
        public void GetSubMatrix()
        {
            try
            {
                int topLeftRow = (int)topLeftRow1.Value;
                int topLeftCol = (int)topLeftCol1.Value;
                int bottomRightRow = (int)bottomRightRow1.Value;
                int bottomRightCol = (int)bottomRightCol1.Value;

                int subRows = bottomRightRow - topLeftRow + 1;
                int subCols = bottomRightCol - topLeftCol + 1;

                subMatrix = new string[subRows, subCols];

                string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\matrix.dat").Skip(topLeftRow - 1).Take(subRows).ToArray();
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(' ').Skip(topLeftCol - 1).Take(subCols).ToArray();
                    for (int j = 0; j < row.Length; j++)
                    {
                        subMatrix[i, j] = row[j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в считывании подматрицы");
            }
        }

        Dictionary<int, Func<string, int, string>> caseOptions = new Dictionary<int, Func<string, int, string>>();
        Dictionary<int, Func<char, bool>> symbolOptions = new Dictionary<int, Func<char, bool>>();

        Func<string, int, string> caseOptionFunc;
        Func<char, bool> symbolOptionFunc;

        void InitializeOptions()
        {
            caseOptions[0] = ToUpperCase;
            caseOptions[1] = ToUpperCaseFirstLetter;
            caseOptions[2] = ToLowerCase;
            caseOptions[3] = DoNothing;

            symbolOptions[0] = IsRusLetter;
            symbolOptions[1] = IsLatLetter;
            symbolOptions[2] = IsAnyLetter;
            symbolOptions[-1] = IsAnyLetter;

            caseOptionFunc = caseOptions[listBoxRegistr.SelectedIndex];
            symbolOptionFunc = symbolOptions[listBoxSymbol.SelectedIndex];
        }

        public bool ChangeSymbols()
        {
            try
            {
                InitializeOptions();

                for (int row = 0; row < subMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < subMatrix.GetLength(1); col++)
                    {
                        string element = subMatrix[row, col];
                        string transformed = caseOptionFunc(element, listBoxRegistr.SelectedIndex);
                        subMatrix[row,col] = transformed;
                    }
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка в преобразовании");
                return false;
            }
        }

        // Определение функций преобразования регистра
        string ToUpperCase(string element, int symbolOption)
        {
            return TransformCase(element, symbolOption, char.ToUpper);
        }

        string ToUpperCaseFirstLetter(string element, int symbolOption)
        {
            string first = element.Substring(0, 1);
            string other = element.Substring(1);

            first = TransformCase(first, symbolOption, char.ToUpper);

            return first + other;
        }

        string ToLowerCase(string element, int symbolOption)
        {
            return TransformCase(element, symbolOption, char.ToLower);
        }

        string DoNothing(string element, int symbolOption)
        {
            return element;
        }

        string TransformCase(string element, int symbolOption, Func<char, char> transformFunc)
        {
            return new string(element.Select(c => symbolOptionFunc(c) ? transformFunc(c) : c).ToArray());
        }

        bool IsRusLetter(char c)
        {
            return (c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я');
        }

        bool IsLatLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        bool IsAnyLetter(char c)
        {
            return IsRusLetter(c) || IsLatLetter(c);
        }

        public DataGridView DataSubMatrix()
        {
            DataGridView subMatrixGrid = new DataGridView();
            try
            {
                DataTable dataTable = new DataTable();

                for (int j = 0; j < subMatrix.GetLength(1); j++)
                {
                    string columnName = $"Column{j + 1}";
                    dataTable.Columns.Add(columnName, typeof(string));
                }

                for (int i = 0; i < subMatrix.GetLength(0); i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int j = 0; j < subMatrix.GetLength(1); j++)
                    {
                        dataRow[j] = subMatrix[i, j];
                    }
                    dataTable.Rows.Add(dataRow);
                }

                subMatrixGrid.DataSource = dataTable;
                subMatrixGrid.Dock = DockStyle.Fill;
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return subMatrixGrid;
        }

        public void ShowSubMatrixInForm()
        {
            try
            {
                Form subForm = new Form();
                subForm.Controls.Add(DataSubMatrix());
                subForm.Height = Form1.ActiveForm.Height;
                subForm.Width = Form1.ActiveForm.Width;
                subForm.Show();
            }
            catch
            {
                MessageBox.Show("Ошибка вывода в форму");
            }
        }

        public void ShowSubMatrixInTab()
        {
            try
            {
            tabPage3.Parent = tabControl1;
            tabPage3.Controls.Clear(); 
            tabPage3.Controls.Add(DataSubMatrix());
            }
            catch
            {
                MessageBox.Show("Ошибка вывода во вкладку");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxRegistr.SelectedIndex == -1)
                {
                    listBoxRegistr.SelectedIndex = 3;
                    MessageBox.Show("Выберите регистр");
                }
                else if (listBoxRegistr.SelectedIndex != 3 && listBoxSymbol.SelectedIndex == -1)
                {
                    listBoxSymbol.SelectedIndex = 2;
                    MessageBox.Show("Выберите к каким символам применить");
                }
                else
                {
                    if (listBox1.SelectedIndex == 0)
                    {
                        GetSubMatrix();//получить выбранную подматрицу
                        if (ChangeSymbols())//если все ок с преобразователями то вывести в форму
                        {
                            ShowSubMatrixInForm();
                        }
                    }
                    else if (listBox1.SelectedIndex == 1)
                    {
                        GetSubMatrix();//получить выбранную подматрицу
                        if (ChangeSymbols())//если все ок с преобразователями то вывести во вкладку
                        {
                            ShowSubMatrixInTab();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите куда вывести подматрицу");
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void listBoxRegistr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRegistr.SelectedIndex == 3)
            {
                listBoxSymbol.ClearSelected();
            }
        }

        private void listBoxSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRegistr.SelectedIndex == 3 && listBoxSymbol.SelectedItems.Count > 0)
            {
                listBoxSymbol.ClearSelected();
                listBoxRegistr.ClearSelected();
                MessageBox.Show("Выберите регистр");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage currentTabPage = tabControl1.SelectedTab;

            if (currentTabPage != tabPage3)
            {
                tabPage3.Parent = null;
            }
        }

        private void topLeftRow1_ValueChanged(object sender, EventArgs e)
        {
            if (topLeftRow1.Value > bottomRightRow1.Value)
            {
                topLeftRow1.Value = bottomRightRow1.Value;
            }
        }

        private void bottomRightRow1_ValueChanged(object sender, EventArgs e)
        {
            if (topLeftRow1.Value > bottomRightRow1.Value)
            {
                bottomRightRow1.Value = topLeftRow1.Value;
            }
        }

        private void topLeftCol1_ValueChanged(object sender, EventArgs e)
        {
            if (topLeftCol1.Value > bottomRightCol1.Value)
            {
                topLeftCol1.Value = bottomRightCol1.Value;
            }
        }

        private void bottomRightCol1_ValueChanged(object sender, EventArgs e)
        {
            if (bottomRightCol1.Value < topLeftCol1.Value)
            {
                bottomRightCol1.Value = topLeftCol1.Value;
            }
        }
    }
}
