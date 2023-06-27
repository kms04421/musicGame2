using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0615
{
    public class MusicSt
    {
        public string MusicName { get; set; }
        public int MusicScore { get; set; } 



        public MusicSt(string Name , int score)
        {
            this.MusicName = Name;
            this.MusicScore = score;
        }
    }
}
