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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBoxchangeregistr.Visible = false;
            groupBoxsymbol.Visible = false;
            ReadFile();
            topLeftRow1.Maximum = bottomRightRow1.Maximum = matrix.GetLength(0);
            topLeftCol1.Maximum = bottomRightCol1.Maximum = matrix.GetLength(1);
        }
        string[,] matrix;
        public void ReadFile()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\1\Desktop\matrix.txt");
            matrix = new string[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] row = lines[i].Split(' ');
                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
        }

        public void GetMatrixAndShowNewWin()
        {
            int topLeftRow = (int)topLeftRow1.Value;
            int topLeftCol = (int)topLeftCol1.Value;
            int bottomRightRow = (int)bottomRightRow1.Value;
            int bottomRightCol = (int)bottomRightCol1.Value;

            int subRows = bottomRightRow - topLeftRow + 1;
            int subCols = bottomRightCol - topLeftCol + 1;

            string[,] subMatrix = new string[subRows, subCols];

            for (int i = 0; i < subMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < subMatrix.GetLength(1); j++)
                {
                    subMatrix[i, j] = matrix[topLeftRow + i, topLeftCol + j];
                }
            }

            Form subForm = new Form();

            DataTable dataTable = new DataTable();

            DataGridView subMatrixGrid = new DataGridView();
            subMatrixGrid.Dock = DockStyle.Fill;
            
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

            subForm.Controls.Add(subMatrixGrid);

            subForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxchangeregistr.Visible = false;
            groupBoxsymbol.Visible = false;
            GetMatrixAndShowNewWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxchangeregistr.Visible = true;
            groupBoxsymbol.Visible = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0))
            {
                checkedListBox1.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (checkedListBox1.GetItemChecked(1))
            {
                checkedListBox1.SetItemCheckState(1, CheckState.Unchecked);
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox3.GetItemChecked(0))
            {
                checkedListBox3.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (checkedListBox3.GetItemChecked(1))
            {
                checkedListBox3.SetItemCheckState(1, CheckState.Unchecked);
            }
        }
    }
}
