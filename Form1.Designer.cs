namespace lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            выходToolStripMenuItem = new ToolStripMenuItem();
            выходИзПрограммыToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            copiesSource = new TextBox();
            label3 = new Label();
            copiesNum = new TextBox();
            copiesResult = new TextBox();
            label4 = new Label();
            copiesBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            wordsSource = new TextBox();
            wordsBtn = new Button();
            label7 = new Label();
            wordsRes = new TextBox();
            label8 = new Label();
            label9 = new Label();
            concatFirst = new TextBox();
            label10 = new Label();
            concatSecond = new TextBox();
            concatBtn = new Button();
            label11 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходИзПрограммыToolStripMenuItem });
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(53, 20);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            выходИзПрограммыToolStripMenuItem.Size = new Size(192, 22);
            выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            выходИзПрограммыToolStripMenuItem.Click += выходИзПрограммыToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "1.Функция Copies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 58);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Исходная строка";
            // 
            // copiesSource
            // 
            copiesSource.Location = new Point(141, 55);
            copiesSource.Name = "copiesSource";
            copiesSource.Size = new Size(356, 23);
            copiesSource.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 90);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 4;
            label3.Text = "Сколько раз копировать";
            // 
            // copiesNum
            // 
            copiesNum.Location = new Point(181, 87);
            copiesNum.Name = "copiesNum";
            copiesNum.Size = new Size(169, 23);
            copiesNum.TabIndex = 5;
            // 
            // copiesResult
            // 
            copiesResult.Location = new Point(121, 170);
            copiesResult.Name = "copiesResult";
            copiesResult.Size = new Size(617, 23);
            copiesResult.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 173);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Результат";
            // 
            // copiesBtn
            // 
            copiesBtn.Location = new Point(21, 122);
            copiesBtn.Name = "copiesBtn";
            copiesBtn.Size = new Size(75, 23);
            copiesBtn.TabIndex = 8;
            copiesBtn.Text = "Ок";
            copiesBtn.UseVisualStyleBackColor = true;
            copiesBtn.Click += copiesBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 208);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 9;
            label5.Text = "2.Функция Words";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 236);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 10;
            label6.Text = "Исходная строка";
            // 
            // wordsSource
            // 
            wordsSource.Location = new Point(141, 233);
            wordsSource.Name = "wordsSource";
            wordsSource.Size = new Size(356, 23);
            wordsSource.TabIndex = 11;
            // 
            // wordsBtn
            // 
            wordsBtn.Location = new Point(21, 266);
            wordsBtn.Name = "wordsBtn";
            wordsBtn.Size = new Size(75, 23);
            wordsBtn.TabIndex = 12;
            wordsBtn.Text = "Ок";
            wordsBtn.UseVisualStyleBackColor = true;
            wordsBtn.Click += wordsBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 305);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 13;
            label7.Text = "Результат";
            // 
            // wordsRes
            // 
            wordsRes.Location = new Point(100, 297);
            wordsRes.Name = "wordsRes";
            wordsRes.Size = new Size(617, 23);
            wordsRes.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 335);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 15;
            label8.Text = "3.Функция Concat";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 359);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 16;
            label9.Text = "Строка 1";
            // 
            // concatFirst
            // 
            concatFirst.Location = new Point(100, 353);
            concatFirst.Name = "concatFirst";
            concatFirst.Size = new Size(356, 23);
            concatFirst.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 386);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 18;
            label10.Text = "Строка 2";
            // 
            // concatSecond
            // 
            concatSecond.Location = new Point(100, 386);
            concatSecond.Name = "concatSecond";
            concatSecond.Size = new Size(356, 23);
            concatSecond.TabIndex = 19;
            // 
            // concatBtn
            // 
            concatBtn.Location = new Point(23, 415);
            concatBtn.Name = "concatBtn";
            concatBtn.Size = new Size(75, 23);
            concatBtn.TabIndex = 20;
            concatBtn.Text = "Ок";
            concatBtn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 441);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 21;
            label11.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(concatBtn);
            Controls.Add(concatSecond);
            Controls.Add(label10);
            Controls.Add(concatFirst);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(wordsRes);
            Controls.Add(label7);
            Controls.Add(wordsBtn);
            Controls.Add(wordsSource);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(copiesBtn);
            Controls.Add(label4);
            Controls.Add(copiesResult);
            Controls.Add(copiesNum);
            Controls.Add(label3);
            Controls.Add(copiesSource);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox copiesSource;
        private Label label3;
        private TextBox copiesNum;
        private TextBox copiesResult;
        private Label label4;
        private Button copiesBtn;
        private Label label5;
        private Label label6;
        private TextBox wordsSource;
        private Button wordsBtn;
        private Label label7;
        private TextBox wordsRes;
        private Label label8;
        private Label label9;
        private TextBox concatFirst;
        private Label label10;
        private TextBox concatSecond;
        private Button concatBtn;
        private Label label11;
    }
}
