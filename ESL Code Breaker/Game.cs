using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESL_Bomb
{
    public partial class Game : Form
    {
        string pinNumber;
        Bomb bomb;
        int progress;
        int wireChoice;
        string ansChoice;
        int timer = 600;

        public Game(int bombType)
        {
            InitializeComponent();
            timer1.Start();

            if (bombType == 1)
            {
                genBombA();
            }
            else if (bombType == 2)
            {
                genBombC();
            }
            else if (bombType == 3)
            {
                genBombB();
            }
            else if (bombType == 4)
            {
                genBombE();
            }
            else if (bombType == 5)
            {
                genBombD();
            }
            else
            {

            }

        }

        public void genBombA()
        {
            bomb = new Bomb("G6P4LN", 6259, "to rearrange", 2, "rearrange", "to rearrange", "rearranged", "rearranging", "I purchased so many new outfits that I need ______ my closet.");
            wire1.BackColor = Color.Blue;
            wire2.BackColor = Color.Black;
            wire3.BackColor = Color.Yellow;
            wire4.BackColor = Color.Red;
            uiUpdate();
        }

        public void genBombB()
        {
            bomb = new Bomb("8RP21K", 1988, "studying", 3, "to study", "study", "studying", "studied", "My friends really enjoy ______ English.");
            wire1.BackColor = Color.Yellow;
            wire2.BackColor = Color.Red;
            wire3.BackColor = Color.Yellow;
            wire4.BackColor = Color.Blue;
            uiUpdate();
        }

        public void genBombC()
        {
            bomb = new Bomb("Z6389F", 2015, "drove", 4, "drove", "drived", "drive", "driving", "This morning I ______ to my friend's house.");
            wire1.BackColor = Color.Black;
            wire2.BackColor = Color.Black;
            wire3.BackColor = Color.Blue;
            wire4.BackColor = Color.Blue;
            uiUpdate();
        }

        public void genBombD()
        {
            bomb = new Bomb("2UP3K4", 8461, "to look at", 1, "to watch", "to see", "to look at", "to read", "We often go to the art show ______ paintings.");
            wire1.BackColor = Color.Green;
            wire2.BackColor = Color.Red;
            wire3.BackColor = Color.Yellow;
            wire4.BackColor = Color.Yellow;
            uiUpdate();
        }

        public void genBombE()
        {
            bomb = new Bomb("FPNMWQ", 3744, "deciding", 2, "to decide", "decided", "decide", "deciding", "I am busy ______ which job I want.");
            wire1.BackColor = Color.Blue;
            wire2.BackColor = Color.Green;
            wire3.BackColor = Color.Yellow;
            wire4.BackColor = Color.Red;
            uiUpdate();
        }

        public void uiUpdate()
        {
            serialLbl.Text = bomb.Serial;
            puzzleLbl.Text = bomb.Question;
            ans1.Text = bomb.Choice1;
            ans2.Text = bomb.Choice2;
            ans3.Text = bomb.Choice3;
            ans4.Text = bomb.Choice4;
            timerLbl.Text = timer.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pinNumber += "1";
            UpdateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pinNumber += "2";
            UpdateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pinNumber += "3";
            UpdateString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pinNumber += "4";
            UpdateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pinNumber += "5";
            UpdateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pinNumber += "6";
            UpdateString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pinNumber += "7";
            UpdateString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pinNumber += "8";
            UpdateString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pinNumber += "9";
            UpdateString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pinNumber += "0";
            UpdateString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pinNumber = string.Empty;
            UpdateString();
        }

        private void UpdateString()
        {
            pinBox.Text = pinNumber;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (pinNumber == bomb.Pin.ToString())
            {
                btnE.Enabled = false;
                progress = progress + 25;
                ProgressUpdate();
            }
            else
            {
                try
                {
                    MessageBox.Show("Incorrect. Timer speed increased.");
                    timer1.Interval = timer1.Interval / 2;
                }
                catch
                {
                    MessageBox.Show("Incorrect. Timer speed increased.");
                    timer1.Interval = 1;
                }
            }
        }

        private void ProgressUpdate()
        {
            progressBar1.Value = progress;
            if (progressBar1.Value >= 75)
            {
                disableBtn.Enabled = true;
            }
        }

        private void wire1_Click(object sender, EventArgs e)
        {
            wireChoice = 1;
            wire1.Hide();
            WireCheck(wireChoice);
        }

        private void wire2_Click(object sender, EventArgs e)
        {
            wireChoice = 2;
            wire2.Hide();
            WireCheck(wireChoice);
        }

        private void wire3_Click(object sender, EventArgs e)
        {
            wireChoice = 3;
            wire3.Hide();
            WireCheck(wireChoice);
        }

        private void wire4_Click(object sender, EventArgs e)
        {
            wireChoice = 4;
            wire4.Hide();
            WireCheck(wireChoice);
        }

        private void WireCheck(int wireChoice)
        {
            if (wireChoice == bomb.Wire)
            {
                wire1.Enabled = false;
                wire2.Enabled = false;
                wire3.Enabled = false;
                wire4.Enabled = false;
                progress = progress + 25;
                ProgressUpdate();
            }
            else
            {
                try
                {
                    MessageBox.Show("Incorrect. Timer speed increased.");
                    timer1.Interval = timer1.Interval / 2;
                }
                catch
                {
                    MessageBox.Show("Incorrect. Timer speed increased.");
                    timer1.Interval = 1;
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (ans1.Checked == true)
            {
                ansChoice = ans1.Text;
                AnsCheck(ansChoice);
            }
            else if (ans2.Checked == true)
            {
                ansChoice = ans2.Text;
                AnsCheck(ansChoice);
            }
            else if (ans3.Checked == true)
            {
                ansChoice = ans3.Text;
                AnsCheck(ansChoice);
            }
            else if (ans4.Checked == true)
            {
                ansChoice = ans4.Text;
                AnsCheck(ansChoice);
            }
            else
            {

            }
        }

        private void AnsCheck(string ansChoice)
        {
            if (ansChoice == bomb.Code)
            {
                confirmBtn.Enabled = false;
                progress = progress + 25;
                ProgressUpdate();
            }
            else
            {
                try
                {
                    MessageBox.Show("Incorrect. Timer speed increased.");
                    timer1.Interval = timer1.Interval / 2;
                }
                catch
                {
                    MessageBox.Show("Incorrect. Timer speed increased.");
                    timer1.Interval = 1;
                }
            }
        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            timer1.Stop();
            MessageBox.Show("Success!");
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You failed!");
                this.Close();
            }
            else
            {
                timer = timer - 1;
                timerLbl.Text = timer.ToString();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
