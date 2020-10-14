namespace matrix_calculator
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
            this.A = new System.Windows.Forms.DataGridView();
            this.B = new System.Windows.Forms.DataGridView();
            this.RES = new System.Windows.Forms.DataGridView();
            this.addition = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.AmultByNumb = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.transpositionA = new System.Windows.Forms.Button();
            this.inverseA = new System.Windows.Forms.Button();
            this.determinantA = new System.Windows.Forms.Button();
            this.BmultByNumb = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.determinantB = new System.Windows.Forms.Button();
            this.inverseB = new System.Windows.Forms.Button();
            this.transposeB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ars_ud = new System.Windows.Forms.NumericUpDown();
            this.acs_ud = new System.Windows.Forms.NumericUpDown();
            this.bcs_ud = new System.Windows.Forms.NumericUpDown();
            this.brs_ud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Swap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ars_ud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acs_ud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcs_ud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brs_ud)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.AllowUserToAddRows = false;
            this.A.AllowUserToDeleteRows = false;
            this.A.AllowUserToResizeColumns = false;
            this.A.AllowUserToResizeRows = false;
            this.A.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.A.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A.ColumnHeadersVisible = false;
            this.A.Location = new System.Drawing.Point(12, 12);
            this.A.Name = "A";
            this.A.RowHeadersVisible = false;
            this.A.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.A.Size = new System.Drawing.Size(269, 170);
            this.A.TabIndex = 0;
            this.A.TabStop = false;
            // 
            // B
            // 
            this.B.AllowUserToAddRows = false;
            this.B.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B.ColumnHeadersVisible = false;
            this.B.Location = new System.Drawing.Point(456, 12);
            this.B.Name = "B";
            this.B.RowHeadersVisible = false;
            this.B.Size = new System.Drawing.Size(263, 170);
            this.B.TabIndex = 1;
            // 
            // RES
            // 
            this.RES.AllowUserToAddRows = false;
            this.RES.AllowUserToDeleteRows = false;
            this.RES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RES.ColumnHeadersVisible = false;
            this.RES.Location = new System.Drawing.Point(204, 188);
            this.RES.Name = "RES";
            this.RES.RowHeadersVisible = false;
            this.RES.Size = new System.Drawing.Size(321, 179);
            this.RES.TabIndex = 2;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(287, 32);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(163, 23);
            this.addition.TabIndex = 3;
            this.addition.Text = "Сложение";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(287, 61);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(163, 23);
            this.substraction.TabIndex = 4;
            this.substraction.Text = "Разность";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.substraction_Click);
            // 
            // AmultByNumb
            // 
            this.AmultByNumb.Location = new System.Drawing.Point(12, 304);
            this.AmultByNumb.Name = "AmultByNumb";
            this.AmultByNumb.Size = new System.Drawing.Size(115, 23);
            this.AmultByNumb.TabIndex = 5;
            this.AmultByNumb.Text = "Умножить на:";
            this.AmultByNumb.UseVisualStyleBackColor = true;
            this.AmultByNumb.Click += new System.EventHandler(this.AmultByNumb_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(287, 90);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(163, 23);
            this.multiplication.TabIndex = 7;
            this.multiplication.Text = "Умножить ";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // transpositionA
            // 
            this.transpositionA.Location = new System.Drawing.Point(12, 217);
            this.transpositionA.Name = "transpositionA";
            this.transpositionA.Size = new System.Drawing.Size(115, 23);
            this.transpositionA.TabIndex = 8;
            this.transpositionA.Text = "Транспонировать";
            this.transpositionA.UseVisualStyleBackColor = true;
            this.transpositionA.Click += new System.EventHandler(this.transpositionA_Click);
            // 
            // inverseA
            // 
            this.inverseA.Location = new System.Drawing.Point(12, 246);
            this.inverseA.Name = "inverseA";
            this.inverseA.Size = new System.Drawing.Size(115, 23);
            this.inverseA.TabIndex = 9;
            this.inverseA.Text = "Обратная";
            this.inverseA.UseVisualStyleBackColor = true;
            this.inverseA.Click += new System.EventHandler(this.inverseA_Click);
            // 
            // determinantA
            // 
            this.determinantA.Location = new System.Drawing.Point(12, 275);
            this.determinantA.Name = "determinantA";
            this.determinantA.Size = new System.Drawing.Size(115, 23);
            this.determinantA.TabIndex = 10;
            this.determinantA.Text = "Определитель";
            this.determinantA.UseVisualStyleBackColor = true;
            this.determinantA.Click += new System.EventHandler(this.determinantA_Click);
            // 
            // BmultByNumb
            // 
            this.BmultByNumb.Location = new System.Drawing.Point(562, 305);
            this.BmultByNumb.Name = "BmultByNumb";
            this.BmultByNumb.Size = new System.Drawing.Size(115, 23);
            this.BmultByNumb.TabIndex = 15;
            this.BmultByNumb.Text = "Умножить на:";
            this.BmultByNumb.UseVisualStyleBackColor = true;
            this.BmultByNumb.Click += new System.EventHandler(this.BmultByNumb_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(684, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 16;
            // 
            // determinantB
            // 
            this.determinantB.Location = new System.Drawing.Point(562, 274);
            this.determinantB.Name = "determinantB";
            this.determinantB.Size = new System.Drawing.Size(115, 23);
            this.determinantB.TabIndex = 10;
            this.determinantB.Text = "Определитель";
            this.determinantB.UseVisualStyleBackColor = true;
            this.determinantB.Click += new System.EventHandler(this.determinantB_Click);
            // 
            // inverseB
            // 
            this.inverseB.Location = new System.Drawing.Point(604, 246);
            this.inverseB.Name = "inverseB";
            this.inverseB.Size = new System.Drawing.Size(115, 23);
            this.inverseB.TabIndex = 9;
            this.inverseB.Text = "Обратная";
            this.inverseB.UseVisualStyleBackColor = true;
            this.inverseB.Click += new System.EventHandler(this.inverseB_Click);
            // 
            // transposeB
            // 
            this.transposeB.Location = new System.Drawing.Point(604, 217);
            this.transposeB.Name = "transposeB";
            this.transposeB.Size = new System.Drawing.Size(115, 23);
            this.transposeB.TabIndex = 8;
            this.transposeB.Text = "Транспонировать";
            this.transposeB.UseVisualStyleBackColor = true;
            this.transposeB.Click += new System.EventHandler(this.transposeB_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(685, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 13;
            // 
            // ars_ud
            // 
            this.ars_ud.Location = new System.Drawing.Point(12, 188);
            this.ars_ud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ars_ud.Name = "ars_ud";
            this.ars_ud.Size = new System.Drawing.Size(41, 20);
            this.ars_ud.TabIndex = 19;
            this.ars_ud.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ars_ud.ValueChanged += new System.EventHandler(this.ars_ud_ValueChanged);
            // 
            // acs_ud
            // 
            this.acs_ud.Location = new System.Drawing.Point(59, 188);
            this.acs_ud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.acs_ud.Name = "acs_ud";
            this.acs_ud.Size = new System.Drawing.Size(41, 20);
            this.acs_ud.TabIndex = 20;
            this.acs_ud.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.acs_ud.ValueChanged += new System.EventHandler(this.acs_ud_ValueChanged);
            // 
            // bcs_ud
            // 
            this.bcs_ud.Location = new System.Drawing.Point(678, 188);
            this.bcs_ud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bcs_ud.Name = "bcs_ud";
            this.bcs_ud.Size = new System.Drawing.Size(41, 20);
            this.bcs_ud.TabIndex = 22;
            this.bcs_ud.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.bcs_ud.ValueChanged += new System.EventHandler(this.bcs_ud_ValueChanged);
            // 
            // brs_ud
            // 
            this.brs_ud.Location = new System.Drawing.Point(631, 188);
            this.brs_ud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brs_ud.Name = "brs_ud";
            this.brs_ud.Size = new System.Drawing.Size(41, 20);
            this.brs_ud.TabIndex = 21;
            this.brs_ud.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.brs_ud.ValueChanged += new System.EventHandler(this.brs_ud_ValueChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(133, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 23;
            // 
            // Swap
            // 
            this.Swap.Location = new System.Drawing.Point(287, 119);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(163, 23);
            this.Swap.TabIndex = 24;
            this.Swap.Text = "Поменять местами";
            this.Swap.UseVisualStyleBackColor = true;
            this.Swap.Click += new System.EventHandler(this.Swap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BmultByNumb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AmultByNumb);
            this.Controls.Add(this.determinantB);
            this.Controls.Add(this.determinantA);
            this.Controls.Add(this.inverseB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.transposeB);
            this.Controls.Add(this.inverseA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transpositionA);
            this.Controls.Add(this.Swap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcs_ud);
            this.Controls.Add(this.brs_ud);
            this.Controls.Add(this.acs_ud);
            this.Controls.Add(this.ars_ud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.RES);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ars_ud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acs_ud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcs_ud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brs_ud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView A;
        private System.Windows.Forms.DataGridView B;
        private System.Windows.Forms.DataGridView RES;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button AmultByNumb;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button transpositionA;
        private System.Windows.Forms.Button inverseA;
        private System.Windows.Forms.Button determinantA;
        private System.Windows.Forms.Button determinantB;
        private System.Windows.Forms.Button inverseB;
        private System.Windows.Forms.Button transposeB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ars_ud;
        private System.Windows.Forms.NumericUpDown acs_ud;
        private System.Windows.Forms.NumericUpDown bcs_ud;
        private System.Windows.Forms.NumericUpDown brs_ud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BmultByNumb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Swap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

