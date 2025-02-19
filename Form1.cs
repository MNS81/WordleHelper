using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                    words.Add(line.ToUpper().Replace("Ё", "Е"));
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
                maskWord = String.Join("", maskLetters);
                using (StreamReader sr = new StreamReader(@"Data\words.db", Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        words.Add(line.ToUpper().Replace("Ё", "Е"));
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
                    words = words.Where(x => Regex.IsMatch(x, $"^{maskWord}$")).ToList();
                }
                MessageBox.Show(String.Join("\t", words));
                words.Clear();
                maskWord = String.Empty;
            }
            else
            {
                MessageBox.Show("Нет ребята, так не пойдёт.\n\nДобавьте хоть какие-нибудь буковки.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Программа поможет вам разгадать слово в игре «5 букв» от Тинькофф банка или приложении Вордли и выиграть.\n\nВы можете найти правильный ответ по маске слова, известным и отсутствующим буквам.\n\nПрограмма работает исключительно с кириллицей!");
        }
    }
}
