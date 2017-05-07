using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Params
{
    public class RConverge
    {
        public RConverge(double dt,double ke,double xe,double n)
        {
            DT = dt;
            KE = ke;
            XE = xe;
            N = n;
        }
        public double DT { get; private set; }
        public double N { get; private set; }
        public double KE { get; private set; }
        public double XE { get; private set; }
    }
}
