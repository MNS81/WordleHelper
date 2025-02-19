namespace WordleHelper
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AddLabel = new Label();
            AddTextBox = new TextBox();
            AddBox = new PictureBox();
            CancelBox = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CancelBox).BeginInit();
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
            tableLayoutPanel1.Location = new Point(12, 38);
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
            textBox5.TabStop = false;
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
            textBox4.TabStop = false;
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
            textBox3.TabStop = false;
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
            textBox2.TabStop = false;
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
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 1;
            label1.Text = "Точное местоположение букв";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Правильные буквы";
            // 
            // InTextBox
            // 
            InTextBox.CharacterCasing = CharacterCasing.Upper;
            InTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            InTextBox.Location = new Point(12, 124);
            InTextBox.Name = "InTextBox";
            InTextBox.Size = new Size(276, 43);
            InTextBox.TabIndex = 3;
            InTextBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 170);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 4;
            label3.Text = "Неправильные буквы";
            // 
            // OutTextBox
            // 
            OutTextBox.CharacterCasing = CharacterCasing.Upper;
            OutTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OutTextBox.Location = new Point(12, 188);
            OutTextBox.Name = "OutTextBox";
            OutTextBox.Size = new Size(276, 43);
            OutTextBox.TabIndex = 5;
            OutTextBox.TabStop = false;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(12, 246);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(107, 34);
            GenerateButton.TabIndex = 6;
            GenerateButton.Text = "Подобрать";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(180, 246);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(108, 34);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(271, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(245, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AddLabel
            // 
            AddLabel.AutoSize = true;
            AddLabel.Enabled = false;
            AddLabel.Location = new Point(12, 292);
            AddLabel.Name = "AddLabel";
            AddLabel.Size = new Size(160, 15);
            AddLabel.TabIndex = 10;
            AddLabel.Text = "Добавить слово в словарь";
            AddLabel.Visible = false;
            // 
            // AddTextBox
            // 
            AddTextBox.CharacterCasing = CharacterCasing.Upper;
            AddTextBox.Enabled = false;
            AddTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddTextBox.Location = new Point(12, 310);
            AddTextBox.MaxLength = 5;
            AddTextBox.Name = "AddTextBox";
            AddTextBox.PlaceholderText = "Новое слово";
            AddTextBox.Size = new Size(182, 43);
            AddTextBox.TabIndex = 11;
            AddTextBox.TabStop = false;
            AddTextBox.Visible = false;
            // 
            // AddBox
            // 
            AddBox.Enabled = false;
            AddBox.Image = (Image)resources.GetObject("AddBox.Image");
            AddBox.Location = new Point(200, 310);
            AddBox.Name = "AddBox";
            AddBox.Size = new Size(43, 43);
            AddBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AddBox.TabIndex = 12;
            AddBox.TabStop = false;
            AddBox.Visible = false;
            AddBox.Click += AddBox_Click;
            // 
            // CancelBox
            // 
            CancelBox.Enabled = false;
            CancelBox.Image = (Image)resources.GetObject("CancelBox.Image");
            CancelBox.Location = new Point(245, 310);
            CancelBox.Name = "CancelBox";
            CancelBox.Size = new Size(43, 43);
            CancelBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CancelBox.TabIndex = 13;
            CancelBox.TabStop = false;
            CancelBox.Visible = false;
            CancelBox.Click += CancelBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 292);
            Controls.Add(CancelBox);
            Controls.Add(AddBox);
            Controls.Add(AddTextBox);
            Controls.Add(AddLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CancelBox).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label AddLabel;
        private TextBox AddTextBox;
        private PictureBox AddBox;
        private PictureBox CancelBox;
    }
}
