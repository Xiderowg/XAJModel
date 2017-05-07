using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Anchor
{
    public class EAnchor
    {
        public EAnchor()
        {
            P = 1; E0 = 2; Ep = 3; Eu = 4; El = 5; Ed = 6; E = 7;PE = 8; WU = 9; WL = 10; WD = 11; W = 12;R = 13;RB = 14; RPE = 15;
        }
        public int P { get; private set; }
        public int E0 { get; private set; }
        public int Ep { get; private set; }
        public int Eu { get; private set; }
        public int El { get; private set; }
        public int Ed { get; private set; }
        public int E { get; private set; }
        public int PE { get; private set; }
        public int WU { get; private set; }
        public int WL { get; private set; }
        public int WD { get; private set; }
        public int W { get; private set; }
        public int R { get; private set; }
        public int RB { get; private set; }
        public int RPE { get; private set; }
    }
}
