using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESL_Bomb
{
    public class Bomb
    {
        public string Serial { get; set; }
        public int Pin { get; set; }
        public string Code { get; set; }
        public int Wire { get; set; }
        public string Choice1 { get; set; }
        public string Choice2 { get; set; }
        public string Choice3 { get; set; }
        public string Choice4 { get; set; }
        public string Question { get; set; }

        public Bomb(string serial, int pin, string code, int wire, string choice1, string choice2, string choice3, string choice4, string question)
        {
            Serial = serial;
            Pin = pin;
            Code = code;
            Wire = wire;
            Choice1 = choice1;
            Choice2 = choice2;
            Choice3 = choice3;
            Choice4 = choice4;
            Question = question;
        }
    }
}
