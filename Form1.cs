using System.Text;
using System.Text.RegularExpressions;

namespace WordleHelper
{
    public partial class Form1 : Form
    {
        private List<string> words = new List<string>();
        private string[] maskLetters = new string[] { ".", ".", ".", ".", "." };
        private string maskWord;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            InTextBox.Text = String.Empty;
            OutTextBox.Text = String.Empty;
            maskWord = String.Empty;
            maskLetters = new string[] { ".", ".", ".", ".", "." };
            using (StreamReader sr = new StreamReader(@"Data\words.db", Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line.ToUpper().Replace("�", "�"));
                }
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            maskLetters = new string[] { ".", ".", ".", ".", "." };
            if (textBox1.Text.Length != 0) maskLetters[0] = textBox1.Text;
            if (textBox2.Text.Length != 0) maskLetters[1] = textBox2.Text;
            if (textBox3.Text.Length != 0) maskLetters[2] = textBox3.Text;
            if (textBox4.Text.Length != 0) maskLetters[3] = textBox4.Text;
            if (textBox5.Text.Length != 0) maskLetters[4] = textBox5.Text;
            if (InTextBox.Text.Length > 0 || OutTextBox.Text.Length > 0 || String.Join("", maskLetters) != ".....")
            {
                words.Clear();
                using (StreamReader sr = new StreamReader(@"Data\words.db", Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        words.Add(line.ToUpper().Replace("�", "�"));
                    }
                }
                if (InTextBox.Text.Length > 0)
                {
                    words = words.Where(str => InTextBox.Text.All(c => str.Contains(c))).ToList();
                }
                if (OutTextBox.Text.Length > 0)
                {
                    words = words.Where(str => OutTextBox.Text.All(c => !str.Contains(c))).ToList();
                }
                if (maskWord != ".....")
                {
                    words = words.Where(x => Regex.IsMatch(x, $"^{String.Join("", maskLetters)}$")).ToList();
                }
                MessageBox.Show(String.Join("\t", words));
            }
            else
            {
                MessageBox.Show("��� ������, ��� �� �����.\n\n�������� ���� �����-������ �������.", "��������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"��������� ������� ��� ��������� ����� � ���� �5 ���� �� �������� ����� ��� ���������� ������ � ��������.\n\n�� ������ ����� ���������� ����� �� ����� �����, ��������� � ������������� ������.\n\n��������� �������� ������������� � ����������!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddTextBox.Text = String.Empty;
            Height = 403;
            AddLabel.Enabled = true;
            AddLabel.Visible = true;
            AddTextBox.Enabled = true;
            AddTextBox.Visible = true;
            AddBox.Enabled = true;
            AddBox.Visible = true;
            CancelBox.Enabled = true;
            CancelBox.Visible = true;
        }

        private void CancelBox_Click(object sender, EventArgs e)
        {
            AddTextBox.Text = String.Empty;
            Height = 331;
            AddLabel.Enabled = false;
            AddLabel.Visible = false;
            AddTextBox.Enabled = false;
            AddTextBox.Visible = false;
            AddBox.Enabled = false;
            AddBox.Visible = false;
            CancelBox.Enabled = false;
            CancelBox.Visible = false;
        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            if (AddTextBox.Text.Length == 5)
            {
                using (FileStream fs = new FileStream(@"Data\words.db", FileMode.Append, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine(AddTextBox.Text);
                }
                AddTextBox.Text = String.Empty;
                Height = 331;
                AddLabel.Enabled = false;
                AddLabel.Visible = false;
                AddTextBox.Enabled = false;
                AddTextBox.Visible = false;
                AddBox.Enabled = false;
                AddBox.Visible = false;
                CancelBox.Enabled = false;
                CancelBox.Visible = false;
            }
        }
    }
}