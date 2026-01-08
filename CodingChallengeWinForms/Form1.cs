using System.Numerics;
using System.Text;

namespace CodingChallengeWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void fbGenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(fbNTextBox.Text);
                int x = string.IsNullOrWhiteSpace(fbXTextBox.Text) ? 3 : int.Parse(fbXTextBox.Text);
                int y = string.IsNullOrWhiteSpace(fbYTextBox.Text) ? 5 : int.Parse(fbYTextBox.Text);
                if (n < 1 || x < 1 || y < 1)
                {
                    MessageBox.Show("Please enter intergers for n, x and y that are greater or equal to 1.");
                    return;
                }

                string px = string.IsNullOrWhiteSpace(fbPhraseXTextBox.Text) ? "Fizz" : fbPhraseXTextBox.Text.Trim();
                string py = string.IsNullOrWhiteSpace(fbPhraseYTextBox.Text) ? "Buzz" : fbPhraseYTextBox.Text.Trim();
                string pboth = string.IsNullOrWhiteSpace(fbPhraseBothTextBox.Text) ? "FizzBuzz" : fbPhraseBothTextBox.Text.Trim();

                var sb = new StringBuilder();
                for (int i = 1; i <= n; i++)
                {
                    sb.AppendLine(Logic.Substitute(new BigInteger(i), x, y, px, py, pboth));
                }
                fbOutputTextBox.Text = sb.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter valid integers for n, x, and y.");
            }
        }

        private void fbClearButton_Click(object sender, EventArgs e)
        {
            fbOutputTextBox.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void fiGenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(fiNTextBox.Text);
                int a = int.Parse(fiATextBox.Text);
                int b = int.Parse(fiBTextBox.Text);

                if (n < 1 || a < 1 || b < 1)
                {
                    MessageBox.Show("Please enter intergers for n, a and b that are greater or equal to 1.");
                    return;
                }

                var sequence = Logic.GenerateSequence(n, a, b);
                var sb = new StringBuilder();
                for (int i = 0; i < sequence.Count; i++)
                {
                    sb.AppendLine($"F({i + 1}) = {sequence[i]}");
                }

                fiOutputTextBox.Text = sb.ToString();

            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter valid integers for n, a, and b.");
            }

        }

        private void fiClearButton_Click(object sender, EventArgs e)
        {
            fiOutputTextBox.Clear();
        }

        private void cxGenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(cxNTextBox.Text);
                int a = int.Parse(cxATextBox.Text);
                int b = int.Parse(cxBTextBox.Text);
                int x = string.IsNullOrWhiteSpace(cxXTextBox.Text) ? 3 : int.Parse(cxXTextBox.Text); 
                int y = string.IsNullOrWhiteSpace(cxYTextBox.Text) ? 5 : int.Parse(cxYTextBox.Text);
                if (n < 1 || a < 1 || b < 1 || x < 1 || y < 1)
                {
                    MessageBox.Show("Please enter intergers for n, a, b, x and y that are greater or equal to 1.");
                    return;
                }
                string px = string.IsNullOrWhiteSpace(cxPhraseXTextBox.Text) ? "Fizz" : cxPhraseXTextBox.Text.Trim();
                string py = string.IsNullOrWhiteSpace(cxPhraseYTextBox.Text) ? "Buzz" : cxPhraseYTextBox.Text.Trim();
                string pb = string.IsNullOrWhiteSpace(cxPhraseBothTextBox.Text) ? "FizzBuzz" : cxPhraseBothTextBox.Text.Trim();
                var sequence = Logic.GenerateSequence(n, a, b);
                var sb = new StringBuilder();
                for (int i = 0; i < sequence.Count; i++)
                {
                    sb.AppendLine($"F({i + 1}) = {Logic.Substitute(sequence[i], x, y, px, py, pb)}");
                }
                cxOutputTextBox.Text = sb.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter valid integers for n, a, and b.");
            }
           
        }

        private void cxClearButton_Click(object sender, EventArgs e)
        {
            cxOutputTextBox.Clear();
        }
    }
}
