﻿namespace WordleHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            InTextBox = new TextBox();
            label3 = new Label();
            OutTextBox = new TextBox();
            GenerateButton = new Button();
            ClearButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(textBox5, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(276, 65);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.CharacterCasing = CharacterCasing.Upper;
            textBox5.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(223, 3);
            textBox5.MaxLength = 1;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "*";
            textBox5.Size = new Size(49, 61);
            textBox5.TabIndex = 4;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.CharacterCasing = CharacterCasing.Upper;
            textBox4.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(168, 3);
            textBox4.MaxLength = 1;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "*";
            textBox4.Size = new Size(49, 61);
            textBox4.TabIndex = 3;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(113, 3);
            textBox3.MaxLength = 1;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "*";
            textBox3.Size = new Size(49, 61);
            textBox3.TabIndex = 2;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(58, 3);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "*";
            textBox2.Size = new Size(49, 61);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(3, 3);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "*";
            textBox1.Size = new Size(49, 61);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 1;
            label1.Text = "Точное местоположение букв";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Известные буквы";
            // 
            // InTextBox
            // 
            InTextBox.CharacterCasing = CharacterCasing.Upper;
            InTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            InTextBox.Location = new Point(12, 113);
            InTextBox.Name = "InTextBox";
            InTextBox.Size = new Size(276, 43);
            InTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 4;
            label3.Text = "Исключить буквы";
            // 
            // OutTextBox
            // 
            OutTextBox.CharacterCasing = CharacterCasing.Upper;
            OutTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OutTextBox.Location = new Point(12, 177);
            OutTextBox.Name = "OutTextBox";
            OutTextBox.Size = new Size(276, 43);
            OutTextBox.TabIndex = 5;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(12, 237);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(107, 34);
            GenerateButton.TabIndex = 6;
            GenerateButton.Text = "Подобрать";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(180, 237);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(108, 34);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 284);
            Controls.Add(ClearButton);
            Controls.Add(GenerateButton);
            Controls.Add(OutTextBox);
            Controls.Add(label3);
            Controls.Add(InTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wordle game helper";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox InTextBox;
        private Label label3;
        private TextBox OutTextBox;
        private Button GenerateButton;
        private Button ClearButton;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
