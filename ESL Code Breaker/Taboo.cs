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
    public partial class Taboo : Form
    {
        int cardNumber;
        TCard card1 = new TCard("happy", "sad", "angry", "glad", 1);
        TCard card2 = new TCard("chair", "table", "seat", "sit", 2);
        TCard card3 = new TCard("run", "walk", "fast", "skip", 3);
        TCard card4 = new TCard("computer", "keyboard", "mouse", "monitor", 4);
        TCard card5 = new TCard("language", "English", "Japanese", "speak", 5);
        TCard card6 = new TCard("book", "read", "comic", "bookstore", 6);
        List<TCard> tcards = new List<TCard>();

        Random cardRand = new Random();
        int points;
        bool c1, c2, c3, c4, c5, c6;

        public Taboo()
        {
            InitializeComponent();
            tcards.Add(card1);
            tcards.Add(card2);
            tcards.Add(card3);
            tcards.Add(card4);
            tcards.Add(card5);
            tcards.Add(card6);
        }

        public void CardMethod()
        {
            cardNumber = cardRand.Next(1, 6);
//            foreach (int id in tcards)
                {

            }
 //           keyLbl.Text = card.Key;
 //           bad1Lbl.Text = card.Bad1;
 //           bad2Lbl.Text = card.Bad2;
 //           bad3Lbl.Text = card.Bad3;
        }

        private void Taboo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            points++;
 //           card.Played = true;

        }
    }
}
