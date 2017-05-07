using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Params
{
    public class SConverge
    {
        public SConverge(double cs,double ci,double cg,double cr,double u)
        {
            CS = cs;
            CI = ci;
            CG = cg;
            CR = cr;
            U = u;
        }
        public double CS { get; private set; }
        public double CI { get; private set; }
        public double CG { get; private set; }
        public double CR { get; private set; }
        public double U { get; private set; }
    }
}
