using System.Windows.Forms;

namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.topLeftRow1 = new System.Windows.Forms.NumericUpDown();
            this.topLeftCol1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomRightCol1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bottomRightRow1 = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxchangeregistr = new System.Windows.Forms.GroupBox();
            this.groupBoxsymbol = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftRow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftCol1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightCol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightRow1)).BeginInit();
            this.groupBoxchangeregistr.SuspendLayout();
            this.groupBoxsymbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывести подматрицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // topLeftRow1
            // 
            this.topLeftRow1.Location = new System.Drawing.Point(68, 27);
            this.topLeftRow1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topLeftRow1.Name = "topLeftRow1";
            this.topLeftRow1.Size = new System.Drawing.Size(52, 20);
            this.topLeftRow1.TabIndex = 4;
            this.topLeftRow1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // topLeftCol1
            // 
            this.topLeftCol1.Location = new System.Drawing.Point(208, 27);
            this.topLeftCol1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topLeftCol1.Name = "topLeftCol1";
            this.topLeftCol1.Size = new System.Drawing.Size(52, 20);
            this.topLeftCol1.TabIndex = 5;
            this.topLeftCol1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Строка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Столбец";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.topLeftCol1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.topLeftRow1);
            this.groupBox1.Location = new System.Drawing.Point(240, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координата левого верхнего элемента подматрицы:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bottomRightCol1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bottomRightRow1);
            this.groupBox2.Location = new System.Drawing.Point(240, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 65);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Координата правого нижнего элемента подматрицы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Строка";
            // 
            // bottomRightCol1
            // 
            this.bottomRightCol1.Location = new System.Drawing.Point(208, 27);
            this.bottomRightCol1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bottomRightCol1.Name = "bottomRightCol1";
            this.bottomRightCol1.Size = new System.Drawing.Size(52, 20);
            this.bottomRightCol1.TabIndex = 5;
            this.bottomRightCol1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Столбец";
            // 
            // bottomRightRow1
            // 
            this.bottomRightRow1.Location = new System.Drawing.Point(68, 27);
            this.bottomRightRow1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bottomRightRow1.Name = "bottomRightRow1";
            this.bottomRightRow1.Size = new System.Drawing.Size(52, 20);
            this.bottomRightRow1.TabIndex = 4;
            this.bottomRightRow1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "К русским символам",
            "К латинским символам"});
            this.checkedListBox2.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(174, 49);
            this.checkedListBox2.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Верхний",
            "Нижний"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(174, 34);
            this.checkedListBox1.TabIndex = 14;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Все символы",
            "Первый символ"});
            this.checkedListBox3.Location = new System.Drawing.Point(6, 59);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(174, 34);
            this.checkedListBox3.TabIndex = 15;
            this.checkedListBox3.SelectedIndexChanged += new System.EventHandler(this.checkedListBox3_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 184);
            this.button2.TabIndex = 16;
            this.button2.Text = "Преобразовать подматрицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxchangeregistr
            // 
            this.groupBoxchangeregistr.Controls.Add(this.checkedListBox1);
            this.groupBoxchangeregistr.Controls.Add(this.checkedListBox3);
            this.groupBoxchangeregistr.Location = new System.Drawing.Point(34, 98);
            this.groupBoxchangeregistr.Name = "groupBoxchangeregistr";
            this.groupBoxchangeregistr.Size = new System.Drawing.Size(200, 100);
            this.groupBoxchangeregistr.TabIndex = 17;
            this.groupBoxchangeregistr.TabStop = false;
            this.groupBoxchangeregistr.Text = "Преобразовать в регистр:";
            // 
            // groupBoxsymbol
            // 
            this.groupBoxsymbol.Controls.Add(this.checkedListBox2);
            this.groupBoxsymbol.Location = new System.Drawing.Point(34, 204);
            this.groupBoxsymbol.Name = "groupBoxsymbol";
            this.groupBoxsymbol.Size = new System.Drawing.Size(200, 78);
            this.groupBoxsymbol.TabIndex = 18;
            this.groupBoxsymbol.TabStop = false;
            this.groupBoxsymbol.Text = "Применить к:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxsymbol);
            this.Controls.Add(this.groupBoxchangeregistr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.topLeftRow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftCol1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightCol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightRow1)).EndInit();
            this.groupBoxchangeregistr.ResumeLayout(false);
            this.groupBoxsymbol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown topLeftRow1;
        private System.Windows.Forms.NumericUpDown topLeftCol1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bottomRightCol1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown bottomRightRow1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxchangeregistr;
        private System.Windows.Forms.GroupBox groupBoxsymbol;
    }
}

