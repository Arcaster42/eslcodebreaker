using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ESL_Bomb
{
    public partial class Main : Form
    {
        int bombNumber = 1;

        public Main()
        {
            InitializeComponent();
        }

        private void ngBtn_Click(object sender, EventArgs e)
        {
            Game form2 = new Game(bombNumber);
            this.Hide();
            form2.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            bombNumber++;
            numberLbl.Text = bombNumber.ToString();
            dnBtn.Enabled = true;
            if (bombNumber >= 5)
            {
                upBtn.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bombNumber--;
            numberLbl.Text = bombNumber.ToString();
            upBtn.Enabled = true;
            if (bombNumber <= 1)
            {
                dnBtn.Enabled = false;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
