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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxsymbol = new System.Windows.Forms.GroupBox();
            this.listBoxSymbol = new System.Windows.Forms.ListBox();
            this.groupBoxchangeregistr = new System.Windows.Forms.GroupBox();
            this.listBoxRegistr = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topLeftCol1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.topLeftRow1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomRightCol1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bottomRightRow1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.groupBoxsymbol.SuspendLayout();
            this.groupBoxchangeregistr.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftCol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftRow1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightCol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightRow1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.groupBoxsymbol);
            this.tabPage2.Controls.Add(this.groupBoxchangeregistr);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1364, 807);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // groupBoxsymbol
            // 
            this.groupBoxsymbol.Controls.Add(this.listBoxSymbol);
            this.groupBoxsymbol.Location = new System.Drawing.Point(726, 170);
            this.groupBoxsymbol.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxsymbol.Name = "groupBoxsymbol";
            this.groupBoxsymbol.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxsymbol.Size = new System.Drawing.Size(400, 192);
            this.groupBoxsymbol.TabIndex = 18;
            this.groupBoxsymbol.TabStop = false;
            this.groupBoxsymbol.Text = "Применить:";
            // 
            // listBoxSymbol
            // 
            this.listBoxSymbol.FormattingEnabled = true;
            this.listBoxSymbol.ItemHeight = 25;
            this.listBoxSymbol.Items.AddRange(new object[] {
            "К русским символам",
            "К латинским символам",
            "Ко всем"});
            this.listBoxSymbol.Location = new System.Drawing.Point(9, 37);
            this.listBoxSymbol.Name = "listBoxSymbol";
            this.listBoxSymbol.Size = new System.Drawing.Size(374, 129);
            this.listBoxSymbol.TabIndex = 20;
            this.listBoxSymbol.SelectedIndexChanged += new System.EventHandler(this.listBoxSymbol_SelectedIndexChanged);
            // 
            // groupBoxchangeregistr
            // 
            this.groupBoxchangeregistr.Controls.Add(this.listBoxRegistr);
            this.groupBoxchangeregistr.Location = new System.Drawing.Point(256, 170);
            this.groupBoxchangeregistr.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxchangeregistr.Name = "groupBoxchangeregistr";
            this.groupBoxchangeregistr.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxchangeregistr.Size = new System.Drawing.Size(448, 192);
            this.groupBoxchangeregistr.TabIndex = 17;
            this.groupBoxchangeregistr.TabStop = false;
            this.groupBoxchangeregistr.Text = "Преобразовать в регистр:";
            // 
            // listBoxRegistr
            // 
            this.listBoxRegistr.FormattingEnabled = true;
            this.listBoxRegistr.ItemHeight = 25;
            this.listBoxRegistr.Items.AddRange(new object[] {
            "Верхний",
            "Верхний(только 1 символ)",
            "Нижний",
            "Не преобразовывать"});
            this.listBoxRegistr.Location = new System.Drawing.Point(30, 37);
            this.listBoxRegistr.Name = "listBoxRegistr";
            this.listBoxRegistr.Size = new System.Drawing.Size(374, 129);
            this.listBoxRegistr.TabIndex = 19;
            this.listBoxRegistr.SelectedIndexChanged += new System.EventHandler(this.listBoxRegistr_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1364, 807);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выбор подматрицы";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "в форму",
            "во вкладку"});
            this.listBox1.Location = new System.Drawing.Point(669, 444);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 54);
            this.listBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.topLeftCol1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.topLeftRow1);
            this.groupBox1.Location = new System.Drawing.Point(348, 161);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(608, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координата левого верхнего элемента подматрицы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Строка";
            // 
            // topLeftCol1
            // 
            this.topLeftCol1.Location = new System.Drawing.Point(416, 52);
            this.topLeftCol1.Margin = new System.Windows.Forms.Padding(6);
            this.topLeftCol1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topLeftCol1.Name = "topLeftCol1";
            this.topLeftCol1.Size = new System.Drawing.Size(104, 31);
            this.topLeftCol1.TabIndex = 5;
            this.topLeftCol1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topLeftCol1.ValueChanged += new System.EventHandler(this.topLeftCol1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Столбец";
            // 
            // topLeftRow1
            // 
            this.topLeftRow1.Location = new System.Drawing.Point(136, 52);
            this.topLeftRow1.Margin = new System.Windows.Forms.Padding(6);
            this.topLeftRow1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topLeftRow1.Name = "topLeftRow1";
            this.topLeftRow1.Size = new System.Drawing.Size(104, 31);
            this.topLeftRow1.TabIndex = 4;
            this.topLeftRow1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topLeftRow1.ValueChanged += new System.EventHandler(this.topLeftRow1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bottomRightCol1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bottomRightRow1);
            this.groupBox2.Location = new System.Drawing.Point(348, 298);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(608, 125);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Координата правого нижнего элемента подматрицы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Строка";
            // 
            // bottomRightCol1
            // 
            this.bottomRightCol1.Location = new System.Drawing.Point(416, 52);
            this.bottomRightCol1.Margin = new System.Windows.Forms.Padding(6);
            this.bottomRightCol1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bottomRightCol1.Name = "bottomRightCol1";
            this.bottomRightCol1.Size = new System.Drawing.Size(104, 31);
            this.bottomRightCol1.TabIndex = 5;
            this.bottomRightCol1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.bottomRightCol1.ValueChanged += new System.EventHandler(this.bottomRightCol1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Столбец";
            // 
            // bottomRightRow1
            // 
            this.bottomRightRow1.Location = new System.Drawing.Point(136, 52);
            this.bottomRightRow1.Margin = new System.Windows.Forms.Padding(6);
            this.bottomRightRow1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bottomRightRow1.Name = "bottomRightRow1";
            this.bottomRightRow1.Size = new System.Drawing.Size(104, 31);
            this.bottomRightRow1.TabIndex = 4;
            this.bottomRightRow1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.bottomRightRow1.ValueChanged += new System.EventHandler(this.bottomRightRow1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывести:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1380, 854);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1364, 807);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вывод подматрицы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1379, 865);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.groupBoxsymbol.ResumeLayout(false);
            this.groupBoxchangeregistr.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftCol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftRow1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightCol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightRow1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBoxsymbol;
        private ListBox listBoxSymbol;
        private GroupBox groupBoxchangeregistr;
        private ListBox listBoxRegistr;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown topLeftCol1;
        private Label label3;
        private NumericUpDown topLeftRow1;
        private GroupBox groupBox2;
        private Label label1;
        private NumericUpDown bottomRightCol1;
        private Label label4;
        private NumericUpDown bottomRightRow1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage3;
    }
}

