using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Anchor
{
    public class SAnchor
    {
        public SAnchor()
        {
            RS = 1;RI = 2;RG = 3;q = 4;QS = 5;QI = 6;QG = 7;QT = 8;Q = 9;
        }
        public int RS { get; private set; }
        public int RI { get; private set; }
        public int RG { get; private set; }
        public int q { get; private set; }
        public int QS { get; set; }
        public int QI { get; set; }
        public int QG { get; set; }
        public int QT { get; set; }
        public int Q { get; set; }
    }
}
