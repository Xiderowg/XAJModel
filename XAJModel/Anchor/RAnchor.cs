using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Anchor
{
    public class RAnchor
    {
        public RAnchor()
        {
            I = 1;O = 2;
        }
        public int I { get; private set; }
        public int O { get; private set; }
    }
}
