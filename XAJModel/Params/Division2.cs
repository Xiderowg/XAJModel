using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Params
{
    public class Division2
    {
        public Division2(double fc,double dt)
        {
            FC = fc;
            DT = dt;
        }
        public double FC { get; private set; }
        public double DT { get; private set; }
    }
}
