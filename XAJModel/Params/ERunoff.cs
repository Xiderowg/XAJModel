using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Params
{
    public class ERunoff
    {
        public ERunoff(double Kc,double C,double WM,double WUM,double WLM,double WDM,double b,double IM)
        {
            this.Kc = Kc;
            this.C = C;
            this.WM = WM;
            this.WUM = WUM;
            this.WLM = WLM;
            this.WDM = WDM;
            this.b = b;
            WMM = (1 + b) * WM;
            this.IM = IM;
        }
        public double Kc { get; private set; }
        public double C { get; private set; }
        public double WM { get; private set; }
        public double WUM { get; private set; }
        public double WLM { get; private set; }
        public double WDM { get; private set; }
        public double b { get; private set; }
        public double WMM { get; private set; }
        public double IM { get; private set; }
    }
}
