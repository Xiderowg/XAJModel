using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Params
{
    public class Division
    {
        public Division(double sm,double ex,double ki,double kg,double im)
        {
            MS = sm * (1 + ex);
            EX = ex;
            SM = sm;
            KI = ki;
            KG = kg;
            IM = im;
        }
        public double SM { get; private set; }
        public double MS { get; private set; }
        public double EX { get; private set; }
        public double KI { get; private set; }
        public double KG { get; private set; }
        public double IM { get; private set; }
    }
}
