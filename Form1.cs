using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double Eval(string expression)
        {
            return CSharpScript.EvaluateAsync<double>(expression).Result;
        }

        private void button1_Click(object sender, EventArgs e) // clear
        {
            textBox1.Text = "";
        }

        private void button_Click(object sender, EventArgs e) // symbols
        {
            Button button = (Button)sender;

            textBox1.Text += button.Text;
        }

        private void button19_Click(object sender, EventArgs e) // delete
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button20_Click(object sender, EventArgs e) // =
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = Eval(textBox1.Text).ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            label1.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }
    }
}
