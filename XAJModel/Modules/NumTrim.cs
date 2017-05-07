using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Modules
{
    public static class NumTrim
    {
        /// <summary>
        /// 数字修约
        /// </summary>
        /// <param name="num">带修约数字</param>
        /// <param name="valnum">有效数字</param>
        /// <param name="dotsuffix">小数点后数字数</param>
        /// <returns>修约后的数字</returns>
        /*
        public static double Trim(double num, int valnum=2, int dotsuffix=2)
        {
            double mul = 0, Tnum = 0;
            for (int i = 0; ; i++)
            {
                mul = Math.Pow(10, i);
                Tnum = num / mul;
                if (Tnum <= 10)
                {
                    if (Tnum < 1)
                    {
                        if (valnum == dotsuffix)
                            valnum++;
                        else
                            valnum = dotsuffix;
                    }
                    break;
                }
            }
            List<char> tchar = Tnum.ToString("F10").ToList();
            long ctr = int.Parse(Tnum.ToString("F10").Substring(valnum + 2));
            int prekey = int.Parse(tchar[valnum].ToString());
            int key = int.Parse(tchar[valnum + 1].ToString());
            if (key > 5 || (key == 5 && (ctr > 0 || (ctr == 0 && prekey % 2 != 0))))
                prekey++;
            tchar[valnum] = prekey.ToString()[0];
            tchar.RemoveRange(valnum + 1, tchar.Count - valnum - 1);
            Tnum = double.Parse(new string(tchar.ToArray())) * mul;
            return Tnum;
        }*/
        public static double Trim(double num,int valnum=2,int dotsuffix = 2)
        {
            return Math.Round(num, valnum);
        }
    }
}
