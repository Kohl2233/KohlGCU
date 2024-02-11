using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start
            watch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stop
            watch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Reset
            watch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Display Time
            label1.Text = watch.Elapsed.ToString(@"m\:ss");

            if (random.Next(0, 10) < 5)
            {
                button4.Left = random.Next(0, this.Width - button4.Width);
                button4.Top = random.Next(50, this.Height - 50);
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                button4.BackColor = randomColor;
                button4.Visible = true;
                label2.ForeColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Target Btn
            score++;
            timer1.Interval -= 50;
            timer2.Interval -= 50;
            label2.Text = score.ToString();
            button4.Visible = false;

            if (score > 9)
            {
                // Game Win
                timer1.Stop();
                timer2.Stop();
                string msg = "YOU WON!!";
                string caption = "GAME OVER";
                MessageBoxButtons btns = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(msg, caption, btns);
                if (result == DialogResult.OK) { this.Close(); }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // End Game if missed click
            timer1.Stop();
            timer2.Stop();
            string msg = "You missed the click!";
            string caption = "GAME OVER";
            MessageBoxButtons btns = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(msg, caption, btns);
            if (result == DialogResult.OK) { this.Close(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            score--;
            timer1.Interval += 50;
            timer2.Interval += 50;
            button5.Visible = false;
            label2.Text = score.ToString();
            label2.ForeColor = Color.Red;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button5.Left = random.Next(0, this.Width - button5.Width);
            button5.Top = random.Next(50, this.Height - 50);
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            button5.BackColor = randomColor;
            button5.Visible = true;
        }
    }
}