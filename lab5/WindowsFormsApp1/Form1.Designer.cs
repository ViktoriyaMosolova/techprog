namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colX0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colX0,
            this.colXn,
            this.colNx,
            this.colY0,
            this.colNy,
            this.colHy});
            this.dataGridView1.Location = new System.Drawing.Point(62, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 162);
            this.dataGridView1.TabIndex = 10;
            // 
            // colX0
            // 
            this.colX0.HeaderText = "X0";
            this.colX0.Name = "colX0";
            // 
            // colXn
            // 
            this.colXn.HeaderText = "Xn";
            this.colXn.Name = "colXn";
            // 
            // colNx
            // 
            this.colNx.HeaderText = "Nx";
            this.colNx.Name = "colNx";
            // 
            // colY0
            // 
            this.colY0.HeaderText = "Y0";
            this.colY0.Name = "colY0";
            // 
            // colNy
            // 
            this.colNy.HeaderText = "Ny";
            this.colNy.Name = "colNy";
            // 
            // colHy
            // 
            this.colHy.HeaderText = "Hy";
            this.colHy.Name = "colHy";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(718, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить еще строку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX0;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNx;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY0;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHy;
        private System.Windows.Forms.Button button2;
    }
}

