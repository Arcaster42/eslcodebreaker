using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESL_Bomb
{
    public class TCard
    {
        public string Key { get; set; }
        public string Bad1 { get; set; }
        public string Bad2 { get; set; }
        public string Bad3 { get; set; }
        public int ID { get; set; }

        public TCard(string key, string bad1, string bad2, string bad3, int id)
        {
            Key = key;
            Bad1 = bad1;
            Bad2 = bad2;
            Bad3 = bad3;
            ID = id;
        }
    }
}
